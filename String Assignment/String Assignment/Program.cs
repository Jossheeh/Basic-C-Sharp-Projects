using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
               string name = "Name: Josh";
                  String age = " Age: 29";
                  String area = " Area: Cork";

            name = name.ToUpper();
            Console.WriteLine(name + age + area);
               
          


            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Josh \n I am 29 Years old \n I live in Cork.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
