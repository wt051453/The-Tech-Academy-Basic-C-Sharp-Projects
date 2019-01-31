using System;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width.");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length.");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                int dimentionTotal = packageWidth + packageHeight + packageLength;
                if (dimentionTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    decimal result = dimentionTotal * packageWeight / 100m;
                    Console.WriteLine("Your estimated total for shipping this package is " + "$" + result);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
