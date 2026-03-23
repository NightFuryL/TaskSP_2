using System.Runtime.InteropServices;

namespace TaskLibrary.Service;

public static class Imports
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = false)]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    [DllImport("kernel32.dll")]
    public static extern bool Beep(uint dwFreq, uint dwDuration);

    [DllImport("user32.dll")]
    public static extern bool MessageBeep(uint type);
}
