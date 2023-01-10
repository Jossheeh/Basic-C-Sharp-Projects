using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Number
    {
        int userInput;
        public Number()
        
        {
            Console.WriteLine("Please enter a number");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked {0} ", userInput);
            Console.ReadLine();
            Console.WriteLine("Press return to continue");
            Console.WriteLine("Your number multiplied by 50 is: " + userInput * 50);
            Console.ReadLine();
            int total = userInput + 50;
            Console.WriteLine("Your number + 50 is: " + total.ToString());
            Console.ReadLine();
            Console.WriteLine("Your number divided by 2 is: " + userInput / 2);
            Console.ReadLine();
        }

        }
        
    }




