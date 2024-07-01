using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // one-dimensional array of strings.
            string[] strings = { "Person", "Book", "Television" };
            // Ask the user to input some text.
            Console.WriteLine("Please enter text and it will be appended to strings list..");
            // Created string from users input
            string userInput = Console.ReadLine();
            // Loop that will iterate through each string in array and appends users input to strings array
            for (int i = 0; i < strings.Length; i++)
            {
                // created variable for strings in array and added users input
                string result = strings[i] + userInput;
            }
            // loop that will iterate through each string in array
            for (int i = 0; i < strings.Length; i++)
            {
                string result = strings[i] + " " + userInput;
                // prints off each string in the array one at a time.
                Console.WriteLine(result);
            }

            int j = 0;
            // An infinite loop
            for (; j < 2; j++) // Added var j and condition to end inifinite loop
            {
                Console.WriteLine("This will iterate 2 times.");
            }

            // Loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            // Run expression and add 1 value to k until value returns false.
            for (int k = 5; k < 10; k++)
            {
                // Console.write the amount of times it takes to return false. 
                Console.WriteLine("k variable is less than 10 this many times");
            }
            // loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator
            for (int a = 2; a <= 5; a++ )
            {
                Console.WriteLine("Variable a's value is less than or equal to 5 this many times.");
            }

            // A list of strings where each item in the list is unique.
            List<string> names = new List<string> { "car", "john", "book", "tree", "apple" };
            // Ask the user to input text to search for in the list.
            Console.WriteLine("Input a name and it will search through a list created.");
            string name = Console.ReadLine();
            // Converted string input to lowercase to avoid errors.
            string lowername = name.ToLower();

            // loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            for (int i = 0; i < names.Count; i++)
            {
                // created a var string for each time code will iterate
                string userGuess = names[i];
                // Created variable to display index for user input if found in list.
                int index = names.IndexOf(lowername);
                // If input matches an item on the list it will execute code below.
                if (lowername.Contains(userGuess))
                {
                    Console.WriteLine(lowername + "! A match has been found.");
                    Console.WriteLine("Index found at: " + index);
                    break;
                }
                // If input does not match, it will execute code below.
                else
                {
                    Console.WriteLine("Invalid! Input is not on the list");
                }
                
                // prints off each string in the array one at a time.
                Console.WriteLine(userGuess);
            }

            // list of strings that has at least two identical strings in the list.
            List<string> identicalStrings = new List<string> { "strings", "nickel", "person", "vehicle", "jargon", "strings" };

            // Ask the user to select text to search for in the list.
            Console.WriteLine("Please select text to search for in a list.");
            string userSearch = Console.ReadLine();
            string userLower = userSearch.ToLower();

            // A loop that iterates through the list and then displays the indices of the items matching the user-selected text
            for (int i = 0; i < identicalStrings.Count; i++)
            {
                if (identicalStrings[i] == userLower)
                {
                    int indices = 0;
                    foreach (string item in identicalStrings)
                    {
                        Console.WriteLine(item);
                        //Console.WriteLine(userLower + "! Match found.");
                        //Console.WriteLine("Index located at: " + indices);
                        indices++;
                    }
                    //int index = identicalStrings.IndexOf(userLower);
                    //Console.WriteLine(userLower + "! Match found.");
                    //Console.WriteLine("Index located at: " + index);
                }
                else
                {
                    Console.WriteLine("No match found.");
                }
            }
            
           

            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //}




            Console.ReadLine();

        }

    }
}
