using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>(new List<string> { "apple", "banana", "cherry" });
            Employee<int> employee2 = new Employee<int>(new List<int> { 1, 2, 3, 4, 5 });

            Console.WriteLine("Employee 1 Things:");
            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("Employee 2 Things:");
            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}