using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Bojana", "Bojan", "Jovana", "Stefan", "Viktor" };
            Console.WriteLine("Enter student group: (there are 1 and 2)");
            bool success = int.TryParse(Console.ReadLine(), out int number);
            if (number == 1)
            {
                Console.WriteLine("The students in G1 are:");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }

            }
            else if (number == 2)
            {
                Console.WriteLine("The students in G2 are:");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }

            Console.ReadLine();
        }
    }
}
