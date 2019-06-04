using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPracticalExercise.Models;

namespace MVCPracticalExercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       [HttpPost]
       public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime dob, 
           string carYear, string carMake, string carModel, bool dui, string speeding, string covrage)
        {
            

            using(InsuranceQuotesEntities db = new InsuranceQuotesEntities())
            {
                
                var app = new application();
                app.FirstName = firstName;
                app.LastName = lastName;
                app.EmailAddress = emailAddress;
                app.DateOfBirth = dob;
                app.CarYear = Convert.ToInt32(carYear);
                app.CarMake = carMake;
                app.CarModel = carModel;
                app.DUI = dui;
                app.SpeedingTickets = Convert.ToInt32(speeding);
                app.Coverage = covrage;

                double quote = 50;
                int month = app.DateOfBirth.Value.Month - DateTime.Now.Month;
                int age = DateTime.Now.Year - app.DateOfBirth.Value.Year;

                if (month > 0) age--;

                if (age < 25 || age > 100)
                {
                    if (age < 18)
                    {
                        quote += 100;
                    }
                    else
                    {
                        quote += 25;
                    }
                }

                if (app.CarYear < 2000 || app.CarYear > 2015) quote += 25;

                if (app.CarMake.ToLower() == "porsche")
                {
                    quote += 25;
                    if (app.CarModel.ToLower() == "911 carrera" || app.CarModel.ToLower() == "911carrera") quote += 25;
                }

                quote += (app.SpeedingTickets.Value * 10);

                if (app.DUI.Value) quote += (quote * 0.25);
                if (app.Coverage.ToLower() == "full") quote += (quote * 0.5);

                app.Quote = Convert.ToInt32(quote);

                db.applications.Add(app);
                db.SaveChanges();

                return View(app);
            }
          
        }

        public ActionResult Admin()
        {
            using (InsuranceQuotesEntities db = new InsuranceQuotesEntities())
            {
                var app = db.applications;

                var apps = new List<application>();

                foreach (var application in app)
                {
                    var a = new application();
                    a.FirstName = application.FirstName;
                    a.LastName = application.LastName;
                    a.EmailAddress = application.EmailAddress;
                    
                    a.Quote = application.Quote;
                    apps.Add(a);
                }
                return View(apps);
            }
         
        }
       
    }
}