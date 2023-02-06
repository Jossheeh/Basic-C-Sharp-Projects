using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee();
            Person.FirstName = new List<string>() { "Sample" };
            Person.LastName = new List<string>() { "Student" };
            Person.FullName = new List<string>() { "Sample Student" };
            Person.ListSayName();
            Console.ReadLine();
        }
    }
}
