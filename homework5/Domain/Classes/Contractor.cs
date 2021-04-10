using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Employee Responsible { get; set; }

        public Contractor(string fName, string lName, double workHours, int payPerHour, Employee responsible) : base(fName, lName)
        {
            FirstName = fName;
            LastName = lName;
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
            Role = RoleEnum.Contractor;
        }

        public Contractor(string fName, string lName) : base(fName, lName)
        {
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public RoleEnum CurrentPosition()
        {
            return Role;
        }
    }
}
