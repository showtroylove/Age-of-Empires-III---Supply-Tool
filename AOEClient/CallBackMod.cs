using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using WindowsInput;
using WindowsInput.Native;

namespace AOEClient
{

    public delegate bool EnumWindowsProc(IntPtr hwnd, string lParam);
    public delegate bool IsWindowVisible(IntPtr hWnd);  

    // ERROR: Not supported in C#: OptionDeclaration
    public static class CallBackMod
    {
        static IntPtr? AgeEmpireApplication { get; set; }

        public static string GameWindowTitle { get; set; }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int EnumWindows(EnumWindowsProc lpEnumFunc, [MarshalAs(UnmanagedType.AnsiBStr)]  string lparam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]        
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern int GetWindowTextLength(IntPtr hWnd); 

        [DllImport("user32.dll", EntryPoint = "GetWindowText", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hwnd, string lpString, int cch);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int ShowWindow(IntPtr hwnd, int nCmdShow);
 
        static bool EnumWindowsProc(IntPtr hwnd, string winTitle)
        {
            // Return True to continue enumerating windows.
            // Function will stop running when all windows have been
            // enumerated.
            //bool functionReturnValue = true;
            var compstring = winTitle;
            //
            // The hWnd argument provides a handle to a specific window each time
            // the callback function runs.
            // The lParam argument can take any data that the user wants to pass to
            // the function.
            //
            // You could use this function to return both visible and non-visible
            // windows by removing the code that calls the IsWindowVisible function.
            var size = GetWindowTextLength(hwnd);
            var strCaption = new string(' ', size);

            // Check whether this window is visible.
            if (size++ > 0 && IsWindowVisible(hwnd))
            {
                GetWindowText(hwnd, strCaption, size);
                strCaption = strCaption.Trim();
                Debug.WriteLine(strCaption);
            }

            if (!strCaption.StartsWith(compstring, true, CultureInfo.InvariantCulture))
                return true;

            AgeEmpireApplication = hwnd;
            
            return false;           
        }

        public static bool AttachToGameWindow(string title = "Age of Empires III", bool bShowWindowTest = false)
        {
            if (string.IsNullOrEmpty(title))
                return false;

            if (title != GameWindowTitle && !AgeEmpireApplication.HasValue)
            {
                GameWindowTitle = title;
                EnumWindows(EnumWindowsProc, title);
            }

            if (bShowWindowTest & AgeEmpireApplication.HasValue)
                ShowWindow(AgeEmpireApplication.Value, 5);

            return AgeEmpireApplication.HasValue;
        }

        public static bool SubmitGameCheatCode(IList<CheatCode> supplyItem)
        {
            if (!AgeEmpireApplication.HasValue)
                return false;

            var hwnd = AgeEmpireApplication.Value;
            foreach (var s in supplyItem)
                SendMessages(hwnd, s.CheatPhrase, s.Amount);

            return true;
        }

        public static IEnumerable<TSource> ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            var lsource = source as TSource[] ?? source.ToArray();
            foreach (TSource item in lsource)
                action(item);
            return lsource;
        }
       
        static void SendMessages(IntPtr hwnd, string phrase, short supplyAmount = 1)
        {
            if (string.IsNullOrEmpty(phrase) || supplyAmount <= 0)
                return;

            ShowWindow(hwnd, 1);

            var key = new InputSimulator();
            for (short i = 0; i < supplyAmount; i++)
            {
                ShowWindow(hwnd, 5);

                key.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                key.Keyboard.Sleep(100);

                key.Keyboard.TextEntry(phrase);
                key.Keyboard.Sleep(30);

                key.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                key.Keyboard.Sleep(30);
            }
        }
    }
}
