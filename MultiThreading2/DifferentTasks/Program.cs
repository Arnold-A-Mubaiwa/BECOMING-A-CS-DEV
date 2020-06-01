using System;
using System.Threading;

namespace DifferentTasks
{
    class MyThreads{
        public static void Thread1(){
            Console.WriteLine("Task One");
        }
        public static void Thread2(){
            Console.WriteLine("Task Two");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Thread t1 = new Thread(new ThreadStart(MyThreads.Thread1));
           Thread t2 = new Thread(new ThreadStart(MyThreads.Thread2));
           t1.Start();
           t2.Start();
        }
    }
}
