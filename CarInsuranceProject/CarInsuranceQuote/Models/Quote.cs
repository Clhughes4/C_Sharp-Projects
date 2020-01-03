﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceQuote.Models
{
    public class Quote
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmaiAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public bool HasDUI { get; set; }
        public int PreviousTickets { get; set; }
        public string FullCoverage { get; set; }
        public double CalculatedQuote { get; set; }
    }
}