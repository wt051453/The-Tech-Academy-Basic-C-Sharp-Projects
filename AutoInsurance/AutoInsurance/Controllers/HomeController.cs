using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoInsurance.Models;

namespace AutoInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AutoQuote(string firstName, string lastName, string emailAddress, string dateofBirth, string carYear, string carMake, string carModel, string dUI, string speedTicket, string coverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateofBirth) || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(dUI) || string.IsNullOrEmpty(speedTicket) || string.IsNullOrEmpty(coverage))
            {
                return View("~Views/Shared/Error.cshtml");
            }
            else
            {
                using (AutoInsuranceEntities db = new AutoInsuranceEntities())
                {
                    var autoInsuranceQuote = new AutoQuote();
                    autoInsuranceQuote.FirstName = firstName;
                    autoInsuranceQuote.LastName = lastName;
                    autoInsuranceQuote.EmailAddress = emailAddress;
                    autoInsuranceQuote.DateofBirth = dateofBirth;
                    autoInsuranceQuote.CarYear = carYear;
                    autoInsuranceQuote.CarMake = carMake;
                    autoInsuranceQuote.CarModel = carModel;
                    autoInsuranceQuote.DUI = dUI;
                    autoInsuranceQuote.SpeedTicket = speedTicket;
                    autoInsuranceQuote.Coverage = coverage;

                    db.AutoQuotes.Add(autoInsuranceQuote);
                    db.SaveChanges();

                }
                
                return View("Success");
            }
        }
    }
}