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
    class OverdueInvoice : Invoice
    {
        // ----- DaysOverdue -----
        // sets value of DaysOverdue if passed a value via set
        // returns a value is nothing is passed via get
        public int DaysOverdue { set; get; }

        // ----- Overrided ToString -----
        // returns a string that is dispalyed to the user
        public override string ToString()
        {
                return ("From: " + CompanyName + "\n      Amount Due: " + AmountDue.ToString("c") + "\n      Days Overdue: " + DaysOverdue);
        }
    }
}
