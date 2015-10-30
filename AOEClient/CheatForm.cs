using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AOEClient
{
    public partial class CheatForm : Form
    {
        IList<string> _unimportantSelections;
        bool _bShouldSendCodes;

        public CheatForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cboWindowTitle.SelectedIndex = 0;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyCodes();   
        }

        private void InternalApplyCodes()
        {
            IList<CheatCode> codes = new List<CheatCode>();
            foreach (CheckBox cb in Controls.OfType<GroupBox>().SelectMany(grp => grp.Controls.OfType<CheckBox>().Where(ctl => ctl.Checked)))
            {
                var amount = (short)numSupplyAmt.Value;
                var code = cb.Tag?.ToString();

                if (cb.Parent is GroupBox && cb.Parent.Text.StartsWith("One"))
                {
                    amount = 1;
                }
                else if (cb.Text.StartsWith("XP"))
                {
                    amount = (short)numXPAmt.Value;
                }
                else if (cb.Text.StartsWith("Custom"))
                {
                    var custom = grpMisc.Controls[code];
                    var num = (grpMisc.Controls[custom?.Tag.ToString()] as NumericUpDown);

                    code = custom?.Text;
                    amount = (short) (num?.Value ?? 0);
                }

                if (string.IsNullOrEmpty(code) || amount <= 0)
                    continue;

                codes.Add(new CheatCode(cb.Text, code, amount));
            }

            CallBackMod.SubmitGameCheatCode(codes);
        }

        private bool GetValidGameHandle(bool bShowWindowTest = false)
        {
            return CallBackMod.AttachToGameWindow(cboWindowTitle.Text, bShowWindowTest);
        }

        private void btnUnselectOneClicks_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in Controls.OfType<GroupBox>().SelectMany(grp => grp.Controls.OfType<CheckBox>().Where(ctl => ctl.Checked && !ctl.Text.StartsWith("Apply"))))
                cb.CheckState = CheckState.Unchecked;
        }

        private void btnSelectImpOneClicks_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in Controls.OfType<GroupBox>().SelectMany(grp => grp.Controls.OfType<CheckBox>().Where(ctl => !ctl.Checked && !_unimportantSelections.Contains(ctl.Text) && !ctl.Text.StartsWith("Apply"))))
                cb.CheckState = CheckState.Checked;
        }

        private void CheatForm_Load(object sender, EventArgs e)
        {
            cboWindowTitle.SelectedIndex = Properties.Settings.Default.WindowTitleComboIndex;
            _unimportantSelections = Properties.Settings.Default.UnImportantSections.Split(',').ToList();
            GetValidGameHandle();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toolTip1.SetToolTip(linkLabel2, GetValidGameHandle(true)
                    ? $"The last test succeeded.\nGame window with title {cboWindowTitle.Text} found."
                    : $"The last test faild to find the game window with title {cboWindowTitle.Text}.");
        }

        private void CheatForm_Deactivate(object sender, EventArgs e)
        {
            if (_bShouldSendCodes)
                ApplyCodes();
        }

        private void ApplyCodes()
        {
            if (chkFocusLost.Checked && !_bShouldSendCodes)
            {
                btnApply.Text = @"Restore Game";
                _bShouldSendCodes = true;
                btnApply.Enabled = false;
                return;
            }

            try
            {
                Controls.OfType<Button>().ForEach(x => x.Enabled = false);
                Cursor = Cursors.WaitCursor;

                if (GetValidGameHandle())
                {
                    if(chkFocusLost.Checked)
                        System.Threading.Thread.Sleep(Properties.Settings.Default.DelayedSendTime);
                    InternalApplyCodes();
                }
                else
                    MessageBox.Show(@"Unable to locate the Age of Empires window.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
                Controls.OfType<Button>().ForEach(x => x.Enabled = true);
                _bShouldSendCodes = false;
                btnApply.Text = @"Apply";
                toolTip1.SetToolTip(this.linkLabel2, "Click to test if you can find the game window.");
            }
        }
    }
}
