using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[10];
            Console.WriteLine("Enter 10 numbers !!");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = numbers.Length-1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
