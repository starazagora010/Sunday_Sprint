using System;

namespace _07.SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrSize = int.Parse(Console.ReadLine());
            var arr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrSize; i++)
            {
                var minEl = i;
                for (int smallestLookup = i + 1; smallestLookup < arrSize; smallestLookup++)
                {
                    if (arr[minEl] > arr[smallestLookup])
                    {
                        minEl = smallestLookup;
                    }
                }

                if (minEl != i)
                {
                    arr[i] ^= arr[minEl];
                    arr[minEl] ^= arr[i];
                    arr[i] ^= arr[minEl];
                }
            }

            Console.WriteLine("RESULT:");
            foreach (var el in arr)
            {
                Console.WriteLine(el);
            }
        }
    }
}
