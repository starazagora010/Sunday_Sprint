using System;

namespace isPrimeCollection_withLINQ
{
    using System.Linq;
    using System.Runtime.CompilerServices;

    class Program
    {
        static void Main()
        {
            var collectionSize = int.Parse(Console.ReadLine());
            var isPrimeCollection = new (int number, bool isPrime)[collectionSize];
            var randomIntGenerator = new Random();

            /*var result = isPrimeCollection.Where(
                x =>
                    {
                        x.number = randomIntGenerator.Next(1, int.MaxValue);
                        x.isPrime = true;
                        var maxDivider = x.number / 2;
                        var divider = 1;
                        while (x.isPrime && (++divider <= maxDivider))
                        {
                            if (x.number % divider == 0)
                            {
                                x.isPrime = false;
                                break;
                            }
                        }

                        return (x.number, x.isPrime);
                    }); // Where returns bool and the result*/

            foreach (var valueTuple in isPrimeCollection)
            {
                var msg = $"Number({valueTuple.number}) "
                          + (valueTuple.isPrime ? "IS PRIME" : "IS NOT PRIME"); 
                              
                Console.WriteLine(msg);
            }
        }
        
    }
}
