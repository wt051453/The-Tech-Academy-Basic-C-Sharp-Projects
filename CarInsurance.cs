using System;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int a = Convert.ToInt16(age);
            Console.WriteLine("Have you ever had a DUI? True or False");
            bool trueOrFalse = Console.ReadLine() == "false";
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTicket = Console.ReadLine();
            int speedTicket = Convert.ToInt16(speedingTicket);
            Console.WriteLine("Qualified?");
            bool qualification = a > 15 && trueOrFalse && speedTicket <= 3;
            Console.Write(qualification.ToString());
            Console.ReadLine();
        }
    }
}