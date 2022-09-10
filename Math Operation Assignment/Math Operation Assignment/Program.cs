using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation_Assignment
{
    class Program
    {
        static void Main(string[] args)

        {
            int userInput;

            int multiply = 50;

            double division = 12.5;

            int addition = 25;

            double remainder = 7; 
            

            Console.WriteLine("Lets multiply!");
            Console.WriteLine("Enter a number");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked {0} ", userInput);
            Console.ReadLine();
            Console.WriteLine("Your number multiplied by 50 is: " + userInput * multiply);
            Console.ReadLine();

            Console.WriteLine("Lets do some addition!");
            Console.WriteLine("Enter a number");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked {0} ", userInput);
            Console.ReadLine();
            int total = userInput + addition;
            Console.WriteLine("Your number + 25 is: " + total.ToString());
            Console.ReadLine();

            Console.WriteLine("Lets do some division!");
            Console.WriteLine("Enter a number");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked {0} ", userInput);
            Console.ReadLine();
            double division1 = userInput / division;
            Console.WriteLine("Your number divided by 12.5 is: " + division1.ToString());
            Console.ReadLine();

            Console.WriteLine("Lets do check a true or false statement");
            Console.WriteLine("Enter a number and we will check if it is greater than 50");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked {0} ", userInput);
            Console.ReadLine();
            bool trueorFalse = userInput > 50;
            Console.Write(trueorFalse.ToString());
            Console.ReadLine();


            Console.WriteLine("Lets do some more division!");
            Console.WriteLine("Enter a number");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked {0} ", userInput);
            Console.ReadLine();
            double remainder1 = userInput / remainder;
            Console.WriteLine("Your number divided by 7 is: " + remainder1.ToString());
            Console.ReadLine();


            //int total = 5 + 10;
            //Console.WriteLine("Five plus ten = " + total.ToString());
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 10 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();
        }
    }
}
