using System;

namespace IncomeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tax;

            Console.Write("Enter personal income: ");
            double pi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter business income: ");
            double bi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter investment income: ");
            double ii = Convert.ToDouble(Console.ReadLine());

            double tIncome = pi + bi + ii;

            if (tIncome >= 5000000)
            {
                tax = tIncome * 0.20;
            }

            else if (tIncome >= 2500000)
            {
                tax = tIncome * 0.15;
            }

            else if (tIncome >= 150000)
            {
                tax = tIncome * 0.08;
            }

            else {
                tax = 0;
            }

            Console.Write("Tax Amount: $" + tax);

            Console.ReadKey();

        }
    }
}
