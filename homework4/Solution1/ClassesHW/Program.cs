using ClassesHW.Models;
using System;

namespace ClassesHW
{
    class Program
    {
        static void RaceCars(Car car1, Car car2)
        {
            int winner = car1.CalculateSpeed(car1.Driver) - car2.CalculateSpeed(car2.Driver);
            if(winner == 0)
            {
                Console.WriteLine("There is no winner. It's a draw!");
            } else if (winner > 0)
            {
                Console.WriteLine($"{car1.Driver.Name} with {car1.Model} going {car1.Speed} km/h is the winner!");
            } else
            {
                Console.WriteLine($"{car2.Driver.Name} with {car2.Model} going {car2.Speed} km/h  is the winner!");
            }
        }
        static void Main(string[] args)
        {
            bool success = false;
            do
            {
                Car[] cars = new Car[]
                {
                    new Car("Hyundai", 170),
                    new Car("Mazda", 170),
                    new Car("Ferrari", 290),
                    new Car("Porsche", 280)
                };

                Driver[] drivers = new Driver[]
                {
                    new Driver("Bob", 9),
                    new Driver("Greg", 5),
                    new Driver("Jill", 5),
                    new Driver("Anne", 7)
                };

                Car[] newCar = new Car[] { };
                Driver[] newDriver = new Driver[] { };
                 
                Console.WriteLine("These are the cars that are available:");
                foreach (Car car in cars)
                {
                    Console.WriteLine(car.Model);
                }
                Console.WriteLine("Choose a car no.1");
                string carSelected1 = Console.ReadLine();
                string firstCar = "";
                int firstSpeed = 0;
                int flag = 0;

                for (int i = 0; i < cars.Length; i++)
                {
                    if (carSelected1.ToLower().Contains(cars[i].Model.ToLower()))
                    {
                        firstCar = cars[i].Model;
                        firstSpeed = cars[i].Speed;
                        continue;
                    }
                    else if (carSelected1.ToLower() != cars[i].Model.ToLower())
                    {
                        Array.Resize(ref newCar, newCar.Length + 1);
                        newCar[flag++] = cars[i];
                    }
                }

                if (cars.Length == newCar.Length)
                {
                    Console.WriteLine("You entered an invalid input!");
                    break;
                }

                Console.WriteLine("Theese are the drivers that are available:");
                foreach (Driver driver in drivers)
                {
                    Console.WriteLine(driver.Name);
                }
                Console.WriteLine("Choose driver");
                string driverSelected1 = Console.ReadLine();
                string firstDriver = "";
                int firstSkill = 0;
                int flag2 = 0;

                for (int i = 0; i < drivers.Length; i++)
                {
                    if (driverSelected1.ToLower().Contains(drivers[i].Name.ToLower()))
                    {
                        firstDriver = drivers[i].Name;
                        firstSkill = drivers[i].Skill;
                        continue;
                    }
                    else if (driverSelected1.ToLower() != drivers[i].Name.ToLower())
                    {
                        Array.Resize(ref newDriver, newDriver.Length + 1);
                        newDriver[flag2++] = drivers[i];
                    }
                }
                if (newDriver.Length == drivers.Length)
                {
                    Console.WriteLine("You entered an invalid input");
                    break;
                }

                
                Console.WriteLine("Theese are the cars that are available:");
                foreach (Car car in newCar)
                {
                    Console.WriteLine(car.Model);
                }
                Console.WriteLine("Choose a car no.2");
                string carSelected2 = Console.ReadLine();
                string secondCar = "";
                int secondSpeed = 0;

                for (int i = 0; i < newCar.Length; i++)
                {
                    if (carSelected2.ToLower().Contains(newCar[i].Model.ToLower()))
                    {
                        secondCar = newCar[i].Model;
                        secondSpeed = newCar[i].Speed;
                        break;
                    }
                }

                if (String.IsNullOrEmpty(secondCar) && secondSpeed == 0)
                {
                    Console.WriteLine("You entered an invalid input!");
                    break;
                }

                Console.WriteLine("Theese are the drivers that are available:");
                foreach (Driver driver in newDriver)
                {
                    Console.WriteLine(driver.Name);
                }
                Console.WriteLine("Choose driver");
                string driverSelected2 = Console.ReadLine();
                string secondDriver = "";
                int secondSkill = 0;


                for (int i = 0; i < newDriver.Length; i++)
                {
                    if (driverSelected2.ToLower().Contains(newDriver[i].Name.ToLower()))
                    {
                        secondDriver = newDriver[i].Name;
                        secondSkill = newDriver[i].Skill;
                    }
                }
                if (String.IsNullOrEmpty(secondDriver) && secondSkill == 0)
                {
                    Console.WriteLine("You entered an invalid input");
                    break;
                }

                Driver firstDriverRacing = new Driver(firstDriver, firstSkill);
                Driver secondDriverRacing = new Driver(secondDriver, secondSkill);
                Car firstCarRacing = new Car(firstCar, firstSpeed, firstDriverRacing);
                Car secondCarRacing = new Car(secondCar, secondSpeed, secondDriverRacing);
                RaceCars(firstCarRacing, secondCarRacing);

                Console.WriteLine("Do you want to race again? (y/n)");
                string goAgain = Console.ReadLine();
                if(goAgain == "y")
                {
                    Console.Clear();
                    success = true;
                } else
                {
                    Console.WriteLine("Come back when you're ready. Goodbye!");
                    break;
                }
            } 
            
            while (success == true);

            Console.ReadLine();
        }
    }
}
