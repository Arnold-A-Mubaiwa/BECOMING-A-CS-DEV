using System;
using System.Threading;

namespace ThreadNaming
{
    class MyThread{
        public static void Thread1(){
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));       
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1)); 
            Thread t3 = new Thread(new ThreadStart(MyThread.Thread1));           
            t1.Name= "Player1";
             t2.Name= "Player2";
              t3.Name= "Player3";

            t1.Start();
            t2.Start();
            t3.Start();
         }
    }
}
