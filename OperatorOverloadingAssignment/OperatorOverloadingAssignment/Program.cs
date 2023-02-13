using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
     class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { ID = 101, Name = "Josh" };
            Employee emp2 = new Employee { ID = 102, Name = "Bill" };
            Employee emp3 = new Employee { ID = 101, Name = "Amy" };

            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 == emp3);

            Console.ReadLine();
        }
    }
}
