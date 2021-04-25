using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Classes;
using Domain.Enums;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal(){Name = "Cat", Color ="Black", Age = 3, Gender = Gender.Male},
                new Animal(){Name = "Dog", Color ="Golden", Age = 3, Gender = Gender.Male},
                new Animal(){Name = "Anaconda", Color ="Dark Green", Age = 5, Gender = Gender.Female},
                new Animal(){Name = "Horse", Color ="Brown", Age = 6, Gender = Gender.Male},
                new Animal(){Name = "Shrewmouse", Color ="Gray", Age = 1, Gender = Gender.Female},
            };

            List<string> aged5OrAbove = animals.Where(x => x.Age >= 5).Select(x => $"{x.Name} {x.Age}").ToList();
            List<Animal> nameStartingWithA = animals.Where(x => x.Name.StartsWith('A')).ToList();
            List<Animal> maleBrownAnimals = animals.Where(x => x.Color == "Brown" && x.Gender == Gender.Male).ToList();
            Animal nameLongerThan10 = animals.FirstOrDefault(x => x.Name.Length > 10);

            Console.WriteLine("All the animals that are aged 5 or above:");
            foreach (string age in aged5OrAbove)
            {
                Console.WriteLine(age);
            }

            Console.WriteLine("All of the animals that have a name starting with 'A':");
            foreach(Animal nameOnA in nameStartingWithA)
            {
                Console.WriteLine(nameOnA.Name);
            }

            Console.WriteLine("All of the animals that have brown furr and are male:");
            foreach(Animal maleBrown in maleBrownAnimals)
            {
                Console.WriteLine($"{maleBrown.Name} {maleBrown.Color} {maleBrown.Gender}");
            }

            Console.WriteLine("All animals with name longer that 10 characters:");
            if(nameLongerThan10 == null)
            {
                Console.WriteLine("There is no such animal!");
            }
            else
            {
                Console.WriteLine(nameLongerThan10.Name);
            }

            Console.ReadLine();
        }
    }
}
