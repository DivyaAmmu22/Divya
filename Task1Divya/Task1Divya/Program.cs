using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Divya
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"D:\";
            string Destin = @"E:\";

            File.Copy(source + "testfile.txt", Destin + "testfile.txt");

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
