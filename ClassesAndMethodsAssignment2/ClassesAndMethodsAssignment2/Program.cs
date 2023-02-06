using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Number n = new Number();
            Console.WriteLine("Pick a number:");
            var a = Console.ReadLine();
            int A = 0;
            if (a != null && a.Length > 0)
            {
                A = Convert.ToInt32(a);
            }
            Console.WriteLine("Pick another number this is optional");
            var b = Console.ReadLine();
         
            int B = 0;
            if (b != null && b.Length > 0)
            {
                B = Convert.ToInt32(b);
            }

            int result = n.Math1(A, B);
            Console.WriteLine("If you selected to input a second number your numbers added will be below," +
                "if you chose not to input a second number, your first number will be shown: " 
                + result);

            Console.ReadLine();
        }





        }

    }


