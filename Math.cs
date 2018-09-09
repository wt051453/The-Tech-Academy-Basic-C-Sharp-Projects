using System;

namespace Math
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number!");
            string numberOne = Console.ReadLine();
            int num1 = Convert.ToInt32(numberOne);
            int num2 = 50;
            int product = num1 * num2;
            Console.WriteLine("Your number multiplied by 50 is equal to " + product);
            Console.ReadLine();

            Console.WriteLine("Input a second number!");
            string numberTwo = Console.ReadLine();
            int num3 = Convert.ToInt32(numberTwo);
            int num4 = 25;
            int total = num3 + num4;
            Console.WriteLine("Your number added by 25 is equal to " + total);
            Console.ReadLine();

            Console.WriteLine("Input a third number!");
            string numberThree = Console.ReadLine();
            int num5 = Convert.ToInt32(numberThree);
            float num6 = 12.5f;
            float quotient = num5 / num6;
            Console.WriteLine("Your number divided by 12.5 is equal to " + quotient);
            Console.ReadLine();

            Console.WriteLine("Input a fourth number!");
            string numberFour = Console.ReadLine();
            int num7 = Convert.ToInt32(numberFour);
            bool trueOrFalse = num7 > num2;
            Console.WriteLine("Your number is greater than 50? " + trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Input a fifth number!");
            string numberFive = Console.ReadLine();
            int num8 = Convert.ToInt32(numberThree);
            int num9 = 7;
            int remainder = num8 % num9;
            Console.WriteLine("Your number divided by 7 has remainder of " + remainder);
            Console.ReadLine();
        }
    }
}
