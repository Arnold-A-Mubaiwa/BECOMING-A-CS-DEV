using System;
using System.Collections.Generic;

namespace Dictinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary<key,value>
            Dictionary<int,string> names = new Dictionary<int, string>();
            names.Add(1,"Arnold");
            names.Add(2,"Anotida");
            names.Add(3,"Mubaiwa");
            names.Add(4,"Chingwara");

            foreach(KeyValuePair<int,string> kv in names){
                Console.WriteLine(kv.Key +" "+ kv.Value);
            }
        }
    }
}
