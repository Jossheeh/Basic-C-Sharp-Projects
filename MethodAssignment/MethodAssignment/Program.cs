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
            int ret;

            Number n = new Number();


            ret = n.Math1(a, b);
            Console.WriteLine("Your numbers added are : {0}", ret);


            Number n1 = new Number();


            ret = n1.Math2(a, b);
            Console.WriteLine("Your numbers subtracted are : {0}", ret);

            Number n2 = new Number();


            ret = n2.Math3(a, b);
            Console.WriteLine("Your numbers multiplied are : {0}", ret);

            Console.ReadLine();



        }

    }

}



