using System;
using System.Collections.Generic;

namespace iterationPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] breakfastItems = { "Eggs", "Sausage", "Banana", "Cereal" };
            Console.WriteLine("Please enter your favorite drink for breakfast.");
            string userDrink = Console.ReadLine();

            for (int i = 0; i < breakfastItems.Length; i++)
            {
                Console.WriteLine("breakfast combo is " + breakfastItems[i] + " and " + userDrink);
            }
            Console.ReadLine();

            //for (int j = 0; j - 1 < j++; j++)
            //{
            //    Console.WriteLine("infinite loop?");
            //}
            //Console.ReadLine();

            for (int j = 0; j - 1 < breakfastItems.Length; j++)
            {
                Console.WriteLine("fixed infinite loop");
            }
            Console.ReadLine();

            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine("One of the top breakfast combo is " + breakfastItems[k] + " and " + userDrink);
            }
            Console.ReadLine();

            for (int l = 0; l <= 2; l++)
            {
                Console.WriteLine("Please get some " + breakfastItems[l]);
            }
            Console.ReadLine();

            List<string> names = new List<string>() { "Superman", "Batman", "Spiderman", "Quicksilver" };
            Console.WriteLine("Please select and type one of the following super heros: Superman, Batman, Spiderman, and Quicksilver");
            string name = Console.ReadLine();
            var m = 0;
            bool found = false;
            while (m < names.Count && found != true)
            {


                if (name == names[m])
                {
                    found = true;
                    Console.WriteLine("Your input " + name + " equaled the value " + (string)names[m] + " at index " + (int)m);
                }
                m++;
            }
            if (found == false) Console.WriteLine("Your superhero is not on the list");
            Console.ReadLine();

            List<string> names1 = new List<string>() { "Superman", "Batman", "Spiderman", "Superman" };
            Console.WriteLine("Please select and type one of the following super heros: Superman, Batman, and Spiderman");
            string name1 = Console.ReadLine();
            var n = 0;
            bool found1 = false;
            while (n < names1.Count)
            {
                if (name1 == names1[n])
                {
                    found1 = true;
                    Console.WriteLine("Your input " + name1 + " equaled the value/values " + (string)names1[n] + " at index/indices " + (int)n);
                }
                n++;
            }
            if (found1 == false) Console.WriteLine("Your superhero is not on the list");
            Console.ReadLine();

            //foreach (var item in collection)
            //{

            //}


            var distinct = new List<string>();
            var duplicates = new List<string>();


            foreach (var hero in names1)
            {
                if (!distinct.Contains(hero))
                    distinct.Add(hero);
                else
                    duplicates.Add(hero);
            }
            foreach (var hero in distinct)
            Console.WriteLine("The hero " + hero + " has not already appeared in the list");

            foreach (var hero in duplicates)
            Console.WriteLine("The hero " + hero + " has already appeared in the list");
            Console.ReadLine();

        }

    }
}
