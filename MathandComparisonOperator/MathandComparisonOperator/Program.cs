using System;


namespace MathandComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate.");
            // Created string variable for input
            string hourlyRate = Console.ReadLine();
            // Converting to decimal since we are working with money
            decimal hourly = Convert.ToDecimal(hourlyRate);
            Console.WriteLine("Please enter hours worked per week.");
            string hoursWorked = Console.ReadLine();
            // Converting to decimal to work with hourly and hours per week expression
            decimal hoursWorkedprweek = Convert.ToDecimal(hoursWorked);
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate.");
            string hourlyRate2 = Console.ReadLine();
            decimal hourly2 = Convert.ToDecimal(hourlyRate2);
            Console.WriteLine("Please enter hours worked per week.");
            string hoursWorked2 = Console.ReadLine();
            decimal hoursWorkedprweek2 = Convert.ToDecimal(hoursWorked2);
            decimal salary1 = hourly * hoursWorkedprweek * 52;
            decimal salary2 = hourly2 * hoursWorkedprweek2 * 52;
            Console.WriteLine("Annual salary of Person 1: " + salary1);
            Console.WriteLine("Annual salary of Person 2: " + salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(salary1 > salary2);
            Console.ReadLine();
        }
    }
}
