using System;

namespace appTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1 to 3: ");
            bool parsingResult = int.TryParse(Console.ReadLine(), out int num);
               
            if(num == 1)
            {
                Console.WriteLine("You got a new car!");
            }
            else if(num == 2)
            {
                Console.WriteLine("You got a new plane!");
            }
            else if(num == 3)
            {
                Console.WriteLine("You got a new bike!");
            }

            else
            {
                Console.WriteLine("You entered an invalid input!");
            }

            Console.ReadLine();
        }
    }
}
