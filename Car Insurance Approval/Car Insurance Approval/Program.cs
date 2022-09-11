using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string Dui;
            int Tickets;


            Console.WriteLine("Lets see if you qualify for car insurance!");
            Console.WriteLine("What is your age?");
            Age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Have you ever had a DUI Violation? [i.e., for driving under the influence of alcohol]");
            Dui = Console.ReadLine();
            bool trueorfalse = (Dui == "yes" || Dui == "yes" || Dui == "YES");
            Console.WriteLine(trueorfalse);


            Console.WriteLine("How many speeding tickets have you had? ");
            Tickets = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Qualified? ");
            bool qualify = (Age > 15 && (Dui == "No" || Dui == "no" || Dui == "NO") && Tickets < 3);
            Console.WriteLine(qualify);
            Console.ReadLine();
        }
    }
}
