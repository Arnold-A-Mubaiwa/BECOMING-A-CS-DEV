using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // First in First out
            Queue<string> names = new Queue<string>();
            //To add use Enqueue
            names.Enqueue("Arnold");
            names.Enqueue("Anotida");
            names.Enqueue("Mubaiwa");
            names.Enqueue("Chingwara");

            //Iterate using foreach
            foreach(var name in names){
                Console.WriteLine(name);
            }
          //To delete use "Dequeue"
            Console.WriteLine("Peek value :"+ names.Peek());
            Console.WriteLine("Remove value \"Dequeue\" :"+ names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());  
        }
    }
}
