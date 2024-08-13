using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displaying current date and time
            DateTime currentDate = DateTime.Now;
            // Converting currentDate to string and printing to console
            Console.WriteLine(currentDate.ToString("MM/dd/yyyy hh:mm"));
            //string timediff = currentDate.ToString("MM/dd/yyyy hh:mm:ss");
            // Asking user for number
            Console.WriteLine("Please enter a number.");
            // Converting userInput into an int
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Adding X hours to currentDate
            DateTime hourDifference = DateTime.Now.AddHours(userInput);

            // Print current time + userInput
            Console.WriteLine(hourDifference);

            Console.ReadLine();
        }
    }
}
