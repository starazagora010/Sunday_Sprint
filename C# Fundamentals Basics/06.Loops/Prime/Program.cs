namespace Prime
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var primeCandidate = int.Parse(Console.ReadLine());
            var maxDivider = primeCandidate / 2;
            var isPrime = true;
            var divider = 1;

            while (isPrime && ++divider <= maxDivider)
            {
                if (primeCandidate % divider == 0) isPrime = false;
                break;

                divider++;
            }

            Console.WriteLine( isPrime? $"{primeCandidate} is Prime" : $"{primeCandidate} is NOT PRIME");
        }
    }
}