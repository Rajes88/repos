using System;
using System.IO;

namespace ConsoleAppStreamReader
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("C# StreamReader Project");
            Console.WriteLine("-------------------------");
            //step 1
            FileStream myFileStream = new FileStream("C:/RajeshFile/javanotes.txt", FileMode.Open, FileAccess.Read);

            //step 2
            StreamReader myReader = new StreamReader(myFileStream);
            Console.WriteLine(myReader.ReadToEnd());
            Console.ReadLine();
        }
    }
}
