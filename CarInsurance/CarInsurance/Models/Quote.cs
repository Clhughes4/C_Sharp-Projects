using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class Quote
    {
        public string QuotedPrice { get; set; }
        public Quote(decimal quotedPrice)
        {
            this.QuotedPrice = String.Format("{0:C2}", quotedPrice);
        }
    }
}