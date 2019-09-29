using System;

namespace _06.MaxKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrSize_N = int.Parse(Console.ReadLine());
            var seqSize_K = int.Parse(Console.ReadLine());

            var arr = new int[arrSize_N];
            for (int i = 0; i < arrSize_N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            var maxKSum = 0;
            for (int i = arr.Length - 1; i >= arr.Length - seqSize_K; i--)
            {
                maxKSum += arr[i];
            }

            Console.WriteLine(maxKSum);
        }
    }
}
