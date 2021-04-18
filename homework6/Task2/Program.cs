using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void SquareNumbers(List<int> listOfNumbers)
        {
            List<int> squareNum = listOfNumbers.Select(n => n * n).ToList();
            foreach(int num in squareNum)
            {
                Console.WriteLine(num);
            }
        }

        static void Main(string[] args)
        {
            List<int> num = new List<int>()
            {
                {4 },
                {3 },
                {9 },
                {5 },
                {8 },
                {2 },
                {7 },
                {4 },
                {6 },
                {2 },
            };

            SquareNumbers(num);

            Console.ReadLine();
        }
    }
}
