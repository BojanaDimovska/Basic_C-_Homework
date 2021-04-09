using System;

namespace FndWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            Console.WriteLine("The spliited sentence is: ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
