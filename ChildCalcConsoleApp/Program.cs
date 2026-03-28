namespace ChildCalcConsoleApp;
//Project for exercise 3
internal class Program
{
    static void Main(string[] args)
    {
        // args: 7 3 +

        int a = int.Parse(args[0]);
        int b = int.Parse(args[1]);
        string op = args[2];

        int result = 0;

        if (op == "+") result = a + b;
        if (op == "-") result = a - b;
        if (op == "*") result = a * b;
        if (op == "/") result = a / b;

        Console.WriteLine("Args: " + a + " " + b + " " + op);
        Console.WriteLine("Result: " + result);

        Console.ReadLine();
    }
}