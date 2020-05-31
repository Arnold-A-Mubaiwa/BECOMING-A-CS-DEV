using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string> ();
            names.AddLast("John");
            names.AddLast("Tens");
            names.AddFirst("People");
            names.AddFirst("Arnold");

            foreach(var name in names){
                Console.WriteLine(name);
            }
            Console.ReadKey();
            //inserting list using Find method
            LinkedListNode <string> node=names.Find("People");
            names.AddBefore(node,"Chingwara");
            names.AddAfter(node,"Lives");
            foreach(var name in names){
                Console.WriteLine(name);
            }
        }
    }
}
