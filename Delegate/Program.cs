using System;

namespace Delegate
{
    delegate int Calculator(int n);//Declaring delegate

    class Program
    {
        static int number = 100;
        public static int add(int n){
            number = number + n;
            return number;
        } 
        public static int mul(int n){
            number = number * n;
            return number;
        }
        public static int getNumber(){
            return number;
        }
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(add);
            Calculator c2 = new Calculator(mul);
            c1(45);
            Console.WriteLine(" "+ getNumber());
            c2(5);
            Console.WriteLine(" "+ getNumber());
        }
    }
}
