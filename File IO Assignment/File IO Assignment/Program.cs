using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Assignment
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, please enter a number: ");
            string input = Console.ReadLine();

       
            using (StreamWriter writer = new StreamWriter(@"C:\Users\jsjos\Basic_C#_Projects\Logs\log1.txt"))
            {
                writer.WriteLine(input);
            }

            using (StreamReader reader = new StreamReader(@"C:\Users\jsjos\Basic_C#_Projects\Logs\log1.txt"))
            {
                string fileContents = reader.ReadToEnd();
                Console.WriteLine("The number you entered (" + fileContents.Trim() + ") has been logged to " + @"C:\Users\jsjos\Basic_C#_Projects\Logs\log1.txt");
            }

            Console.ReadLine(); 
        }
    }
}
