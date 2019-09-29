using System;

namespace _05.FactorialEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberN = int.Parse(Console.ReadLine());
            var numberX = int.Parse(Console.ReadLine());
            var resultSum = 1d;
            var currentGrowingFactorial = 1;
            for (int index = 1; index <= numberN; index++)
            {
                currentGrowingFactorial *= index;
                resultSum += currentGrowingFactorial / Math.Pow(numberX, index);
            }

            Console.WriteLine($"{resultSum:F5}");
        }
    }
}
