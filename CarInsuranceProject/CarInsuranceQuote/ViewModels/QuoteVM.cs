using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceQuote.ViewModels
{
    public class QuoteVm
    {
        public string QuotedPrice { get; set; }
        public QuoteVm(decimal quotedPrice)
        {
            this.QuotedPrice = String.Format("{0:C2}", quotedPrice);
        }
    }
}