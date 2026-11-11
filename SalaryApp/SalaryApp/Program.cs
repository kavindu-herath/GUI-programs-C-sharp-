using System;

namespace SalaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Department: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary: ");
            double basic_sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter OT Hours: ");
            double oth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Salary Advance: ");
            double sal_ad = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee();
            emp.setValues(name, department);
            emp.calSalary(basic_sal, oth, sal_ad);
            Console.WriteLine($"Employee Final Salary: {emp.getSalary()}");
            Console.ReadKey();
        }
    }
}
