using Domain.Classes;
using Domain.Enums;
using System;

namespace App
{
    class Program
    {
        public bool IsManager(Employee employee)
        {
           return employee.Role == RoleEnum.Manager;
        }
        static void Main(string[] args)
        {

            Employee[] company = new Employee[]
            {
                new Contractor("Bob", "Bobert"),
                new Contractor("Rick","Rickert"),
                new Manager("Mona", "Monalisa"),
                new Manager("Igor", "Igorsky"),
                new SalesPerson("Lea", "Leova")

            };
            CEO[] ceoName = new CEO[]
            {
                new CEO(company, 14)
            };
            foreach (CEO details in ceoName)
            {
                Console.WriteLine("CEO:");
                Console.WriteLine(details.PrintInfo());
                Console.WriteLine($"Salary of CEO is: {details.GetSalary()}$");
                Console.WriteLine("Employees:");
                details.PrintEmployees(company);
            }

            Console.ReadLine();

        }
    }
}
