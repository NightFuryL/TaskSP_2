using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace TaskSP_2
{
    public class Counter
    {
        public static int counter = 0;
        public static object counterLock = new object();
    }

    public class Program
    {
        static Mutex mutex = new Mutex(false, "MyMutex");
        //private static Mutex m = Mutex.OpenExisting("MyMutex");
        private static Semaphore semaphore = new Semaphore(1, 1, "MySemaphore");
        private static ManualResetEvent mre = new ManualResetEvent(false);
        private static AutoResetEvent are = new AutoResetEvent(true);
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() =>
                {
                    for (int j = 0; j < 100_000; j++)
                    {

                        are.WaitOne();
                        Counter.counter++;
                        are.Set();
                        /*
                        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is waiting...");
                        //semaphore.WaitOne();
                        mre.WaitOne();

                        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} enters critical section");
                        Thread.Sleep( 1000 );

                        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} exits critical section");
                        //semaphore.Release();*/
                        #region Methods to ensure thread safety
                        /*
                        // Способ 1: Использование Mutex
                        mutex.WaitOne();
                        Counter.counter++;
                        mutex.ReleaseMutex();
                        */
                        /*
                        // Способ 2: Использование оператора lock
                        lock(Counter.counterLock)
                        {
                             Counter.counter++;
                        }
                        */
                        /*
                        // Способ 3: Использование Monitor
                        Monitor.Enter(Counter.counterLock);
                        Counter.counter++;
                        Monitor.Exit(Counter.counterLock);
                        */
                        #endregion


                    }
                });
                threads[i].Start();
            }
            //Console.WriteLine("Press any key to release the threads...");
            //Console.ReadKey();
            //mre.Set();
            for (int i = 0; i < threads.Length; ++i)
            {
                threads[i].Join();
            }

            Console.WriteLine(Counter.counter);
        }
    }
}