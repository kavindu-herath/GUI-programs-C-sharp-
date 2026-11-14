using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSalary
{
    public class Employee
    {
        private string name;
        private string department;
        private double salary;

        //these can't be edited. so we'll use only getter method
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Department
        {
            get { return  department; }
            set {  department = value; }
        }

        public double Salary
        {
            get { return  salary; }
        }

        public void findSalary(double basic, double allowance, double advances)
        {

        }
    }
}
