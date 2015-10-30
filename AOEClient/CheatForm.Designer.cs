namespace AOEClient
{
    partial class CheatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheatForm));
            this.grpOneTime = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSelectImpOneClicks = new System.Windows.Forms.Button();
            this.btnUnselectOneClicks = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.grpSupplies = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grpMisc = new System.Windows.Forms.GroupBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkFocusLost = new System.Windows.Forms.CheckBox();
            this.cboCustom3 = new System.Windows.Forms.ComboBox();
            this.cboCustom2 = new System.Windows.Forms.ComboBox();
            this.cboCustom1 = new System.Windows.Forms.ComboBox();
            this.cboCustom0 = new System.Windows.Forms.ComboBox();
            this.numCustom3 = new System.Windows.Forms.NumericUpDown();
            this.numCustom2 = new System.Windows.Forms.NumericUpDown();
            this.numCustom1 = new System.Windows.Forms.NumericUpDown();
            this.numCustom0 = new System.Windows.Forms.NumericUpDown();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.numSupplyAmt = new System.Windows.Forms.NumericUpDown();
            this.numXPAmt = new System.Windows.Forms.NumericUpDown();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cboWindowTitle = new System.Windows.Forms.ComboBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chkRevealMap = new System.Windows.Forms.CheckBox();
            this.cheatCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpOneTime.SuspendLayout();
            this.grpSupplies.SuspendLayout();
            this.grpMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCustom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustom0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSupplyAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXPAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheatCodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOneTime
            // 
            this.grpOneTime.Controls.Add(this.chkFocusLost);
            this.grpOneTime.Controls.Add(this.cboWindowTitle);
            this.grpOneTime.Controls.Add(this.linkLabel1);
            this.grpOneTime.Controls.Add(this.checkBox6);
            this.grpOneTime.Controls.Add(this.checkBox5);
            this.grpOneTime.Controls.Add(this.checkBox4);
            this.grpOneTime.Controls.Add(this.checkBox3);
            this.grpOneTime.Controls.Add(this.checkBox2);
            this.grpOneTime.Controls.Add(this.chkRevealMap);
            this.grpOneTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpOneTime.Location = new System.Drawing.Point(12, 7);
            this.grpOneTime.Name = "grpOneTime";
            this.grpOneTime.Size = new System.Drawing.Size(377, 180);
            this.grpOneTime.TabIndex = 0;
            this.grpOneTime.TabStop = false;
            this.grpOneTime.Text = "One Time Cheats";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(201, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Game Window Title: (click to use default)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSelectImpOneClicks
            // 
            this.btnSelectImpOneClicks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectImpOneClicks.FlatAppearance.BorderSize = 0;
            this.btnSelectImpOneClicks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectImpOneClicks.Location = new System.Drawing.Point(13, 474);
            this.btnSelectImpOneClicks.Name = "btnSelectImpOneClicks";
            this.btnSelectImpOneClicks.Size = new System.Drawing.Size(103, 25);
            this.btnSelectImpOneClicks.TabIndex = 4;
            this.btnSelectImpOneClicks.Text = "Select Important";
            this.btnSelectImpOneClicks.UseVisualStyleBackColor = true;
            this.btnSelectImpOneClicks.Click += new System.EventHandler(this.btnSelectImpOneClicks_Click);
            // 
            // btnUnselectOneClicks
            // 
            this.btnUnselectOneClicks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnselectOneClicks.FlatAppearance.BorderSize = 0;
            this.btnUnselectOneClicks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnselectOneClicks.Location = new System.Drawing.Point(122, 474);
            this.btnUnselectOneClicks.Name = "btnUnselectOneClicks";
            this.btnUnselectOneClicks.Size = new System.Drawing.Size(103, 25);
            this.btnUnselectOneClicks.TabIndex = 5;
            this.btnUnselectOneClicks.Text = "Unselect All";
            this.btnUnselectOneClicks.UseVisualStyleBackColor = true;
            this.btnUnselectOneClicks.Click += new System.EventHandler(this.btnUnselectOneClicks_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Location = new System.Drawing.Point(286, 474);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(103, 25);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // grpSupplies
            // 
            this.grpSupplies.Controls.Add(this.groupBox4);
            this.grpSupplies.Controls.Add(this.checkBox14);
            this.grpSupplies.Controls.Add(this.numSupplyAmt);
            this.grpSupplies.Controls.Add(this.numXPAmt);
            this.grpSupplies.Controls.Add(this.checkBox9);
            this.grpSupplies.Controls.Add(this.checkBox8);
            this.grpSupplies.Controls.Add(this.checkBox7);
            this.grpSupplies.Controls.Add(this.checkBox1);
            this.grpSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSupplies.Location = new System.Drawing.Point(12, 197);
            this.grpSupplies.Name = "grpSupplies";
            this.grpSupplies.Size = new System.Drawing.Size(377, 98);
            this.grpSupplies.TabIndex = 1;
            this.grpSupplies.TabStop = false;
            this.grpSupplies.Text = "Quick Supplies - (10,000 * X)";
            // 
            // groupBox4
            // 
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(14, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 8);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // grpMisc
            // 
            this.grpMisc.Controls.Add(this.cboCustom3);
            this.grpMisc.Controls.Add(this.cboCustom2);
            this.grpMisc.Controls.Add(this.cboCustom1);
            this.grpMisc.Controls.Add(this.cboCustom0);
            this.grpMisc.Controls.Add(this.numCustom3);
            this.grpMisc.Controls.Add(this.checkBox12);
            this.grpMisc.Controls.Add(this.numCustom2);
            this.grpMisc.Controls.Add(this.checkBox11);
            this.grpMisc.Controls.Add(this.numCustom1);
            this.grpMisc.Controls.Add(this.checkBox10);
            this.grpMisc.Controls.Add(this.numCustom0);
            this.grpMisc.Controls.Add(this.checkBox13);
            this.grpMisc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpMisc.Location = new System.Drawing.Point(12, 305);
            this.grpMisc.Name = "grpMisc";
            this.grpMisc.Size = new System.Drawing.Size(377, 157);
            this.grpMisc.TabIndex = 3;
            this.grpMisc.TabStop = false;
            this.grpMisc.Text = "Miscellaneous";
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox12.Location = new System.Drawing.Point(15, 121);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(65, 17);
            this.checkBox12.TabIndex = 10;
            this.checkBox12.Tag = "cboCustom3";
            this.checkBox12.Text = "Custom4";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox11.Location = new System.Drawing.Point(14, 89);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(65, 17);
            this.checkBox11.TabIndex = 7;
            this.checkBox11.Tag = "cboCustom2";
            this.checkBox11.Text = "Custom3";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox10.Location = new System.Drawing.Point(15, 57);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(65, 17);
            this.checkBox10.TabIndex = 4;
            this.checkBox10.Tag = "cboCustom1";
            this.checkBox10.Text = "Custom2";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Checked = true;
            this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox13.Location = new System.Drawing.Point(14, 25);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(65, 17);
            this.checkBox13.TabIndex = 1;
            this.checkBox13.Tag = "cboCustom0";
            this.checkBox13.Text = "Custom1";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel2.Location = new System.Drawing.Point(245, 486);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(28, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Test";
            this.toolTip1.SetToolTip(this.linkLabel2, "Click to test if you can find the game window.");
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Supply Tool";
            // 
            // chkFocusLost
            // 
            this.chkFocusLost.AutoSize = true;
            this.chkFocusLost.Checked = true;
            this.chkFocusLost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFocusLost.Location = new System.Drawing.Point(226, 18);
            this.chkFocusLost.Name = "chkFocusLost";
            this.chkFocusLost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkFocusLost.Size = new System.Drawing.Size(139, 17);
            this.chkFocusLost.TabIndex = 9;
            this.chkFocusLost.Text = "Apply When Focus Lost";
            this.toolTip1.SetToolTip(this.chkFocusLost, "Only begin sending codes when this forms focus is lost. \r\nPressing apply will not" +
        " begin until focus is lost.");
            this.chkFocusLost.UseVisualStyleBackColor = true;
            // 
            // cboCustom3
            // 
            this.cboCustom3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AOEClient.Properties.Settings.Default, "CustomItem4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboCustom3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCustom3.FormattingEnabled = true;
            this.cboCustom3.Items.AddRange(new object[] {
            "Ya gotta make do with what ya got",
            "tuck tuck tuck",
            "Where\'s that axe?"});
            this.cboCustom3.Location = new System.Drawing.Point(79, 120);
            this.cboCustom3.Name = "cboCustom3";
            this.cboCustom3.Size = new System.Drawing.Size(239, 21);
            this.cboCustom3.TabIndex = 11;
            this.cboCustom3.Tag = "numCustom3";
            this.cboCustom3.Text = global::AOEClient.Properties.Settings.Default.CustomItem4;
            // 
            // cboCustom2
            // 
            this.cboCustom2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AOEClient.Properties.Settings.Default, "CustomItem3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboCustom2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCustom2.FormattingEnabled = true;
            this.cboCustom2.Items.AddRange(new object[] {
            "Ya gotta make do with what ya got",
            "tuck tuck tuck",
            "Where\'s that axe?"});
            this.cboCustom2.Location = new System.Drawing.Point(79, 88);
            this.cboCustom2.Name = "cboCustom2";
            this.cboCustom2.Size = new System.Drawing.Size(239, 21);
            this.cboCustom2.TabIndex = 8;
            this.cboCustom2.Tag = "numCustom2";
            this.cboCustom2.Text = global::AOEClient.Properties.Settings.Default.CustomItem3;
            // 
            // cboCustom1
            // 
            this.cboCustom1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AOEClient.Properties.Settings.Default, "CustomItem2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCustom1.FormattingEnabled = true;
            this.cboCustom1.Items.AddRange(new object[] {
            "Ya gotta make do with what ya got",
            "tuck tuck tuck",
            "Where\'s that axe?"});
            this.cboCustom1.Location = new System.Drawing.Point(79, 56);
            this.cboCustom1.Name = "cboCustom1";
            this.cboCustom1.Size = new System.Drawing.Size(239, 21);
            this.cboCustom1.TabIndex = 5;
            this.cboCustom1.Tag = "numCustom1";
            this.cboCustom1.Text = global::AOEClient.Properties.Settings.Default.CustomItem2;
            // 
            // cboCustom0
            // 
            this.cboCustom0.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AOEClient.Properties.Settings.Default, "CustomItem1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboCustom0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCustom0.FormattingEnabled = true;
            this.cboCustom0.Items.AddRange(new object[] {
            "Ya gotta make do with what ya got",
            "tuck tuck tuck",
            "Where\'s that axe?",
            ""});
            this.cboCustom0.Location = new System.Drawing.Point(79, 24);
            this.cboCustom0.Name = "cboCustom0";
            this.cboCustom0.Size = new System.Drawing.Size(238, 21);
            this.cboCustom0.TabIndex = 2;
            this.cboCustom0.Tag = "numCustom0";
            this.cboCustom0.Text = global::AOEClient.Properties.Settings.Default.CustomItem1;
            // 
            // numCustom3
            // 
            this.numCustom3.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AOEClient.Properties.Settings.Default, "Custom4Amt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numCustom3.Location = new System.Drawing.Point(323, 121);
            this.numCustom3.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCustom3.Name = "numCustom3";
            this.numCustom3.Size = new System.Drawing.Size(43, 20);
            this.numCustom3.TabIndex = 0;
            this.numCustom3.Value = global::AOEClient.Properties.Settings.Default.Custom4Amt;
            // 
            // numCustom2
            // 
            this.numCustom2.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AOEClient.Properties.Settings.Default, "Custom3Amt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numCustom2.Location = new System.Drawing.Point(323, 89);
            this.numCustom2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCustom2.Name = "numCustom2";
            this.numCustom2.Size = new System.Drawing.Size(43, 20);
            this.numCustom2.TabIndex = 9;
            this.numCustom2.Value = global::AOEClient.Properties.Settings.Default.Custom3Amt;
            // 
            // numCustom1
            // 
            this.numCustom1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AOEClient.Properties.Settings.Default, "Custom2Amt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numCustom1.Location = new System.Drawing.Point(324, 57);
            this.numCustom1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCustom1.Name = "numCustom1";
            this.numCustom1.Size = new System.Drawing.Size(43, 20);
            this.numCustom1.TabIndex = 6;
            this.numCustom1.Value = global::AOEClient.Properties.Settings.Default.Custom2Amt;
            // 
            // numCustom0
            // 
            this.numCustom0.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AOEClient.Properties.Settings.Default, "Custom1Amt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numCustom0.Location = new System.Drawing.Point(323, 25);
            this.numCustom0.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCustom0.Name = "numCustom0";
            this.numCustom0.Size = new System.Drawing.Size(43, 20);
            this.numCustom0.TabIndex = 3;
            this.numCustom0.Value = global::AOEClient.Properties.Settings.Default.Custom1Amt;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Checked = true;
            this.checkBox14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox14.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::AOEClient.Properties.Settings.Default, "Exports", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox14.Location = new System.Drawing.Point(240, 22);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(59, 17);
            this.checkBox14.TabIndex = 3;
            this.checkBox14.Tag = global::AOEClient.Properties.Settings.Default.Exports;
            this.checkBox14.Text = "Exports";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // numSupplyAmt
            // 
            this.numSupplyAmt.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AOEClient.Properties.Settings.Default, "SuppliesAmt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numSupplyAmt.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSupplyAmt.Location = new System.Drawing.Point(323, 19);
            this.numSupplyAmt.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSupplyAmt.Name = "numSupplyAmt";
            this.numSupplyAmt.Size = new System.Drawing.Size(43, 20);
            this.numSupplyAmt.TabIndex = 4;
            this.numSupplyAmt.Value = global::AOEClient.Properties.Settings.Default.SuppliesAmt;
            // 
            // numXPAmt
            // 
            this.numXPAmt.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AOEClient.Properties.Settings.Default, "XPAmt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numXPAmt.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numXPAmt.Location = new System.Drawing.Point(323, 66);
            this.numXPAmt.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numXPAmt.Name = "numXPAmt";
            this.numXPAmt.Size = new System.Drawing.Size(43, 20);
            this.numXPAmt.TabIndex = 6;
            this.numXPAmt.Value = global::AOEClient.Properties.Settings.Default.XPAmt;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::AOEClient.Properties.Settings.Default, "WoodTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox9.Location = new System.Drawing.Point(163, 22);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(53, 17);
            this.checkBox9.TabIndex = 2;
            this.checkBox9.Tag = global::AOEClient.Properties.Settings.Default.WoodTag;
            this.checkBox9.Text = "Wood";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::AOEClient.Properties.Settings.Default, "XPTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox8.Location = new System.Drawing.Point(240, 69);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(38, 17);
            this.checkBox8.TabIndex = 5;
            this.checkBox8.Tag = global::AOEClient.Properties.Settings.Default.XPTag;
            this.checkBox8.Text = "XP";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::AOEClient.Properties.Settings.Default, "FoodTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox7.Location = new System.Drawing.Point(91, 22);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(48, 17);
            this.checkBox7.TabIndex = 1;
            this.checkBox7.Tag = global::AOEClient.Properties.Settings.Default.FoodTag;
            this.checkBox7.Text = "Food";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::AOEClient.Properties.Settings.Default, "GoldTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Location = new System.Drawing.Point(22, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = global::AOEClient.Properties.Settings.Default.GoldTag;
            this.checkBox1.Text = "Coin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cboWindowTitle
            // 
            this.cboWindowTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboWindowTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AOEClient.Properties.Settings.Default, "WindowTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboWindowTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboWindowTitle.FormattingEnabled = true;
            this.cboWindowTitle.Items.AddRange(new object[] {
            "Age of Empires III",
            "Age of Empires III - The Asian Dynasties",
            "Age of Empires III - The War Chiefs",
            "Age of Empires 3",
            "Age of Empires 3 - The Asian Dynasties",
            "Age of Empires 3 - The War Chiefs"});
            this.cboWindowTitle.Location = new System.Drawing.Point(14, 47);
            this.cboWindowTitle.Name = "cboWindowTitle";
            this.cboWindowTitle.Size = new System.Drawing.Size(350, 21);
            this.cboWindowTitle.TabIndex = 0;
            this.cboWindowTitle.Text = global::AOEClient.Properties.Settings.Default.WindowTitle;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::AOEClient.Properties.Settings.Default, "BuildRateTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox6.Location = new System.Drawing.Point(236, 84);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox6.Size = new System.Drawing.Size(128, 17);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Tag = global::AOEClient.Properties.Settings.Default.BuildRateTag;
            this.checkBox6.Text = "Build / Gather Quickly";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::AOEClient.Properties.Settings.Default, "MusketeeredTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox5.Location = new System.Drawing.Point(278, 151);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox5.Size = new System.Drawing.Size(86, 17);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Tag = global::AOEClient.Properties.Settings.Default.MusketeeredTag;
            this.checkBox5.Text = "Musketeered";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::AOEClient.Properties.Settings.Default, "WinGameTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox4.Location = new System.Drawing.Point(14, 151);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(91, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Tag = global::AOEClient.Properties.Settings.Default.WinGameTag;
            this.checkBox4.Text = "Instant Victory";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::AOEClient.Properties.Settings.Default, "DestroyBoatsTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox3.Location = new System.Drawing.Point(226, 117);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox3.Size = new System.Drawing.Size(138, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Tag = global::AOEClient.Properties.Settings.Default.DestroyBoatsTag;
            this.checkBox3.Text = "Destroy all Enemy Boats";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::AOEClient.Properties.Settings.Default, "FlattenAnimals", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox2.Location = new System.Drawing.Point(14, 117);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Tag = global::AOEClient.Properties.Settings.Default.FlattenAnimals;
            this.checkBox2.Text = "Kill all Animals";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // chkRevealMap
            // 
            this.chkRevealMap.AutoSize = true;
            this.chkRevealMap.Checked = true;
            this.chkRevealMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRevealMap.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::AOEClient.Properties.Settings.Default, "RevealMapTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkRevealMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkRevealMap.Location = new System.Drawing.Point(14, 84);
            this.chkRevealMap.Name = "chkRevealMap";
            this.chkRevealMap.Size = new System.Drawing.Size(82, 17);
            this.chkRevealMap.TabIndex = 1;
            this.chkRevealMap.Tag = global::AOEClient.Properties.Settings.Default.RevealMapTag;
            this.chkRevealMap.Text = "Reveal Map";
            this.chkRevealMap.UseVisualStyleBackColor = true;
            // 
            // cheatCodeBindingSource
            // 
            this.cheatCodeBindingSource.DataSource = typeof(AOEClient.CheatCode);
            // 
            // CheatForm
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 509);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.grpMisc);
            this.Controls.Add(this.grpSupplies);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnUnselectOneClicks);
            this.Controls.Add(this.btnSelectImpOneClicks);
            this.Controls.Add(this.grpOneTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CheatForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Age of Empire Supply Tool";
            this.Deactivate += new System.EventHandler(this.CheatForm_Deactivate);
            this.Load += new System.EventHandler(this.CheatForm_Load);
            this.grpOneTime.ResumeLayout(false);
            this.grpOneTime.PerformLayout();
            this.grpSupplies.ResumeLayout(false);
            this.grpSupplies.PerformLayout();
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCustom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustom0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSupplyAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXPAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheatCodeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cheatCodeBindingSource;
        private System.Windows.Forms.GroupBox grpOneTime;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox chkRevealMap;
        private System.Windows.Forms.Button btnUnselectOneClicks;
        private System.Windows.Forms.Button btnSelectImpOneClicks;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cboWindowTitle;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox grpSupplies;
        private System.Windows.Forms.NumericUpDown numSupplyAmt;
        private System.Windows.Forms.NumericUpDown numXPAmt;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grpMisc;
        private System.Windows.Forms.NumericUpDown numCustom0;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboCustom0;
        private System.Windows.Forms.ComboBox cboCustom3;
        private System.Windows.Forms.NumericUpDown numCustom3;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.ComboBox cboCustom2;
        private System.Windows.Forms.NumericUpDown numCustom2;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.ComboBox cboCustom1;
        private System.Windows.Forms.NumericUpDown numCustom1;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkFocusLost;
    }
}