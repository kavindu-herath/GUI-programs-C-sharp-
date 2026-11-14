using ItemShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicItem obj = new ElectronicItem();
            //set item name
            obj.ItemName = "ABC 23GH";
            //purchasing the item
            obj.purchase(20, 2400.00);
            Console.WriteLine($"Cost Price: {obj.CostPrice}");
            Console.WriteLine($"Stock: {obj.Stock}");
            //set selling price
            obj.setSelling(0.20);
            Console.WriteLine($"Selling Price: {obj.SellingPrice}");
            //sales operation
            double sales_total = obj.sales(3);
            Console.WriteLine($"Sales Total: {sales_total}");
        }
    }
}
