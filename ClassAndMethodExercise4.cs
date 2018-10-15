using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod4
{
    public static class StaticExample
    {
        public static void SampleStaticMethod()
        {
            Console.WriteLine("This is an example of static class");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod4
{
    public class MathOperation
    {
        public void division (int num1)
        {
            int Result = num1 / 2;
            Console.WriteLine("The number " + num1 + " divided by " + 2 + " is " + Result);
            return;
        }
        public void multiplication (out int num1)
        {
            Console.WriteLine("please enter a number for multiplication");
            num1 = Convert.ToInt32(Console.ReadLine());
            int Result = num1 * 22;
            Console.WriteLine("The number " + num1 + " multiplied by " + 22 + " is " + Result);
        }
        public void multiplication (out int num1, out int num2)
        {
            Console.WriteLine("Please enter the first number for multiplication");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number for multiplication");
            num2 = Convert.ToInt32(Console.ReadLine());
            int Result = num1 * num2;
            Console.WriteLine(num1 + " multiplied by " + num2 + " is " + Result);
        }
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b;
            MathOperation n = new MathOperation();
            n.division(a);
            Console.ReadLine();

            n.multiplication(out b);
            Console.ReadLine();

            n.multiplication(out a, out b);
            Console.ReadLine();

            StaticExample.SampleStaticMethod();
            Console.ReadLine();
        }
    }
}