using System;

namespace _09_FrequentNumber
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Diagnostics.Tracing;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using System.Transactions;

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

            Solution_Simpler(arr);
            Solution_Complicated(arr);

            // Using Tuples is more readable, BUT the solution is way too complicated as sequence of logical steps
        }

        static void Solution_Complicated(int[] arr)
        {
            var differentNumbersFound = new HashSet<int>(arr).ToArray();
            Array.Sort(differentNumbersFound);

            var arrUniqueNumberTuples = Enumerable.Range(0, differentNumbersFound.Length).Select(
                i => (number: differentNumbersFound[i], count: 0)).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int tupleIndex = 0; tupleIndex < arrUniqueNumberTuples.Length; tupleIndex++)
                {
                    if (arr[i] == arrUniqueNumberTuples[tupleIndex].number)
                    {
                        arrUniqueNumberTuples[tupleIndex].count++;
                        break;
                    }
                }
            }

            var result = arrUniqueNumberTuples.OrderByDescending(x => x.count).First();

            Console.WriteLine($"{result.number} ({result.count} times)");
        }

        static void Solution_Simpler(int[] arr)
        {
            var uniqueNumberDictionary = new Dictionary<int, int>(); // fix use dictionary

            var uniqNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                // TryGetValue implements a internal index search loop
                if (uniqueNumberDictionary.TryGetValue(arr[i], out uniqNumber))
                {
                    uniqueNumberDictionary[arr[i]] = uniqNumber + 1;
                }
                else
                {
                    uniqueNumberDictionary.Add(arr[i], 1);
                }
            }

            var numberMostFrequent = 0;
            var countMostFrequentNumber = 0;
            foreach (var unique in uniqueNumberDictionary)
            {
                if (unique.Value > countMostFrequentNumber)
                {
                    numberMostFrequent = unique.Key;
                    countMostFrequentNumber = unique.Value;
                }
            }

            Console.WriteLine($"{numberMostFrequent} ({countMostFrequentNumber} times)");
        }
    }
}