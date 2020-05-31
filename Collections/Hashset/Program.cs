using System;
using System.Collections.Generic;
using System.Text;

namespace Hashset
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hashset only takes unique arguments
            // NB: CamelCase
            var names = new HashSet<string>();
            names.Add("Arnold");
            names.Add("Anotida");
            names.Add("Mubaiwa");
            names.Add("Chingwara");
            names.Add("Mambwai");

            foreach(var name in names){
                Console.WriteLine(name);
            }
        }
    }
}
