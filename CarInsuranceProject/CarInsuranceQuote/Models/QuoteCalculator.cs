using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceQuote.Models
{
    public class QuoteCalculator
    {
        public static decimal calculateQuote(Quote app)
        {
            decimal quotedPrice = 50.00m;
            if (getAge(app) < 25) quotedPrice += 25;

            else if (getAge(app) < 18) quotedPrice += 100;

            else if (getAge(app) > 100) quotedPrice += 25;

            if (app.CarYear < 2000) quotedPrice += 25;

            else if (app.CarYear > 2015) quotedPrice += 25;

            else if (app.CarMake == ("Porsche").ToLower()) quotedPrice += 25;

            else if (app.CarMake == ("Porsche").ToLower() && app.CarModel == ("911").ToLower()) quotedPrice += 25;

            quotedPrice += 10 * app.PreviousTickets;

            if (app.HasDUI) quotedPrice += .25m;

            if (app.FullCoverage == "Full") quotedPrice += quotedPrice * .5m;

            return quotedPrice;

        }

        public static int getAge(Quote app)
        {
            var today = DateTime.Today;

            var age = today.Year - app.DateOfBirth.Year;
            if (app.DateOfBirth > today.AddYears(-age)) age--;

            return age;
        }
    }
}