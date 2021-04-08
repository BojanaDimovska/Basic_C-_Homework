using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = new int[6];
            int[] arrayOfEven = new int[6];
            int i, j = 0, sum = 0;



            Console.WriteLine("Input 6 elements in the array :", arrayOfIntegers);
            for (i = 0; i < arrayOfIntegers.Length; i++)
            {
                Console.WriteLine("Enter integer no.{0} : ", i);
                arrayOfIntegers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] % 2 == 0)
                {
                    arrayOfEven[j] = arrayOfIntegers[i];
                    j++;
                }

            }


            for (i = 0; i < arrayOfEven.Length; i++)
            {
                sum += arrayOfEven[i];
            }

            Console.WriteLine("Sum of all even elements is: {0}", sum);




            Console.ReadLine();
        }
    }
}
