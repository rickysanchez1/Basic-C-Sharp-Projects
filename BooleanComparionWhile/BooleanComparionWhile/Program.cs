using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparionWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try to guess my favorite day of the week.");
            Console.WriteLine("Please use numbers 1-7 to represent each day. 1 = Monday, 2 = Tuesday, etc.");
            // Input is converted from string to an int
            int favoriteDay = Convert.ToInt32(Console.ReadLine());
            bool goodGuess = favoriteDay == 1;
            switch (favoriteDay)
            // the value of the expression is compared with the value of each case.
            // if there is a match, the associated block of code is executed.
            {
                // if the variable value is case X then execute block
                case 1:
                    Console.WriteLine("Monday! Monday, is my favorite day of the week!");
                    // When the code reaches the break, it will break out of this entire code block.
                    break;
                case 2:
                    Console.WriteLine("Tuesday? Uh Uh Uh, you didn't say the magic word.");
                    break;
                case 3:
                    Console.WriteLine("Wednesday? Uh Uh Uh, you didn't say the magic word.");
                    break;
                case 4:
                    Console.WriteLine("Thursday? Uh Uh Uh, you didn't say the magic word.");
                    break;
                case 5:
                    Console.WriteLine("Friday? Uh Uh Uh, you didn't say the magic word.");
                    break;
                case 6:
                    Console.WriteLine("Saturday? Uh Uh Uh, you didn't say the magic word.");
                    break;
                case 7:
                    Console.WriteLine("Sunday? Uh Uh Uh, you didn't say the magic word.");
                    break;
                default:
                    Console.WriteLine("Please pick a day out of the week.");
                    break;
            }

            Console.WriteLine("Please guess my daughters age from 1-7?");

            int age = Convert.ToInt32(Console.ReadLine());
            // Bool value is used to end program on correct answer case
            bool kidsAge = age == 7;

            do
            {
                switch (age)
                {
                    case 1:
                        Console.WriteLine("1 is not correct.");
                        Console.WriteLine("Please try again");
                        // This will allow the user to try again
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("2 is not correct.");
                        Console.WriteLine("Please try again");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("3? That is correct!.");
                        // Once correct input was passed through to this case the program will end
                        kidsAge = true;
                        break;
                    case 4:
                        Console.WriteLine("It is not 4 either.");
                        Console.WriteLine("Please try again");
                        age = Convert.ToInt32(Console.ReadLine()); 
                        break;
                    case 5:
                        Console.WriteLine("You are getting warmer.");
                        Console.WriteLine("Please try again");
                        age = Convert.ToInt32(Console.ReadLine()); 
                        break;
                    case 6:
                        Console.WriteLine("YOU GOT IT! Is what I would say if it were true.");
                        Console.WriteLine("Please try again");
                        age = Convert.ToInt32(Console.ReadLine()); 
                        break;
                    case 7:
                        Console.WriteLine("7! nope.");
                        Console.WriteLine("Please try again");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Please enter a number 1-7.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!kidsAge);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
