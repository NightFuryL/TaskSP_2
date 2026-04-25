using System.Runtime.InteropServices;
using System.Text;

namespace LibraryTask;

public class KeyboardHook
{
    public event Action<string> OnKey;

    private IntPtr hookId = IntPtr.Zero;

    private LowLevelKeyboardProc proc;

    public void Start()
    {
        proc = HookCallback;
        hookId = SetHook(proc);
    }

    public void Stop()
    {
        UnhookWindowsHookEx(hookId);
    }

    private IntPtr SetHook(LowLevelKeyboardProc proc)
    {
        return SetWindowsHookEx(13, proc, IntPtr.Zero, 0);
    }

    private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && wParam == (IntPtr)0x0100)
        {
            int vkCode = Marshal.ReadInt32(lParam);
            OnKey?.Invoke(vkCode.ToString());
        }

        return CallNextHookEx(hookId, nCode, wParam, lParam);
    }
    //Цей делегат потрібен для виклику коли натискаеш любу клавішу по всій системі
    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll")]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll")]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll")]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
}