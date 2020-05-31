using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
           SortedList<string,string> names = new SortedList<string, string>();
           names.Add("Arnold","Mubaiwa");
           names.Add("Samuel","Zagabe");
           names.Add("John","Tamire");
           names.Add("Samartha","Gutsa");
           names.Add("Peace","Humbani");

           foreach(KeyValuePair<string,string> name in names){
               Console.WriteLine("Name :"+name.Key+" \t Surname :"+name.Value);
           }
        }
    }
}
