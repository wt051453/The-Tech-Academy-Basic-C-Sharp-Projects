using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string whatCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pgNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needHelp = Console.ReadLine() == "true";
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int studyHr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}