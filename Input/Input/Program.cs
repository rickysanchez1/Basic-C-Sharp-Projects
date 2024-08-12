using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            string userInput = number.ToString();
            string fileName = @"C:\Users\sinp3\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\twentyone\log.txt";
            File.WriteAllText(fileName, userInput);
            
            string readAloud = File.ReadAllText(fileName);
           
            Console.WriteLine(readAloud);
            Console.ReadLine();
        }
    }
}
