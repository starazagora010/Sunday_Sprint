using System;

namespace isPrimeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfColleciton = int.Parse(Console.ReadLine());
            var isPrimeNumberCollection = new int[sizeOfColleciton];
            Random newPrimeGenerator = new Random();

            for (int i = 0; i < sizeOfColleciton; i++)
            {
                isPrimeNumberCollection[i] = newPrimeGenerator.Next(1, int.MaxValue);
            }

            var isPrimeColletion = new bool[sizeOfColleciton];
            var indexer = 0;
            foreach (var isPrimeNumber in isPrimeNumberCollection)
            {
                var maxDivider = isPrimeNumber / 2;
                var divider = 1;
                bool isPrime = true;
                while (isPrime && (++divider <= maxDivider))
                {
                    if (isPrimeNumber % divider == 0)
                    {
                        isPrime = false;
                    }
                }

                isPrimeColletion[indexer] = isPrime;
                if (indexer >= sizeOfColleciton)
                {
                    break;
                }
                // TODO: Run and check for bugs!

                Console.WriteLine($"Number: {isPrimeNumber} isPrime => {isPrime}");
            }

            //TODO:Print
        }
    }
}
