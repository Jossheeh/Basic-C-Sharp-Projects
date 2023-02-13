using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int b = Convert.ToInt32(Console.ReadLine());
        

            Number n = new Number();
            n.Math1(a, b);

            Console.ReadLine();

        }





    }
        
    }


