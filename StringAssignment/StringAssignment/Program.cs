using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenates three strings.
            Console.WriteLine("Enter 1 word");
            string con = Console.ReadLine();
            Console.WriteLine("Enter 1 word");
            string cat = Console.ReadLine();
            Console.WriteLine("Enter 1 word");
            string enate = Console.ReadLine();
            string concatenate = con + cat + enate;
            Console.WriteLine(concatenate + " = All 3 letters added together.");

            Console.ReadLine();

            // Converts a string to uppercase.
            concatenate = concatenate.ToUpper();
            Console.WriteLine(concatenate);

            Console.ReadLine();

            // Stringbuilder builds a paragraph of text, one sentence at a time
            StringBuilder builder = new StringBuilder();

            builder.Append("How had she been so wrong? ");
            builder.Append("All her instincts and intuition completely failed her for the first time in her life. ");
            builder.Append("She had so heavily relied on both when making decisions up until this moment and she felt a seismic shift take place in her self-confidence.");
            builder.Append("She wasn't sure what she should do next.");

            // Converts StringBuilder to a string
            string result = builder.ToString();

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
