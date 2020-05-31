using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializatioAndDeserialization
{
    [Serializable]
    class Student
    {
        public int rollnu;
        public string name;
        public Student(int rollnu, string name)
        {
            this.name = name;
            this.rollnu = rollnu;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("Serial.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();

            Student s = new Student(121589, "Arnold");
            bf.Serialize(fs, s);
            fs.Close();
            Console.WriteLine("File Serialized");
            Console.ReadKey();

            FileStream fs2 = new FileStream("Serial.txt", FileMode.OpenOrCreate);
            s = (Student)bf.Deserialize(fs2);
            Console.WriteLine("Rollno: " + s.rollnu);
            Console.WriteLine("Name: " + s.name);

            fs2.Close();
        }
    }
}
