using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Current date and time: " + DateTime.Now);

            Console.Write("Enter a number of hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            DateTime futureTime = DateTime.Now.AddHours(hours);
            Console.WriteLine("Time after " + hours + " hours: " + futureTime);
            Console.ReadLine();
        }
    }
}
