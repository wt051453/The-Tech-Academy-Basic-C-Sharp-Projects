using System;
using System.Text;

namespace StringExercise
{
    class Program
    {
        static void Main()
        {
            string firstName = "Raymond";
            string lastName = "Smith";
            string middleName = "King";

            Console.WriteLine("His name is " + firstName + " " + middleName + " " + lastName);
            Console.ReadLine();

            firstName = firstName.ToUpper();
            Console.WriteLine(firstName);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("Today is a good day!");
            sb.Append("Tomorrow will be even better!");
            sb.Append("What will do you tomorrow?");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}