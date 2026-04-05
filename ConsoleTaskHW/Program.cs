namespace TaskSP_2;
class Program
{
    static List<int> numbers = new List<int>();
    static ManualResetEvent mre = new ManualResetEvent(false);

    static void Main()
    {
        Console.WriteLine("Starting number generation and calculations...");
        Thread generator = new Thread(Generate);
        Thread t1 = new Thread(FindMax);
        Thread t2 = new Thread(FindMin);
        Thread t3 = new Thread(FindAvg);

        t1.Start();
        t2.Start();
        t3.Start();

        generator.Start();

        Console.ReadLine();
    }

    static void Generate()
    {
        Random rnd = new Random();

        for (int i = 0; i < 1000; i++)
        {
            numbers.Add(rnd.Next(0, 5000));
        }

        Console.WriteLine("Generation completed.");

        mre.Set();
    }

    static void FindMax()
    {
        mre.WaitOne();

        int max = numbers.Max();

        Console.WriteLine($"Max: {max}");
    }

    static void FindMin()
    {
        mre.WaitOne();

        int min = numbers.Min();

        Console.WriteLine($"Min: {min}");
    }

    static void FindAvg()
    {
        mre.WaitOne();

        double avg = numbers.Average();

        Console.WriteLine($"Avg: {avg}");
    }
}