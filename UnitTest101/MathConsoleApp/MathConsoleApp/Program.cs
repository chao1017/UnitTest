using System;
using MathLibrary;

namespace MathConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();

            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = mathOperations.Add(num1, num2);

            Console.WriteLine($"The result of adding {num1} and {num2} is: {result}");
        }
    }
}
