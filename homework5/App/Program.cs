using Domain.Classes;
using Domain.Enums;
using System;

namespace App
{
    class Program
    {
       // public bool IsManager(Employee employee)
        //{
          // return employee.Role == RoleEnum.Manager;
        //}
        static void Main(string[] args)
        {
            SalesPerson[] salesPerson = new SalesPerson[]
            {
                new SalesPerson("Lea", "Leova")
            };
            Manager[] managers = new Manager[]
            {
                new Manager("Mona", "Monalisa", 600),
                new Manager("Igor", "Igorsky", 600)
            };
            Contractor[] contractors = new Contractor[]
            {
                new Contractor("Bob", "Bobert"),
                new Contractor("Rick","Rickert")
            };
            Employee[] company = new Employee[]
            {
                contractors[0],
                contractors[1],
                managers[0],
                managers[1],
                salesPerson[0]
            };
            CEO[] ceoName = new CEO[]
            {
                new CEO(company, 14)
            };
            foreach(CEO details in ceoName)
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
