using System;

namespace _08.MaximalSum
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            var maxSum = 0;
            var currentPassSum = 0;
            //// var bruteArrList = new List<int>[n]; // to find the elements consisting the maxSum

            // the maximal sum of consecutive elements 
            for (int i = 0; i < n; i++)
            {
                currentPassSum = arr[i];
                if (maxSum < currentPassSum)
                {
                    maxSum = currentPassSum;
                }

                var subPassSum = arr[i];
                for (int sub = i+1; sub < n - 1; sub++)
                {
                    subPassSum += arr[sub];
                    if (currentPassSum < subPassSum)
                    {
                        currentPassSum = subPassSum;
                    }
                }

                maxSum = Math.Max(maxSum, currentPassSum);
            }

            Console.WriteLine(maxSum);
            //// NoteToSelf: Good end-to-end logic
        }
    }
}
