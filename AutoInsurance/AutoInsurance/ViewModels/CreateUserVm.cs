﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoInsurance.ViewModels
{
    public class CreateUserVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public double Quote { get; set; }
    }
}