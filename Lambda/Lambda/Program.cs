using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)

        {
            // Create a list with 2 employees with the first name Joe
            List<Employee> employees = new List<Employee>();
            // Added 10 employees to the list

            employees.Add(new Employee
            {
                ID = 1,
                FirstName = "Joe",
                LastName = "Doe",
            });

            employees.Add(new Employee
            {
                ID = 1,
                FirstName = "Joe",
                LastName = "Doe",
            });
            employees.Add(new Employee
            {
                ID = 2,
                FirstName = "Seven",
                LastName = "Smith",
            });
            employees.Add(new Employee
            {
                ID = 3,
                FirstName = "Kris",
                LastName = "Kristoferson",
            });
            employees.Add(new Employee
            {
                ID = 4,
                FirstName = "Olivia",
                LastName = "Sweets",
            });
            employees.Add(new Employee
            {
                ID = 5,
                FirstName = "Jacob",
                LastName = "Ladder",
            });
            employees.Add(new Employee
            {
                ID = 6,
                FirstName = "Fiona",
                LastName = "Apple",
            });
            employees.Add(new Employee
            {
                ID = 7,
                FirstName = "Charlie",
                LastName = "Bucket",
            });

            // Loop through each employee in employees
            foreach (var employee in employees)
            {
                // create a new list to store employees with the FirstName "Joe"
                List<Employee> employeeDupe = new List<Employee>();
                // if the employee in the current iteration matches FirstName "Joe", add to the new list employeedupe
                if (employee.FirstName == "Joe")
                {
                    employeeDupe.Add(employee);
                }
                // Printing each item in the employeeDupe list to double check.
                foreach (var dupe in employeeDupe)
                {
                    Console.WriteLine(dupe.FirstName + " added to new list");
                }
             }

         
            // Created a lambda expression to add names names to new list if FirstName "Joe"
            List<Employee> joeList = employees.Where(x => x.FirstName == "Joe").ToList();

            // Created a lambda expression to add names where ID is greater than 5
            List<Employee> fiveGreater = employees.Where(x => x.ID > 5).ToList();
            // Double checking joeList
            Employee emp = joeList[0];
            Console.WriteLine(emp.FirstName);

            Console.ReadLine();
        }
    }
}

