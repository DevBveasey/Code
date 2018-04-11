// Brandon Veasey
// 03/20/2018
// Chapter 10 – Programming Exercise 1
// View invoice information for service companies

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGUI
{
    class Invoice
    {
        // ----- CompanyName -----
        // sets value of companyName if passed a value via set
        // returns a value is nothing is passed via get
        public string CompanyName{ get; set;}

        // ----- AmountDue -----
        // sets value of amountDue if passed a value via set
        // returns a value is nothing is passed via get
        public double AmountDue { get; set; }

        // ----- Overrided ToString -----
        // returns a string that is dispalyed to the user
        public override string ToString()
        {
         return ("From: " + CompanyName + "\n      Amount Due: " + AmountDue.ToString("c"));
        }
    }
}
