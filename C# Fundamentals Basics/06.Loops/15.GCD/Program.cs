using System;

namespace _15.GCD
{
    class Program
    {
        static void Main()
        {
            var smaller = long.Parse(Console.ReadLine());
            var bigger = long.Parse(Console.ReadLine());

            // order
            if (smaller > bigger)
            {
                smaller ^= bigger;
                bigger ^= smaller;
                smaller ^= bigger;
            }

            long SCD(long small, long big)
            {
                for (long i = 2; i <= small; i++)
                {
                    if (small % i == 0 && big % i == 0)
                    {
                        return i;
                    }
                }

                return 1;
            }

            long GCD(long small, long big)
            {
                for (long i = small; i > 1; i--)
                {
                    if (small % i == 0 && big % i == 0)
                    {
                        return i;
                    }
                }

                return 1;
            }

            // Console.WriteLine(SCD(smaller,bigger));
            Console.WriteLine(GCD(smaller,bigger));
        }
    }
}
