using System;

namespace Anonymus
{
    class Program
    {
        delegate int Square(int x);
        public delegate void AnonymusFun();
        static void Main(string[] args)
        {
            // Lambda expression
            Square getSquare = x => x * x;
            int i = getSquare(5);
            Console.WriteLine("Square :{0}", i);

            // Anonymus Method
            AnonymusFun fun = delegate(){
                Console.WriteLine("Anonymus Function......");
            };
            fun();
        }
    }
}
