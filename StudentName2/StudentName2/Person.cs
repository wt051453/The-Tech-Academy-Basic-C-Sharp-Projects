﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentName2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            string FullName = FirstName + LastName;
            Console.WriteLine("Name: " + FullName);
            Console.ReadLine();
        }
    }
}
