using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleTask;

#region 1 session
[StructLayout(LayoutKind.Sequential)]
public struct MSG
{
    public IntPtr hwnd;
    public uint message;
    public IntPtr wParam;
    public IntPtr lParam;
    public uint time;
    public System.Drawing.Point pt;
}
#endregion
public class Program
{
    #region 1 session
    private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

    private const int WM_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;
    private const int VK_LWIN = 0x5B;
    private const int VK_RWIN = 0x5C;

    private static HookProc procBlockWinKey = HookCallback_BlockWinKey;
    private static IntPtr hookWinKey = IntPtr.Zero;

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
    #endregion

    #region 2 session
    private static void PrintRegsKeys(RegistryKey registryKey)
    {
        string[] names = registryKey.GetSubKeyNames();
        Console.WriteLine($"Subkeys of {registryKey.Name}:");
        foreach (var name in names)
        {
            Console.WriteLine($"- {name}");
        }
    }
    #endregion
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        #region 1 session
        /*
        hookWinKey = SetHook(procBlockWinKey);

        MSG msg;
        while (GetMessage(out msg, IntPtr.Zero, 0, 0) != 0)
        {
            TranslateMessage(ref msg);
            DispatchMessage(ref msg);
        }

        UnhookWindowsHookEx(hookWinKey);
        */
        #endregion
        #region 2 session
        Console.OutputEncoding = Encoding.UTF8;
        int selectItem;
        RegistryKey[] regs =
        {
            Registry.ClassesRoot,
            Registry.CurrentUser,
            Registry.LocalMachine,
            Registry.Users,
            Registry.CurrentConfig

        };
        do
        {
            int i = 1;
            Console.WriteLine("Оберіть розділ системного реєстру.");
            foreach (RegistryKey key in regs)
            {
                Console.WriteLine($"{i++}. {key.Name}");
            }
            Console.WriteLine("0. Вихід");
            Console.Write("> ");
            selectItem = Convert.ToInt32(Console.ReadLine()[0]) - 48;
            if (selectItem > 0 && selectItem < regs.Length)

            {
                PrintRegsKeys(regs[selectItem - 1]);
            }
        } while (selectItem != 0);
        #endregion
    }
}
