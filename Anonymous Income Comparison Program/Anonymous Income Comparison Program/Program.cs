using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double person1Rate;

            double person1Hours;

            double person2Rate;

            double person2Hours;

           


            Console.WriteLine("Anonymous Income Comparison Program!");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate");
            person1Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your hourly rate is: {0} ", person1Rate);
            Console.ReadLine();
            Console.WriteLine("Please enter how many hours you work a week: ");
            person1Hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You work {0} hours a week", person1Hours);
            Console.ReadLine();

            
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate");
            person2Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your hourly rate is: {0} ", person2Rate);
            Console.ReadLine();
            Console.WriteLine("Please enter how many hours you work a week: ");
            person2Hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You work {0} hours a week", person2Hours);
            Console.ReadLine();

            double annual1 = person1Rate * person1Hours * 52;
            double annual2 = person2Rate * person2Hours * 52;

            Console.WriteLine("Annual salary of person 1: " + annual1);
            Console.ReadLine();
            Console.WriteLine("Annual salary of person 2: " + annual2);
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.ReadLine();
            bool trueorFalse = annual1 > annual2;
            Console.Write(trueorFalse.ToString());
            Console.ReadLine();



        }
    }
}
