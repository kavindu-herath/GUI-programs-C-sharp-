using System;

namespace FactorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Console.Write("Enter an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nFactors: ");

            for (int i = 1; i <= x; i++)
            {
                if(x % i == 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
