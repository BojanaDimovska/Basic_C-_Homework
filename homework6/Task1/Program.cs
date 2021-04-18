using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items in the queue:");
            bool parsedNum = int.TryParse(Console.ReadLine(), out int n);

            Queue<int> theQueue = new Queue<int>();

            if (parsedNum)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter element no.{0}", i);
                    bool parsedNum2 = int.TryParse(Console.ReadLine(), out int input);
                    theQueue.Enqueue(input);
                }
            }
            else
            {
                Console.WriteLine("The input you entered, can't be parsed!");
            }

            foreach (int item in theQueue) 
            {
                Console.WriteLine("The numbers you entered in the Queue are:");
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
