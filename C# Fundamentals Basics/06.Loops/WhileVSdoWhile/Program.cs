
namespace FindGCD
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            var smaller = input[0];
            var bigger = input[1];

            for (long i = smaller; i > 0; i--)
            {
                if (smaller % i == 0 && bigger % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
