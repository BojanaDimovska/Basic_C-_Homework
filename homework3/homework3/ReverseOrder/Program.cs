using System;

namespace ReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1 = "";
            int l;

            Console.WriteLine("Input a string: ");
            str = Console.ReadLine();

            l = str.Length - 1;
            for (int i = l; i >= 0; i--)
            {
                str1 = str1 + str[i];

            }
            Console.WriteLine("The string in Reverse Order is: {0}", str1);


            Console.ReadLine();
        }
    }
}
