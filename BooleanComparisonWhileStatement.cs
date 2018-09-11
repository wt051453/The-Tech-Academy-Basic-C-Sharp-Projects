using System;

namespace BooleanComparisonWhileStatement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many children does Tim have?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numberOfChildren = number == 7;

            while (!numberOfChildren)
            {
                switch (number)
                {
                    case 2:
                        Console.WriteLine("He has more than 2 children. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("He has less than 10 children. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You are right. Tim has 7 children.");
                        numberOfChildren = true;
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();
        }
    }
}