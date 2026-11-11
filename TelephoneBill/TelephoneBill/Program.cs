using System;

namespace TelephoneBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelephoneBill bill = new TelephoneBill();

            Console.WriteLine("Enter Bill Number: ");
            string bno = Console.ReadLine();

            Console.WriteLine("Enter Month: ");
            string month = Console.ReadLine();

            //set customer name
            Console.WriteLine("Enter Customer Name: ");
            bill.customer_name = Console.ReadLine();

            Console.WriteLine("Enter Standard Talk Time: ");
            double standard_tt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Peak Talk Time: ");
            double peak_tt = Convert.ToDouble(Console.ReadLine());

            //set bill no and month
            bill.setValues(bno, month);

            //calculate bill amount
            bill.calBill(peak_tt, standard_tt);

            //display bill amount
            Console.WriteLine($"Bill Amount: {bill.bill_amount}");
            Console.ReadKey();
            
        }
    }
}
