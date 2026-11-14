using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemShop
{
    internal class Item
    {
        private string name;
        private double cost_price;
        private double selling_price;
        private double stock;

        public string ItemName {  
            get { return name; } 
            set { name = value; } 
        }
        public double CostPrice { get { return cost_price; } }
        public double SellingPrice { get { return selling_price; } }
        public double Stock {  get { return stock; } }

        public double sales(double quantity) {
            stock -= quantity;
            return selling_price * quantity;
        }

        public void purchase (double quantity, double total_cost) {
            cost_price = total_cost / quantity;
            stock += quantity;
        }

        public void setSelling(double margin) {
            selling_price = cost_price+(cost_price + margin);
        }

        //parameterized constructor
        public Item(string name)
        {
            this.name = name;
            cost_price = 0.00;
            selling_price = 0.00;
            stock = 0.00;
        }
    }
}
