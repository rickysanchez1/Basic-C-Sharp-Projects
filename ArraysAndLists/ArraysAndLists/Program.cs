using System;
using System.Collections.Generic;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // Created a string array with pizza toppings
            //string[] pizzaToppings = { "Pepperoni", "Cheese", "Olives", "Sausage", "Peanut Butter?" };

            //Console.WriteLine("I have prepared a pizza topping list");
            //Console.WriteLine("Please enter a number from 0-4");
            //int pizzaNum = Convert.ToInt32(Console.ReadLine());

            //// If input is greater than 4 the user will be asked to enter in a number from 0-4
            //if (pizzaNum <= 4)
            //{
            //    // Passing input value to array 
            //    Console.WriteLine("The topping you chose is " + pizzaToppings[pizzaNum]);
            //}
            //else
            //{
            //    // This will let user know input was not in range of index.
            //    Console.WriteLine(pizzaNum + " index does not exist.");
            //}

            //// Created an array of integers
            //int[] numbers = { 15, 12, 65, 76, 42, 53 };
            //Console.WriteLine("Please enter a number from 0-5 to pick from an array");
            //// Converting input string to int variable
            //int numberGuess = Convert.ToInt32(Console.ReadLine());

            //if (numberGuess <= 5)
            //{
            //    Console.WriteLine("The number in the array you chose... " + numbers[numberGuess]);
            //}
            //else
            //{
            //    Console.WriteLine(numberGuess + " index does not exist.");
            //}

            // Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.

            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Person");
            listOfStrings.Add("Place");
            listOfStrings.Add("Thing");

            foreach (string item in listOfStrings)
            {
                Console.WriteLine(item);
            }            


            }

        }
    }
}