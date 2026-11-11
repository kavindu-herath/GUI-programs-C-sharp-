using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBill
{
    public class TelephoneBill
    {
        private string bill_number;
        private string month;
        public string customer_name;
        public double bill_amount;

        public void calBill(double peak_tt, double standard_tt)
        {
            bill_amount = standard_tt * 3.20 + peak_tt * 2.45;
        }

        public void setValues(string number, string month)
        {
            bill_number = number;
            this.month = month;
        }

    }
}
