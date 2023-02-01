using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readText = File.ReadAllLines(@"C:\Users\student\Desktop\new 1.txt");
            foreach (string s in readText)
            {
                Console.WriteLine(s);
                
            }   
        }
    }
}
