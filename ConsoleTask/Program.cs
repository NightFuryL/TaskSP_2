using TaskLibrary.Service;

namespace ConsoleTask;
public class Program
{
    static void Main(string[] args)
    {
        //Додав Затримку за допомогою статичного методу Sleep класу Thread,
        //подивився в інтернеті, бо не знав як зробити затримку
        //1
        Imports.MessageBox(0, "Лев", "Info", 0);
        Thread.Sleep(333);
        Imports.MessageBox(0, "Одеса", "Info", 0);
        Thread.Sleep(333);
        Imports.MessageBox(0, "Гра престолів", "Info", 0);
        Thread.Sleep(333);
        Imports.MessageBox(0, "C#", "Info", 0);
        Thread.Sleep(333);
        //2
        Imports.Beep(500, 300);
        Thread.Sleep(333);
        Imports.Beep(1000, 300);
        Thread.Sleep(333);
        Imports.Beep(1500, 300);
        Thread.Sleep(333);
        Imports.MessageBeep(1);
        Thread.Sleep(333);
        Imports.MessageBeep(2);
        Thread.Sleep(333);
        Imports.MessageBeep(3);

    }
}
