using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Train ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter number of compartments: ");
            int comCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Average Ticket Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            int[] compartments = new int[comCount];
            Console.WriteLine();

            for (int i = 0; i < compartments.Length; i++) 
            {
                Console.Write($"Enter capacity of compartment {i + 1}: ");
                compartments[i]=Convert.ToInt32(Console.ReadLine());
            }

            //Total expected income
            double totExpected = 0.00;
            for (int i = 0; i < compartments.Length; i++)
            {
                totExpected = totExpected + (compartments[i] * price);
            }

            //total actual income
            double totIncome = 0.00;
            for (int i = 0; i < compartments.Length; i++)
            {
                Console.WriteLine($"Enter reservation for compartment {i + 1}");
                int reservations = Convert.ToInt32(Console.ReadLine());
                totIncome = totIncome + (reservations * price);
            }

            double difference = totExpected - totIncome;
            Console.WriteLine($"Total Expected: LKR. {totExpected}");
            Console.WriteLine($"Actual income: LKR. {totIncome}");
            Console.WriteLine($"Difference: LKR. {difference}");

            Console.ReadKey();
        }
    }
}
