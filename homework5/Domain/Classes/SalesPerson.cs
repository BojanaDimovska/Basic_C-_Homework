using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue { get; set; }


        public SalesPerson(string fName, string lName) : base(fName, lName)
        {
            Salary = 500;
            Role = RoleEnum.Sales;
        }

        public double AddSuccessRevenue(double num)
        {
            return _successSaleRevenue = num;
        }

        public override double GetSalary()
        {
            if (_successSaleRevenue <= 2000)
            {
                Salary += 500;
            }
            else if (_successSaleRevenue > 2000 && _successSaleRevenue <= 5000)
            {
                Salary += 1000;
            }
            else
            {
                Salary += 1500;
            }
            return Salary;
        }
    }
}
