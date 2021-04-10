using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }

        public Manager(string fName, string lName) : base(fName, lName)
        {
            Role = RoleEnum.Manager;
        }

        public double AddBonus()
        {
            return _bonus;
        }

        public override double GetSalary()
        {
            return Salary += _bonus;
        }

    }
}
