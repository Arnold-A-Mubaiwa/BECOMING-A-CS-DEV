using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a file stream
            FileStream f = new FileStream("text.txt", FileMode.OpenOrCreate);
            Console.WriteLine("text.txt Open");
            f.WriteByte(65); //writing byte into stream
            f.Close(); //closing file
            Console.WriteLine("text.txt Closed");

            // Multiple Bytes
            FileStream f2 = new FileStream("multiBytes.txt", FileMode.OpenOrCreate);
            Console.WriteLine("multiBytes.txt Open");
            for (int i = 65; i <= 90; i++)
            {
                byte a = (byte)i;
                f2.WriteByte(a);
            }
            f2.Close(); //if you don't close it doesnt desplay data
            Console.WriteLine("multiBytes.txt Closed");

            //Reading Bytes from file
            FileStream f3 = new FileStream("multiBytes.txt", FileMode.OpenOrCreate);
            int b = 0;
            while ((b = f3.ReadByte()) != -1) //giving b the value of the byte then check if its not null
            {
                Console.Write((char)b);
            }
            Console.WriteLine();
            f.Close();

            //Stream Write
            FileStream f4 = new FileStream("written.txt", FileMode.Create);
            StreamWriter sWrite = new StreamWriter(f4); //creating a streamwriter and passing the file(f4) value
            sWrite.WriteLine("Age 24");
            sWrite.Close();
            f4.Close();
            Console.WriteLine("File f4 created successfully...");

            //Reading from file single line
            FileStream f5 = new FileStream("text.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f5);
            string line = sr.ReadLine();
            Console.WriteLine(line);
            sr.Close();
            f5.Close();

            //Reading from multiline
            FileStream f6 = new FileStream("text.txt", FileMode.OpenOrCreate);
            StreamReader sr2 = new StreamReader(f6);

            string c = "";
            while ((c = sr2.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr2.Close();
            f6.Close();

            // Writting multiple lines using TextWriter
            using (TextWriter f7 = File.CreateText("textwritter.txt"))
            {
                f7.WriteLine("Hi there");
                f7.WriteLine("My name is Arnold");
            }
            Console.WriteLine("Data written successfully...");

            //Reading form textWriter
            using (TextReader read = File.OpenText("textwritter.txt"))
            {
                Console.WriteLine(read.ReadLine()); //reading one line
                Console.WriteLine(read.ReadToEnd()); //reading all lines
            }

            using (BinaryWriter bWriter = new BinaryWriter(File.Open("binaryfile.dat", FileMode.Create)))
            {
                bWriter.Write(2.95);
                bWriter.Write("Arnold");
                bWriter.Write(true);
            }
            Console.WriteLine("Data written successfully...");

            using (BinaryReader bReader = new BinaryReader(File.Open("binaryfile.dat", FileMode.Open)))
            {
                try
                {
                    Console.WriteLine("Double Value : " + bReader.ReadDouble());
                    Console.WriteLine("String Value : " + bReader.ReadString());
                    Console.WriteLine("Boolean Value : " + bReader.ReadBoolean());
                }
                catch (Exception)
                {
                    Console.WriteLine("File can't be read");
                }
            }
            Console.ReadKey();

            //String Writer

            string texts = "Hello welcome to my private repository. \nHow you got in I don't know \nAnyways Thanks";
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            sw.WriteLine(texts);
            sw.Flush();
            sw.Close();

            ///reading from file!! using Peek method
            StringReader sreader = new StringReader(sb.ToString());
            while (sreader.Peek() > -1)
            {
                Console.WriteLine(sreader.ReadLine());
            }
        }
    }
}