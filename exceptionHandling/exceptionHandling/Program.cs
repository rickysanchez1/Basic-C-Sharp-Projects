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
            int userNumber = Convert.ToInt32(Console.ReadLine());

            try
            {
                // a loop that divides each integer in the list by the number the user entered.
                for (int i = 0; i < numbers.Count; i++)
                {
                    int userDivide = userNumber / numbers[i];
                    Console.WriteLine(userNumber + " / " + numbers[i] + " = " + userDivide);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            // exception using customer 

            // a loop that divides each integer in the list by the number the user entered.



            // displays the result to the screen.

            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Divide the two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " Divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();
            //}
            //// catch (Format exception variable
            //catch (FormatException ex)
            //{
            //    // if exception found execute code
            //    Console.WriteLine("Please type whole number");
            //    return;
            //}
            //// exception handing using dividebyzero
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please do not divide by zero.");
            //}
            //// exception using customer 
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}
            Console.ReadLine();
           
        }
    }
}
