using System;
using System.IO;
using System.Text;

namespace FileStream2
{
    class Program
    {
        static void Main(string[] args)
        {
            // /craetingg file
            FileInfo fi = new FileInfo("fileinfo.txt");
            // fi.Create();
            // Console.WriteLine("File created successfully");

            // writing to file
            StreamWriter sw = fi.AppendText();
            sw.WriteLine("This is something new");
            sw.Close();

            //reading from file
            StreamReader sr = fi.OpenText();
            string text = "";

            while ((text=sr.ReadLine())!=null)
            {
                Console.WriteLine(text);
            }

            DirectoryInfo di = new DirectoryInfo(@"CSharp");
            if(di.Exists){
                Console.WriteLine("Directory exists");
                Console.ReadKey();
            }else
            {
                di.Create();
                Console.WriteLine("Directory Created");
                Console.ReadKey();
            }

            di.Delete();
            Console.WriteLine("Directory Deleted");
        }
    }
}
