using System;

namespace SalaryApp
{
    internal class Employee
    {
        string employee_name = "";
        string department = "";
        double final_salary = 0.00;

        public void setValues(string employee,  string dept) 
        {
            employee_name = employee;
            department = dept;
        }

        public void calSalary(double basic_sal, double oth, double sal_ad) 
        {
            final_salary = basic_sal + (oth * 2500) - sal_ad;
        }

        public string getName() { return employee_name; }
        public string getDepartment() { return department; }
        public double getSalary() { return final_salary; }
           
    }
}
