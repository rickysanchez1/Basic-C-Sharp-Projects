using System;


namespace consoleappassignemtn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's take some input from you and do some math.");
            Console.WriteLine("1. Please enter a number");
            string multFive = Console.ReadLine();
            // Received the input as a string and placed it in a variable
            int mult5 = Convert.ToInt32(multFive);
            // Converted variable to an int
            int total5 = mult5 * 50;
            // created a variable to multiply the input by 50
            Console.WriteLine("Your number multiplied by 50 is " + total5);
            Console.WriteLine("2. Enter another number.");
            string addtwentyfive = Console.ReadLine();
            int add25 = Convert.ToInt32(addtwentyfive);
            int total25 = add25 + 25;
            Console.WriteLine("Your number plus 25 is " + total25);
            Console.WriteLine("3. Enter another number.");
            string divtwelve = Console.ReadLine();
            // Converted the string into a double data type to store a large fractional number
            double divide12 = Convert.ToDouble(divtwelve);
            double total12 = divide12 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + total12);
            Console.WriteLine("4. Enter another number.");
            string boolfifty = Console.ReadLine();
            // Converted string into int to test against bool
            int bool50 = Convert.ToInt32(boolfifty);
            // Ran input to check if its greater than 50
            bool bool50great = bool50 > 50;
            Console.WriteLine("Is your number greater than 50? " + bool50great);
            Console.WriteLine("5. Enter another number.");
            string moduseven = Console.ReadLine();
            double modu7 = Convert.ToDouble(moduseven);
            // Used modulus operator to check for remainder.
            double modu = 7 % modu7;
            Console.WriteLine("Your number divided by 7 will show a remainder, if any. " + modu);
            Console.ReadLine();
        }
    }
}
