
namespace AutoInsurance.Models
{
    using System;
    using System.Collections.Generic;

    public class AutoInsuranceQuote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string DateofBirth { get; set; }
        public string CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string DUI { get; set; }
        public string SpeedTicket { get; set; }
        public string Coverage { get; set; }
    }
}