using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get type
            var a = 10;
            Type type = a.GetType();
            Console.WriteLine(type);
            Console.ReadKey();
            Console.WriteLine();

            //Get Assembly
            Type str = typeof(System.String);
            Console.WriteLine(str.Assembly);
            Console.WriteLine(str.FullName);
            Console.WriteLine(str.BaseType);
            Console.WriteLine(str.IsClass);
            Console.WriteLine(str.IsEnum);
            Console.WriteLine(str.IsInterface);
            Console.ReadKey();
            Console.WriteLine();
            //Print Constructors
            Console.WriteLine("Method of {0} type", str);
            MethodInfo[] ci = str.GetMethods(BindingFlags.Public|BindingFlags.Instance);
             
            foreach (MethodInfo item in ci)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine();
            
            //Print Fields
            Console.WriteLine("Fields of {0} type",str);
            FieldInfo[] fi = str.GetFields(BindingFlags.Public| BindingFlags.Static|BindingFlags.NonPublic);

            foreach(FieldInfo item in fi){
                Console.WriteLine(item);
            }
        }
    }
}
