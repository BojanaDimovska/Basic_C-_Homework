using System;

namespace Calc
{
    class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Div(int num1, int num2)
        {
            return num1 / num2;
        }

        static int Calculator(string ops, int num1, int num2)
        {

            int result =0;
            if (ops == "+")
            {
                result = Sum(num1, num2);
            }
            else if (ops == "-")
            {
                result = Sub(num1, num2);
            }
            else if (ops == "*")
            {
                result = Mul(num1, num2);
            }
            else if (ops == "/")
            {
                result = Div(num1, num2);
            }
            else
            {
                Console.WriteLine("Enter valid Operator");
            }

            return result;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            bool firstNum = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter the second number");
            bool secondNum = int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("Enter operator: +, -, * or /");
            string ops = Console.ReadLine();
            Console.WriteLine(Calculator(ops, num1, num2));

            Console.ReadLine();
        }
    }
}
