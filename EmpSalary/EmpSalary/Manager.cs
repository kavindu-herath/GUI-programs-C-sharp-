using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSalary
{
    public class Manager:Employee
    {
        private double fuel_allowance;
        private double incentive;
        public double FuelAllowance
        {
            get { return fuel_allowance; }
            set { fuel_allowance = value; }
        }

        public double Incentive
        {
            get { return incentive; }
            set {  incentive = value; }
        }

        public void findManagerSalary(double basic, double p_allow, double advances)
        {
            findSalary(basic,p_allow, advances);

        }

    }
}
