using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod2
{
    class MathOperation
    {
        public int Sum (int num1)
        {
            var Total = num1 + 25;
            return Total;
        }
        public int Difference (decimal num1)
        {
            var Total = num1 - 8;
            return Convert.ToInt32(Total);
        }
        public int Product(string num1)
        {
            var Total = Convert.ToInt32(num1) * 10;
            return Total;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            decimal b = 9.9m;
            string c = "13";
            int total;
            MathOperation n = new MathOperation();
            total = n.Sum(a);
            Console.WriteLine("The sum of " + a + " and " + "25" + " is " + total);
            total = n.Difference(b);
            Console.WriteLine("The difference of " + b + " and " + "8" + " is " + total);
            total = n.Product(c);
            Console.WriteLine("The product of " + c + " and " + "10" + " is " + total);
            Console.ReadLine();
        }
    }
}
