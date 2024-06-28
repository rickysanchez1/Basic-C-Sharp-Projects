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
            Console.WriteLine("Please enter a number 0-4");
            int pizzaNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number chose... " + pizzaToppings[pizzaNum]);


            // Created an array of integers
            int[] numbers = { 15, 12, 65, 76, 42, 53 };
            Console.WriteLine("Please enter a number from 0-5 to pick from an array");
            // Converting input string to int variable
            int numberGuess = Convert.ToInt32(Console.ReadLine());
            // Passing input value to array 
            Console.WriteLine("Your number chose... " + numbers[numberGuess]);

            Console.ReadLine();

        }
    }
}