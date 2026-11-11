using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Delivery_App
{
    public class DeliveryOrder
    {
        string delivery_address;
        double parcel_weight;
        string nearest_branch;
        string delivery_type;
        double delivery_cost;

        public void setValues(string address, double weight, string branch, string type) {
            delivery_address = address;
            parcel_weight = weight;
            nearest_branch = branch;
            delivery_type = type;
        }

        public void calculateCost() {
            double rate = 0.00;
            if (nearest_branch == "Colombo") { rate = 450.00; }
            else if (nearest_branch == "Kurunegala" || nearest_branch == "Mathara") { rate = 700.00; }
            else { rate = 1200.00; }
            double cost = rate * parcel_weight;

            //Adding 1500 if user has selected delivery type as speed
            if (delivery_type == "speed") { cost = cost + 1500.00; }
        }

        public double getCost() { return delivery_cost; }

    }
}
