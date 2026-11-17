using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder
{
    public class CustomerOrder
    {
        private string address;
        private string branch;
        private double weight;
        private string deliveryType;
        private double cost;

        public string Address { get => address; set => address = value; }
        public string Branch { get => branch; set => branch = value; }
        public double Weight { get => weight; set => weight = value; }
        public string DeliveryType { get => deliveryType; set => deliveryType = value; }
        public double Cost { get => cost; }


        public void findCost()
        {
            double delivery_rate = 0.0;
            if (branch == "Colombo") {
                delivery_rate = 350.0;
            }
            else if (branch == "Kandy") {
                delivery_rate = 500.0;
            }
            else {
                delivery_rate = 800.0;
            }

            cost = weight * delivery_rate;
            
            if (deliveryType == "Speed") {
                cost += 3000.0;
            }
        }
    }
}
