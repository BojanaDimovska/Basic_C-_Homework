using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, space, rows=4, k, t = 1;
            
            space = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = space; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.Write("\n");
                space--;
            }

            Console.ReadLine();
        }
    }
}
