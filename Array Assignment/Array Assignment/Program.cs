using Microsoft.Win32;
using System;
using System.Collections.Generic;




    class Program
    {
        static void Main(string[] args)
        {
        int userString; 

        String[] StringArray = { "Bob", "Tim", "Josh", "Amy", "Sarah"};

        Console.WriteLine("Hello, please select a number between 0 and 4");
        userString = Convert.ToInt16(Console.ReadLine());
        if (userString <= 4)
        {
            Console.WriteLine("The user with this number is: " + StringArray[userString]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("The number selected is too high");
        }
        int userInt;

        int[] IntArray = { 1, 3, 40, 550, 2000 };

        Console.WriteLine("Now please select a number between 0 and 4");
        userInt = Convert.ToInt16(Console.ReadLine());
        if (userInt <= 4)
        {
            Console.WriteLine("The number at this index is: " + IntArray[userInt]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("The number selected is too high");
            Console.ReadLine();
        }


        List<string> StringList = new List<string>();
        StringList.Add("Amy");
        StringList.Add("Josh");
        StringList.Add("James");
        StringList.Add("Billy");

        int UserString1;

        

        Console.WriteLine("Lastly, please select a number between 0 and 3");
        UserString1 = Convert.ToInt16(Console.ReadLine());
        if (UserString1 <= 3)
        {
            Console.WriteLine("The user with this number is: " + StringList[UserString1]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("The number selected is too high");
        }


   
    }
    }

