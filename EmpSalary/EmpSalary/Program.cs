using System;

namespace EmpSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Advances
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee name: ");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Department: ");
            emp.Department = Console.ReadLine();

            Console.WriteLine("Enter Basic Salary: ");
            double basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Project Allowance: ");
            double allowance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Salary Advances: ");
            double advance = Convert.ToDouble(Console.ReadLine());
            emp.findSalary(basic, allowance, advance);
            Console.WriteLine($"Final Salary: {emp.Salary}");
            Console.ReadKey();

        }
    }
}
