using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    public class Number
    {
        public void Math1(int a)
        {
            int result = (a / 2);
            Console.WriteLine("The first number divided by 2 is: " + result);
        }

        public static void Math1(int a, int b, out int result)
        {
          
            result = a + b;
        }





    }



}
