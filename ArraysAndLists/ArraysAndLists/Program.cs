using System;
using System.Collections.Generic;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // Created a string array with pizza toppings
            string[] pizzaToppings = { "Pepperoni", "Cheese", "Olives", "Sausage", "Peanut Butter?" };

            Console.WriteLine("I have prepared a pizza topping list");
            Console.WriteLine("Please enter a number from 0-4");
            int pizzaNum = Convert.ToInt32(Console.ReadLine());

            // If input is greater than 4 the user will be asked to enter in a number from 0-4
            if (pizzaNum <= 4)
            {
                // Passing input value to array 
                Console.WriteLine("The topping you chose is " + pizzaToppings[pizzaNum]);
            }
            else
            {
                // This will let user know input was not in range of index.
                Console.WriteLine(pizzaNum + " index does not exist.");
            }

            //// Created an array of integers
            int[] numbers = { 15, 12, 65, 76, 42, 53 };
            Console.WriteLine("Please enter a number from 0-5 to pick from an array");
            //// Converting input string to int variable
            int numberGuess = Convert.ToInt32(Console.ReadLine());

            if (numberGuess <= 5)
            {
                Console.WriteLine("The number in the array you chose... " + numbers[numberGuess]);
            }
            else
            {
                Console.WriteLine(numberGuess + " index does not exist.");
            }

            // Created a list of strings
            List<string> listOfStrings = new List<string>();
            // Adding new items to the list
            listOfStrings.Add("Person");
            listOfStrings.Add("Place");
            listOfStrings.Add("Thing");
            listOfStrings.Add("Animal");

            Console.WriteLine("Please select a number from 0-3 and the contents at the index chosen will be displayed.");
            int listNumber = Convert.ToInt32(Console.ReadLine());

            // if input it less than or equal to 3 it will display one of the contents of the string
            if (listNumber <= 3) 
            {
                Console.WriteLine("The contents at the index chosen are... " + listOfStrings[listNumber]);
            }
            else
            {
                Console.WriteLine(listNumber + " index does not exist.");
            }


            Console.ReadLine();

        }
    }
}