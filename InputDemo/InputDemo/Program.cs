using System;

namespace InputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            //Integer numbers
            int age = Convert.ToInt32(Console.ReadLine());
            //Double values
            double average = Convert.ToDouble(Console.ReadLine());
            //Float values
            float gpa = Convert.ToSingle(Console.ReadLine());
            //Decimal values
            decimal attendence = Convert.ToDecimal(Console.ReadLine());
            //Boolean values
            bool is_passed = Convert.ToBoolean(Console.ReadLine());
            //Char values
            char grade = Convert.ToChar(Console.ReadLine());
        }
    }
}
