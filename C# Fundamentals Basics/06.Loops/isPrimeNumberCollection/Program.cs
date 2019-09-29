using System;

namespace isPrimeNumberCollection
{
    using System.Runtime.CompilerServices;

    class Program
    {
        static void Main(string[] args)
        {
            var collectionSize = int.Parse(Console.ReadLine());
            var isPrimeCollection = new (int number, bool isPrime)[collectionSize];
            var randomIntGenerator = new Random();
            for (int i = 0; i < collectionSize; i++)
            {
                isPrimeCollection[i].number = randomIntGenerator.Next(1, int.MaxValue);
                var maxDivider = isPrimeCollection[i].number / 2;
                var divider = 1;
                isPrimeCollection[i].isPrime = true;
                while (isPrimeCollection[i].isPrime && (++divider <= maxDivider))
                {
                    if (isPrimeCollection[i].number % divider == 0)
                    {
                        isPrimeCollection[i].isPrime = false;
                        break;
                    }
                }
            }

            foreach (var valueTuple in isPrimeCollection)
            {
                var msg = $"Number({valueTuple.number}) "
                          + (valueTuple.isPrime ? "IS PRIME" : "IS NOT PRIME");

                Console.WriteLine(msg);
            }
        }
    }
}
