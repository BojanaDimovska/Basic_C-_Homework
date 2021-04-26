using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }

        public Manager(string fName, string lName, double salary) : base(fName, lName)
        {
            Role = RoleEnum.Manager;
            Salary = salary;
            _bonus = 0;
        }

        public double AddBonus(double bonus)
        {
           return  _bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }

    }
}
