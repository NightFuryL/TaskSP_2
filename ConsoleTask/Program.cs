using LibraryTask;
namespace TaskSP_2;
public class Program
{
    private static Semaphore semaphore = new Semaphore(3, 3);
    private static void Main()
    {
        //Exercise 1
        Console.WriteLine("Exercise 1 with console interface");
        BankAccount account = new BankAccount(1000);

        for (int i = 0; i < 5; i++)
        {
            Thread t = new Thread(() =>
            {
                Random rnd = new Random();

                for (int j = 0; j < 5; j++)
                {
                    int money = rnd.Next(1, 200);

                    if (rnd.Next(2) == 0)
                        account.Deposit(money);
                    else
                        account.Withdraw(money);

                    Thread.Sleep(200);
                }
            });

            t.Start();
        }
        Console.ReadLine();
        //Exercise 2
        Console.WriteLine("Exercise 2 with console interface");
        for (int i = 0; i < 10; i++)
        {
            Thread t = new Thread(DoSomething);
            t.Start();
        }

        Console.ReadLine();
    }
    static void DoSomething()
    {
        semaphore.WaitOne();

        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started");

        Random rnd = new Random();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {rnd.Next(1, 100)}");
            Thread.Sleep(300);
        }

        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} finished");
        semaphore.Release();
    }
}