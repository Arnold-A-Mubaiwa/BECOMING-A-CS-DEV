using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uses the Last in First Out Method
            Stack <string> names = new Stack <string>();
            //inserting into the stack
            names.Push("Arnold");
            names.Push("Anotida");
            names.Push("Mubaiwa");
            names.Push("Chingwara");

            //Reading from the stack
            foreach(var name in names){
                Console.WriteLine(name);
            }

            //
            Console.WriteLine("Peek value :"+ names.Peek());
            Console.WriteLine("Pop value :"+ names.Pop());
            Console.WriteLine("Peek value :"+ names.Peek());
        }
    }
}
