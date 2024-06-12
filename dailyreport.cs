using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction headers
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");
            // printing "What is your name?"
            Console.WriteLine("A. What is your name?");
            // The input is saved as yourName
            string yourName = Console.ReadLine();
            Console.WriteLine("B. What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("C. What page number?");
            // Console.ReadLine(); is not an int. String value will be converted.
            string pageNum = Console.ReadLine();
            // converted string value to int
            int pageint = Convert.ToInt32(pageNum);
            Console.WriteLine("D. Do you need help with anything? Please answer \"true\" or \"false.\"");
            // Converting string input to bool
            string courseAns = Console.ReadLine();
            bool courseAnswer = Convert.ToBoolean(courseAns);
            Console.WriteLine("E. Were there any positive experiences you’d like to share? Please give specifics.");
            string specificAnswer = Console.ReadLine();
            Console.WriteLine("F. Is there any other feedback you'd like to provide? Please be specific.");
            string feedbackAns = Console.ReadLine();
            Console.WriteLine("G. How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            // Console will remain open until user closes window.
            Console.ReadLine();
        }
    }
}
