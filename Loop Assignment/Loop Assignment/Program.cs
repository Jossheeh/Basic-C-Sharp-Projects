using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess Donald Trumps age?");
            int TrumpAge = Convert.ToInt32(Console.ReadLine());
            bool Guessed = TrumpAge == 76;

            do
            {
                switch (TrumpAge)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Trump would be happy. ");
                        Console.WriteLine("Guess Trumps age?");
                        TrumpAge = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 29:
                        Console.WriteLine("You guessed 62. Trump would be happy. ");
                        Console.WriteLine("Guess Trumps age?");
                        TrumpAge = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 55:
                        Console.WriteLine("You guessed 62. Trump would be happy. ");
                        Console.WriteLine("Guess Trumps age?");
                        TrumpAge = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 80:
                        Console.WriteLine("You guessed 62. Trump would be mad!. ");
                        Console.WriteLine("Guess Trumps age?");
                        TrumpAge = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 76:
                        Console.WriteLine("You guessed 76. That is correct, Donald Trump is 76 years old!");
                        TrumpAge = Convert.ToInt32(Console.ReadLine());
                        Guessed = true;
                        break;

                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess Trumps Age?");
                        TrumpAge = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }


            while (!Guessed);




            Console.Read();
        }
    }
}
       
    

