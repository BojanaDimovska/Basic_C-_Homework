using System;

namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 30, 4, 250, 29, 56, 567, 1, 10, 43, 77 };
            int max, min;

            max = integers[0];
            min = integers[0];

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] > max)
                {
                    max = integers[i];
                }
                if (integers[i] < min)
                {
                    min = integers[i];
                }
            }

            Console.WriteLine($"Maximum is: {max}");
            Console.WriteLine($"Minimum is: {min}");

            Console.ReadLine();
        }
    }
}
