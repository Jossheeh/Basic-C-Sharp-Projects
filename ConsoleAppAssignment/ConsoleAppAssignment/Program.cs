using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Jesse", "Eric", "Josh", "Amy" };

        string userText;

        Console.WriteLine("Hello, please enter some text: ");
        userText = Console.ReadLine();

        for (int j = 0; j < names.Length; j++)
        {
            Console.WriteLine(names[j] + " " + userText);
        }
        Console.ReadLine();


        //Infinite loop before fix
        //while (true)
        //{
        //  Console.WriteLine("Hello");
        // }

        //Infinite loop After fix
        string infinite = "Josh";

        Console.WriteLine("Please enter your name");
        infinite = (Console.ReadLine());

        if (infinite == "Josh")
        {

            Console.WriteLine("Hello");
        }

        else if (infinite != "Josh")
        {
            Console.WriteLine("Goodbye Imposter");
        }
        Console.ReadLine();

        int lessthan = 18;
        int age;

        Console.WriteLine("Please enter your age");
        age = Convert.ToInt32(Console.ReadLine());

        if (age >= lessthan)
        {

            Console.WriteLine("Hello, you may enter!");
        }

        else if (age < lessthan)
        {
            Console.WriteLine("You are too young to enter, goodbye");
        }
        Console.ReadLine();

        int lessthanequal = 20;
        int age2;

        Console.WriteLine("Please enter your age");
        age = Convert.ToInt32(Console.ReadLine());

        if (age > lessthanequal)
        {

            Console.WriteLine("Hello, you may enter!");
        }

        else if (age <= lessthanequal)
        {
            Console.WriteLine("The minimum age is 21, goodbye");
        }
        Console.ReadLine();

        List<string> shoplist = new List<string>()
        { "Oranges", "Apples", "Bananas", "Plums" };



        Console.WriteLine("Hello, please enter an item and we will check our what item number it is: ");
        string shopcheck = Console.ReadLine();
        Console.WriteLine("This items code is: ");


        bool matchExists = false;

        for (int i = 0; i < shoplist.Count; i++)
        {
            if (shoplist[i] == shopcheck)
            {
                matchExists = true;
                Console.WriteLine(shoplist.IndexOf(shopcheck));
            }
        }

        if (matchExists == false)
        {
            Console.WriteLine("Sorry, we do not have this item");
        }


        List<string> classlist = new List<string>()
        { "Josh", "Josh", "Mark", "Sarah" };



        Console.WriteLine("Hello, please enter a name: ");
        string student = Console.ReadLine();

        bool matchExists1 = false;

        for (int i = 0; i < classlist.Count; i++)
        {
            if (classlist[i] == student)
           {
                matchExists1 = true;
                Console.WriteLine(classlist.IndexOf(student));
            }
        }

        if (matchExists1 == false)
        {
            Console.WriteLine("Sorry, this is not in the list");
        }




        List<string> playerlist = new List<string>()
        { "Josh", "Josh", "Mark", "Sarah", "Billy" };
        List<string> playerlist_2 = new List<string>();

        for (int i = 0; i < playerlist.Count; i++)
        {
            for (int j = i + 1; j < playerlist.Count; j++)
            {
                if (playerlist[j] == playerlist[i])
                {

                    if (!playerlist_2.Contains(playerlist[i]))
                    {
                        playerlist_2.Add(playerlist[i]);
                    }

                }
            }
        }

        foreach (var N in playerlist_2)
        {
            Console.WriteLine(N);

            Console.ReadLine();

        }
    }
}
    

    



