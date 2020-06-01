using System;
using System.Threading;

namespace ThreadJoinn
{
    class MyThread{
        public void Tread1(){
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Tread1));
            Thread t2 = new Thread(new ThreadStart(mt.Tread1));
            Thread t3 = new Thread(new ThreadStart(mt.Tread1));
            Thread t4 = new Thread(new ThreadStart(mt.Tread1));

            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            t4.Start();
        }
    }
}
