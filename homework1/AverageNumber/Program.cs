using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            bool parsingResult1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter the second number: ");
            bool parsingResult2 = int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("Enter the third number: ");
            bool parsingResult3 = int.TryParse(Console.ReadLine(), out int num3);
            Console.WriteLine("Enter the forth number: ");
            bool parsingResult4 = int.TryParse(Console.ReadLine(), out int num4);

            double calcAverage = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"The average number is: {calcAverage}");

            Console.ReadLine();
        }
    }
}
