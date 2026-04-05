using LibraryTask;
//Envrionment.NewLine це символ нового рядка, він більш універсальний, ніж \n та забезпечує правильне форматування тексту незалежно від проєкту

namespace WinFormsTask;

public partial class Form1 : Form
{
    private BankAccount account = new BankAccount(1000);
    private object locker = new object();
    private Semaphore semaphore = new Semaphore(3, 3);

    public Form1()
    {
        InitializeComponent();
    }

    private void buttonStart_Click(object sender, EventArgs e)
    {
        txtBoxLog.Clear();

        StartBank();
        StartThreads();
    }

    private void StartBank()
    {
        //Перше завдання за допомогою інтерфейсу вайнформс
        for (int i = 0; i < 5; i++)
        {
            Thread t = new Thread(() =>
            {
                Random rnd = new Random();

                for (int j = 0; j < 5; j++)
                {
                    int money = rnd.Next(1, 200);

                    if (rnd.Next(2) == 0)
                    {
                        account.Deposit(money);
                        LogToTXTBox($"Deposited {money}");
                    }
                    else
                    {
                        account.Withdraw(money);
                        LogToTXTBox($"Withdrew {money}");
                    }

                    Thread.Sleep(200);
                }
            });

            t.Start();
        }
    }

    private void StartThreads()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread t = new Thread(DoSomething);
            t.Start();
        }
    }
    //Друге завдання за допомогою інтерфейсу вайнформс
    private void DoSomething()
    {
        semaphore.WaitOne();

        int id = Thread.CurrentThread.ManagedThreadId;

        LogToTXTBox($"Thread {id} started");

        Random rnd = new Random();

        for (int i = 0; i < 5; i++)
        {
            LogToTXTBox($"Thread {id}: {rnd.Next(1, 100)}");
            Thread.Sleep(300);
        }

        LogToTXTBox($"Thread {id} finished");
        semaphore.Release();
    }
    //Безпечний спосіб оновлення UI в WinForms з інших потоків (трохи подивився в інтернеті)
    private void LogToTXTBox(string text)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<string>(LogToTXTBox), text);
        }
        else
        {
            txtBoxLog.AppendText(text + Environment.NewLine);
        }
    }
}