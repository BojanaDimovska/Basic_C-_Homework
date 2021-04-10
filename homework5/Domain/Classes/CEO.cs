using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double _sharesPrice { get; set; }

        public CEO(Employee[] arrOfEmployees, int shares)
        {
            FirstName = "Ron";
            LastName = "Ronsky";
            Salary = 1500;
            Employees = arrOfEmployees;
            Shares = shares;
        }

        public double AddSharesPrice(double num)
        {
            return _sharesPrice = num;
        }

        public void PrintEmployees(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Role}");
            }
        }

        public override double GetSalary()
        {
            double sharesPrice = AddSharesPrice(100);
            return Salary + Shares * sharesPrice;
        }
    }
}
