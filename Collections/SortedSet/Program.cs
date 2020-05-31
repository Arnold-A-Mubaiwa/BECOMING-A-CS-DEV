using System;
using System.Collections.Generic;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // SortedSet the set in asdn order
            var names = new SortedSet<string>();
            names.Add("Arnold");
            names.Add("Anotida");
            names.Add("Mubaiwa");
            names.Add("Chingwara");
            names.Add("Arnold"); //it will not be added since SortedSet doesnt support duplication

            foreach(var name in names){
                Console.WriteLine(name);   
            }            
        }
    }
}
