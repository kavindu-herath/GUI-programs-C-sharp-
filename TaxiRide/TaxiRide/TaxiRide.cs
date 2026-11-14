using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiRide
{
    public class TaxiRide
    {
        private string customerName;
        private string vehicleNumber;
        private string start;
        private string destination;
        private double rideFee;

        //Gtters and Setters
        public string getCustomer() { return customerName; }
        public void setCustomer(string cust) { customerName = cust; }

        //Property
        public string Vehicle       
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }

        public string Start
        {
            get { return start; }
            set {  start = value; }
        }

        public string Destination
        {
            get { return destination; }
            set {  destination = value; }
        }

        //We don't add setter for this because, it's value don't change (only for read)
        public double Fee
        {
            get { return rideFee; }
        }

        public void calFee(double distance){
            if(distance > 0){
                rideFee = 200.00 + (distance - 1) * 150.00;
            }
            else{
                rideFee = 200.00;
            }
        }

    }
}
