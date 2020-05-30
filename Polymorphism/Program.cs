using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Polymorphism
{
    // method overloading
   sealed class Adding{//sealing the Adding class o that it cannot be derived
        public static int add(int a, int b){
            return a+b;
        }
        public static int add(int a, int b, int c){
            return a+b+c;
        }
    }
    class Age{
        public static int getAge(int age){
            return age;
        }
        public static string getAge(string age){
            return age;
        }
    }
    // method Overriding
    class Animal{
        public virtual void run(){//alway use the virtual keyword in the base calss
            Console.WriteLine("run...");
        }
    }
    class Cheater: Animal{
        //making cheater a base class for a cat
       public string name= "Cheater";

        public override void run(){
            Console.WriteLine("Fastest Animal...");
        }
    }
    class Cat: Cheater{
        string names = "Cat";
        public void getName(){
             Console.WriteLine(base.name);
              Console.WriteLine(names);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Static methods does't need to be instantiated
            //Method overloading
            Console.WriteLine("Two paras "+ Adding.add(20,10));
            Console.WriteLine("Three paras "+ Adding.add(10,20,70));
            Console.WriteLine("Age in number  : "+ Age.getAge(21));
            Console.WriteLine("Age in a string: "+ Age.getAge("Twenty One"));

            //Method overriding
            Cheater run = new Cheater();
            run.run();

            //base Class
            Cat a = new Cat();
            a.getName();
        }
    }
}
