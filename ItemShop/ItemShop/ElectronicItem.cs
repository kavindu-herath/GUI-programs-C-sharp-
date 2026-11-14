using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemShop
{
    public class ElectronicItem : Item
    {
        private string manufacturer;
        private int warrenty_period;
        public string Manufacturer {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public int WarrantyPeriod {
            get { return warrenty_period; }
            set { warrenty_period = value; }
        }
        
        public double StockValue() { return Stock * SellingPrice; }

        public ElectronicItem(string name, string man, int war_p):base(name){
            manufacturer = man;
            warrenty_period = war_p;
        }
    }
}
