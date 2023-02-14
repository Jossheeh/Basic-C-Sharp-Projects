using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {

            var employees = new List<Employee>
        {
            new Employee { FirstName = "Joe", LastName = "Smith", Id = 1 },
            new Employee { FirstName = "John", LastName = "Doe", Id = 2 },
            new Employee { FirstName = "Jane", LastName = "Doe", Id = 3 },
            new Employee { FirstName = "Mary", LastName = "Johnson", Id = 4 },
            new Employee { FirstName = "Joe", LastName = "Jackson", Id = 5 },
            new Employee { FirstName = "Mike", LastName = "Williams", Id = 6 },
            new Employee { FirstName = "Bob", LastName = "Johnson", Id = 7 },
            new Employee { FirstName = "Samantha", LastName = "Jones", Id = 8 },
            new Employee { FirstName = "Joseph", LastName = "Brown", Id = 9 },
            new Employee { FirstName = "Joe", LastName = "Adams", Id = 10 }
        };

            var joes = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            Console.WriteLine("Employees with first name Joe using foreach loop:");
            foreach (var joe in joes)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} ({joe.Id})");
            }

         
            var joes2 = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("Employees with first name Joe using lambda expression:");
            foreach (var joe in joes2)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} ({joe.Id})");
            }

            
            var idsGreaterThan5 = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("Employees with Id greater than 5:");
            foreach (var employee in idsGreaterThan5)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} ({employee.Id})");
            }
            Console.ReadLine();
        }

    }
            
}