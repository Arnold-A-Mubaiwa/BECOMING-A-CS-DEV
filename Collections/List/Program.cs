using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // List can contain duplicated arguments
            var terms = new List<int>(){1,2,3,4};
            var names = new List <string> ();
            names.Add("Arnold");
            names.Add("Anotida");
            names.Add("Arnold");

            foreach(var name in names){
                Console.WriteLine(name);
            }
            foreach (var item in terms)
            {
                Console.WriteLine(item);
            }
        }
    }
}
