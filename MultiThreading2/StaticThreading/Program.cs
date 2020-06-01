using System;
using System.Threading;

namespace StaticThreading
{
    public class MyThreads{
        public static void Thread1(){
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MyThreads.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThreads.Thread1));

            t1.Start();
            t2.Start();
        }
    }
}
