using System.Runtime.InteropServices;

namespace LibraryTask;

public class MouseHook
{
    //Івент для передачі координат кліка миші
    public event Action<int, int> OnClick;

    private IntPtr hookId = IntPtr.Zero;
    private LowLevelMouseProc proc;

    public void Start()
    {
        proc = HookCallback;
        hookId = SetHook(proc);
    }

    public void Stop()
    {
        UnhookWindowsHookEx(hookId);
    }

    private IntPtr SetHook(LowLevelMouseProc proc)
    {
        return SetWindowsHookEx(14, proc, IntPtr.Zero, 0);
    }

    private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && wParam == (IntPtr)0x0201)
        {
            //Marshal це ніби міст між керованим і некерованим кодом або між .NET і WinAPI
            //Дуже крутая штука)
            //Цю строку я зробив за допомогою інтернету, бо було трохи складно просто воно не хотіло працювати
            MSLLHOOKSTRUCT p = Marshal.PtrToStructure<MSLLHOOKSTRUCT>(lParam);
            OnClick?.Invoke(p.pt.x, p.pt.y);
            return (IntPtr)1;
        }

        return CallNextHookEx(hookId, nCode, wParam, lParam);
    }
    //Цей делегат потрібен для виклику кліків по всій системі
    private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll")]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll")]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll")]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
    //Звичайна структура для зберігання координат кліка миші
    private struct POINT { public int x; public int y; }
    //Структура для зберігання інформації про клік миші, яку ми отримуємо з WinAPI
    //Також зробив за допомогою інтернету, прсото подивився приклад та переробив під себе
    //Вона є перехідником між WinAPI і моїм кодом, бо в ній є координати кліка
    //та ще багато іншої інформації, яку я не використовую)
    private struct MSLLHOOKSTRUCT
    {
        public POINT pt;
        public int mouseData;
        public int flags;
        public int time;
        public IntPtr dwExtraInfo;
    }
}