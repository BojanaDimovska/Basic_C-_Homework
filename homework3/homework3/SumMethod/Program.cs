using System;

namespace SumMethod
{
    class Program
    {
        static int Sum()
        {
            Console.WriteLine("Input number here: ");
            bool number = int.TryParse(Console.ReadLine(), out int num);

            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;

            }
            return sum;
        }


        static void Main(string[] args)
        {

            Console.WriteLine(Sum());

            Console.ReadLine();
        }
    }
}
