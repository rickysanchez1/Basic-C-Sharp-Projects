using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            // If user fails to enter values inside the array of DaysOfTheWeek then catch
            try
            {
                // Ask user for current day
                Console.WriteLine("Please enter the current day of the week");
                // Cast input value to the enum type using cast operator.
                DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());

                // Print to console currentDay value
                Console.WriteLine("Today is... " + currentDay);

                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
                // Throw is used to signal an occurence of an exception
                throw;
            }
        }
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }        
}
