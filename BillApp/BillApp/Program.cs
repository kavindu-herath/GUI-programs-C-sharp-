using System;

namespace BillApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter standerd talk time: ");
            double stt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Peak talk time: ");
            double ptt = Convert.ToDouble(Console.ReadLine());

            double bill = stt * 2.80 + ptt * 3.50;

            Console.WriteLine("Total amount: $" + bill);
        }
    }
}
