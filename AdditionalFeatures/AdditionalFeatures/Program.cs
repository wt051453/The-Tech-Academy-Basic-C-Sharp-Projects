using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            const int currentYear = 2018;
            Console.WriteLine("The current year is {0}", currentYear);

            var previousYear = new Time("previous Year", 2017);
            Console.WriteLine("The previous year is {0}", previousYear.Year);
            Console.ReadLine();
        }
    }
}
