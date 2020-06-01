using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSleep
{
    class MyThread{
        public void Thread1(){
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(400);
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
            t1.Start();
            t2.Start();

            //Aborting from the thread
            try{
                t1.Abort();
                t2.Abort();
            }catch(ThreadAbortException tab){
                Console.WriteLine(tab.ToString());
            }
            Console.WriteLine("End of Thread");
        }
    }
}
