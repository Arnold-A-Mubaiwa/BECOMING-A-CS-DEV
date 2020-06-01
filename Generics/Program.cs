using System;

namespace Generics
{
    class GenericClass<T>{
       public GenericClass(T msg){
           Console.WriteLine(msg);
        }
        public void getName<X>(X name){
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           GenericClass<int> c = new GenericClass<int>(24);
           GenericClass<string> c2 = new GenericClass<string>("Arnold");
           GenericClass<bool> c3 =new GenericClass<bool>(true);
           c3.getName("Arnold");
           c2.getName(true);
           c.getName(1);
        }
    }
}
