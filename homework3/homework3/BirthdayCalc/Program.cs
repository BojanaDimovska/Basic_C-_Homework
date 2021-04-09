using System;

namespace BirthdayCalc
{
    class Program
    {
        static int AgeCalculator(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Now;
            int years = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-years))
                years--;
            return years;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your birthday date");
            DateTime years = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("You are " + AgeCalculator(years) + " years old");


            Console.ReadLine();
        }

    }
}
