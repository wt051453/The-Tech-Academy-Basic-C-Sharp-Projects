using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentName2
{
    public class Employee : Person, IQuittable
    {
        public Employee()
        {
            FirstName = "Sample";
            LastName = "Student";
        }

        public void Quit()
        {
            Console.WriteLine("The above employee is quitting the job today.");
            Console.ReadLine();
        }
    }
}
