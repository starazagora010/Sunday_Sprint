using System;

namespace _06.CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberN = int.Parse(Console.ReadLine());
            var numberK = int.Parse(Console.ReadLine());
            var result = Factorial(numberN) / Factorial(numberK);
            int Factorial(int num,int tail_Fac = 1)
            {
                if (num == 0)
                {
                    return tail_Fac;
                }
                else
                {
                    return Factorial(num - 1, tail_Fac * num);
                }

            }

            Console.WriteLine(result);
        }
    }
}
