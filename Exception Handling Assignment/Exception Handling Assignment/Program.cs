using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Assignment
{
     class Program
    {
                static void Main(string[] args)
        { 
                try
                {
                    Console.Write("Enter your age: ");
                    int age = int.Parse(Console.ReadLine());

                    if (age <= 0)
                    {
                        throw new Exception("Age must be a positive number.");
                    }

                    int birthYear = DateTime.Now.Year - age;
                    Console.WriteLine("You were born in " + birthYear + ".");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Age must be a whole number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            Console.ReadLine();
            }
        }

    }

