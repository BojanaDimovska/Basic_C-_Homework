using System;

namespace FindDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[10];
            int repetitions = 0;
            int value = 3;

            Console.WriteLine("Input number of elements in the array:");
            bool parsedArray = int.TryParse(Console.ReadLine(), out int numArr);

            Console.WriteLine("Input {0} elements in the array: ", numArr);
            for (int i = 0; i < numArr; i++)
            {
                Console.WriteLine("element = {0}: ", i);
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if ((numbersArray[i] == value) && ((i == numbersArray.Length - 1 ? false : numbersArray[i+1] == value))) 
                {
                    repetitions++;
                }
            }
            Console.WriteLine($"{repetitions} times there are threes next to each other");


            Console.ReadLine();
        }
    }
}
