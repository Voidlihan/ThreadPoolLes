using System;
using System.Threading;

namespace ThreadPoolLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.GetAvailableThreads(out int threads, out int ports);
            Console.WriteLine(threads);
            //for(int i = 0; i < 20; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(ProcessNumbers);

            //}
            //Console.ReadLine();
            Timer timer = new Timer(ProcessNumbers, null, TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(5));
            Console.ReadLine();
        }
        static void ProcessNumbers(object state)
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToLongDateString());
            //var currentThread = Thread.CurrentThread;
            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"[{currentThread.ManagedThreadId}] - {i}");
            //    Thread.Sleep(200);
            //}
            //Console.WriteLine($"[{currentThread.ManagedThreadId}] - Done");
        }
    }
}
