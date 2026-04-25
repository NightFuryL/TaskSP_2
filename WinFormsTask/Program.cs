using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WinFormsTask
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        private static IntPtr SetHook(HookProc proc)
        {
            using (Process cur = Process.GetCurrentProcess())
            using (ProcessModule curModule = cur.MainModule!)
            {
                return SetWindowsHookEx(WM_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }


        private static IntPtr HookCallback_BlockWinKey(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if ((nCode >= 0) && (wParam == (IntPtr)WM_KEYDOWN))
            {
                int wkCode = Marshal.ReadInt32(lParam);
                if (wkCode == VK_LWIN || wkCode == VK_RWIN)
                {
                    Console.WriteLine("Win Key have been blocked!");
                    return (IntPtr)1;
                }
            }
            return CallNextHookEx(hookWinKey, nCode, wParam, lParam);
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll")]
        static extern sbyte GetMessage(out MSG msg, IntPtr hWnd, uint min, uint max);

        [DllImport("user32.dll")]
        static extern bool TranslateMessage([In] ref MSG msg);

        [DllImport("user32.dll")]
        static extern IntPtr DispatchMessage([In] ref MSG msg);
    }
}