using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            bool parsingResult1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter the second number");
            bool parsingResult2 = int.TryParse(Console.ReadLine(), out int num2);

            num1 = num1 * num2;      
            num2 = num1 / num2;      
            num1 = num1 / num2;
            Console.WriteLine("After swapping:");
            Console.WriteLine("First number: " + num1);
            Console.WriteLine("second number: " + num2);

            Console.ReadLine();
        }
    }
}
