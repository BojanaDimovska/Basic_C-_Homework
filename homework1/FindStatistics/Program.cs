using System;

namespace FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            bool parsingResult1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter the second number: ");
            bool parsingResult2 = int.TryParse(Console.ReadLine(), out int num2);

            int sum = num1 + num2;
            int diff = num1 - num2;
            int mul = num1 * num2;

                if(num1 % 2 == 0)
                {
                     if(num2 % 2 == 0){
                    Console.WriteLine($"The two of them are even. The operation and result are {num1} + {num2} = {sum}");
                     }
                }
                if (num1 % 2 == 0)
                {
                    if (num2 % 2 != 0)
                    {
                    Console.WriteLine($"One of the numbers is odd. The operation and result are {num1} - {num2} = {diff}");
                    }
                }
                if (num1 % 2 != 0)
                {
                    if (num2 % 2 == 0)
                    {
                    Console.WriteLine($"One of the numbers is odd. The operation and result are {num1} - {num2} = {diff}");
                    }
                }
                if (num1 % 2 != 0)
                {
                    if (num2 % 2 != 0)
                    {
                    Console.WriteLine($"Both of the numbers are odd. The operation and result are {num1} * {num2} = {mul}");
                    }
                }




            Console.ReadLine();
        }
    }
}
