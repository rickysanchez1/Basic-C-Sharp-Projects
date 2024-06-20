using System;


namespace BooleanLogicSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            // Assigning input a variable and then converting to int
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a D.U.I?");
            string duiAnswer = Console.ReadLine();
            // Converting string answer to boolean
            bool duiAns = Convert.ToBoolean(duiAnswer);
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketAnswer = Console.ReadLine();
            int ticketAns = Convert.ToInt32(ticketAnswer);
            // Customer has to be over 15 years AND must not have any DUIs and no more than 3 speeding tickets.
            bool results = (age1 > 15 && (duiAns == false && ticketAns < 4));
            Console.WriteLine("Approval: " + results);
            Console.ReadLine();

        }
    }
}
