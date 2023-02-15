using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

                const int myConstVar = 42; 
                var myVar = "Hello, everyone"; 

                var myObj = new MyClass("ABC"); 

                Console.WriteLine(myConstVar);
                Console.WriteLine(myVar);
                Console.WriteLine(myObj.MyString);

            Console.ReadLine();
            }
        }

        
    }

