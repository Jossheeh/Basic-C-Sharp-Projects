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
            Console.WriteLine("Please enter a decimal number: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a second decimal number");
            double d = Convert.ToDouble(Console.ReadLine());
            int ret;
            double reta;
            int retb;
            Console.WriteLine("Please enter one more number");
            string e = Console.ReadLine();
            int f;
            Int32.TryParse(e, out f);



            Number n = new Number();

        
            ret = n.Math1(a, b);
            Console.WriteLine("Your numbers added are : {0}", ret);


            reta = n.Math1(c, d);
            Console.WriteLine("Your decimal numbers added are : {0}", reta);

            retb = n.Math1(a, b, f);
            Console.WriteLine("Your first two numbers added minus your last number is : {0}", retb);



            Console.ReadLine();



        }
        
    }

}

