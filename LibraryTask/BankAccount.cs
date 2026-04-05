namespace LibraryTask;

public class BankAccount
{
    private int balance;
    private object bankAccountLocker = new object();

    public BankAccount(int startBalance)
    {
        balance = startBalance;
    }

    public void Deposit(int amount)
    {
        lock (bankAccountLocker)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}, balance: {balance}");
        }
    }

    public void Withdraw(int amount)
    {
        lock (bankAccountLocker)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}, balance: {balance}");
            }
        }
    }
}