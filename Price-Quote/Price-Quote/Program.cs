using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Hi, Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("What weight is the package?");
        int weight = Convert.ToInt32(Console.ReadLine());



        if (weight > 50)
        {
            Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
        }
        else if (weight < 50)
        {
            Console.WriteLine("What width is the package?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What height is the package?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What length is the package?");
            int length = Convert.ToInt32(Console.ReadLine());

            int total = width + height + length;
            Console.WriteLine("The total dimensions of your package are: " + total);

            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            else if (total < 50)
            {
                int cost  = width * height * length / 100;
                Console.WriteLine("The cost of shipping your package is:\u00A3" + cost);
                
            }
        }
       

        Console.ReadLine();
    }
}
    