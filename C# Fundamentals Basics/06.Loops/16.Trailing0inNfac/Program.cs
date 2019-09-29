using System;
using System.Numerics;
namespace _16.Trailing0inNfac
{
    using System.Transactions;

    class Program
    {
        static void Main(string[] args)
        {
            var numberN = long.Parse(Console.ReadLine());

            // BruteForceSolution(numberN);
            SolutionSpecificAlgo(numberN);

        }

        static void SolutionSpecificAlgo(long numberN)
        {
            var countTrailingZeroes = 0;
            var powOfFive = 1;
            while (true)
            {
                var currentResult = numberN / Math.Pow(5, powOfFive++);
                if (currentResult >= 1)
                {
                    countTrailingZeroes += (int)currentResult;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(countTrailingZeroes);
        }

        static void BruteForceSolution(long numberN)
        {
            BigInteger facBase = 1;

            // BigInteger resultFac = factorial_Space(numberN, facBase); // StackOverflow for 100000
            BigInteger factorial_Space(long number, BigInteger tail_fac)
            {
                if (number == 0)
                {
                    return tail_fac;
                }
                else
                {
                    return factorial_Space(number - 1, tail_fac * number);
                }
            }

            BigInteger resultFac = factorial_Time(numberN, facBase);
            BigInteger factorial_Time(long number, BigInteger tail_fac)
            {
                while (true)
                {
                    if (number == 0)
                    {
                        return tail_fac;
                    }
                    else
                    {
                        var number1 = number;
                        number = number - 1;
                        tail_fac = tail_fac * number1;
                    }
                }
            }

            var trailing0Counter = 0;
            var facAsString = resultFac.ToString();
            for (int i = facAsString.Length - 1; i >= 0; i--)
            {
                if (facAsString[i] == '0')
                {
                    trailing0Counter += 1;
                }
                else
                {
                    break;
                }
            }

            // Console.WriteLine(facAsString);
            Console.WriteLine(trailing0Counter);
        }
    }
}
