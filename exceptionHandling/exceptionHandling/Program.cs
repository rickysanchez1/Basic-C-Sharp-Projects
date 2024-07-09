using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // list of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            // Ask the user for a number to divide each number in the list by.
            Console.WriteLine("Please enter a number and I will divide it by each number on the list.");
            
            // try catch loop to handle exceptions
            try
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                // a loop that divides each integer in the list by the number the user entered.
                for (int i = 0; i < numbers.Count; i++)
                {
                    // expression for the userNumber and int in list
                    int userDivide = numbers[i] / userNumber;
                    // Displays the result of userNumber against each int in list
                    Console.WriteLine(numbers[i] + " / " + userNumber + " = " + userDivide);
                }
            }
            catch (FormatException ex)
            {
                // if string was entered, display message
                Console.WriteLine("Please type whole number");
                return;
            }
            // exception handing using dividebyzero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
                return;
            }
           
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();





           

        }
    }
}
