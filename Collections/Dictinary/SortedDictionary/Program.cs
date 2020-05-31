using System;
using System.Collections.Generic;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //unique keys
          SortedDictionary<string,string> names= new SortedDictionary<string, string>();
          names.Add("1","Samartha");
          names.Add("3","Mars");
          names.Add("5","Ashley");
          names.Add("9","Anotida");
          names.Add("7","Arnold");

          foreach(KeyValuePair<string,string> kv in names){
              Console.WriteLine(kv.Key+" "+kv.Value);
          }
        }
    }
}
