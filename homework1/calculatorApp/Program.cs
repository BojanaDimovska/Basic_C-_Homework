using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            bool parsingResult1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter the second number: ");
            bool parsingResult2 = int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("Enter the operation you would want to use: +,-,* or /");
            bool inputOperation = char.TryParse(Console.ReadLine(), out char operation);
            if (operation == '+')
            {
                Console.WriteLine(num1 + num2);
            }
            else if(operation == '-')
            {
                Console.WriteLine(num1 - num2);
            }
            else if(operation == '*')
            {
                Console.WriteLine(num1 * num2);
            }
            else if(operation == '/')
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Please enter a valid operation!");
            }


            Console.ReadLine();
        }
    }
}
