using System;
using Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){FirstName = "Bojana", LastName = "Dimovska", Age = 22},
                new Employee(){FirstName = "Boris", LastName = "Karakolev", Age = 23},
                new Employee(){FirstName = "Stefani", LastName = "Sazdovska", Age = 23},
                new Employee(){FirstName = "Krstina", LastName = "Lazarevska", Age = 22},
                new Employee(){FirstName = "Blagoj", LastName = "Delovski", Age = 24},
                new Employee(){FirstName = "Simona", LastName = "Stojanova", Age = 25},
                new Employee(){FirstName = "Zorica", LastName = "Teova", Age = 33},
                new Employee(){FirstName = "Makedonka", LastName = "Dimovska", Age = 45},
                new Employee(){FirstName = "Nikola", LastName = "Stankov", Age = 23},
                new Employee(){FirstName = "Iva", LastName = "Demnieva", Age = 22},
            };

            Dictionary<int, List<string>> myDictionary = new Dictionary<int, List<string>>();
            foreach(var employee in employees)
            {
                if (myDictionary.ContainsKey(employee.Age))
                {
                    List<string> myList = myDictionary[employee.Age];
                    myList.Add($"{employee.FirstName} {employee.LastName}");
                    myDictionary[employee.Age] = myList;
                }
                else
                {
                    myDictionary.Add(employee.Age, new List<string> { $"{employee.FirstName} {employee.LastName}" });
                }
            }

            foreach(var item in myDictionary)
            {
                Console.WriteLine($"{item.Key} year olds:");
                foreach (var name in item.Value)
                {
                    Console.WriteLine(name);
                }
            }


            Console.ReadLine();
        }
    }
}
