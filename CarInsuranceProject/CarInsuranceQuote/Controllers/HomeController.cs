using CarInsuranceQuote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceQuote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CarInsuranceQuote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, int tickets, Boolean dui = false, Boolean fullCoverage = false )
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceQuoteEntities db = new InsuranceQuoteEntities())
                {
                        var quote = new AutoQuote();
                        quote.FirstName = firstName;
                        quote.LastName = lastName;
                        quote.EmailAddress = emailAddress;
                        quote.DateOfBirth = dateOfBirth;
                        quote.CarYear = carYear;
                        quote.CarMake = carMake;
                        quote.CarModel = carModel;
                        quote.PreviousTickets = tickets;
                        quote.HasDUI = dui;
                        quote.FullCoverage = fullCoverage;

                        db.AutoQuotes.Add(quote);
                        db.SaveChanges();
                }
            }
            return View("Quote");
        }

        public ActionResult Admin()
        {
            using (InsuranceQuoteEntities db = new InsuranceQuoteEntities())
            {
                var autoquotes = db.AutoQuotes;
                var autoQuoteVm = new List<QuoteVm>();
                foreach (var autoquote in autoquotes)
                {
                    var quoteVm = new AdminVm();
                    quoteVm.Id = autoquote.Id;
                    quoteVm.FirstName = autoquote.FirstName;
                    quoteVm.LastName = autoquote.LastName;
                    quoteVm.EmaiAddress = ConvertTo(autoquote.EmailAddress;
                    quoteVm.DateOfBirth = autoquote.DateOfBirth.ToString(DateTime);
                    quoteVm.CarYear = autoquote.CarYear;
                    quoteVm.CarMake = autoquote.CarMake;
                    quoteVm.CarModel = autoquote.CarModel;
                    quoteVm.PreviousTickets = autoquote.PreviousTickets;
                    quoteVm.HasDUI = autoquote.HasDUI;
                    quoteVm.FullCoverage = autoquote.FullCoverage;

                    db.AutoQuotes.Add(quote);
                    db.SaveChanges();
                }
            }
            return View();
        }
    }
}