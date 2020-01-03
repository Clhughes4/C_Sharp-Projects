using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var quoteVms = new List<QuoteVm>();
                foreach (var insuree in insurees)
                {
                    var quoteVm = new QuoteVm();
                    quoteVm.FirstName = insuree.FirstName;
                    quoteVm.LastName = insuree.LastName;
                    quoteVm.EmailAddress = insuree.EmailAddress;
                    quoteVm.Quote = Math.Round(insuree.Quote, 2);
                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }
        }

        
    }
}