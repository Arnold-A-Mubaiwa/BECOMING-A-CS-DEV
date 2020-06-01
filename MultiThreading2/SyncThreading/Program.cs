using System;
using System.Threading;
namespace SyncThreading
{
    class MyThread
    {
        public void Thread1()
        {
            lock (this)
            {
                Thread.Sleep(200);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
