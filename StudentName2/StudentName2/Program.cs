using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentName2
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable n = new Employee();
            n.Quit();

        }
    }
}
