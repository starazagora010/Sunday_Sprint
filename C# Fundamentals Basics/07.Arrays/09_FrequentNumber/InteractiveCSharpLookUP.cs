using System;
using System.Collections.Generic;
using System.Text;

namespace _09_FrequentNumber
{
    using System.Linq;

    class InteractiveCSharpLookUP
    {
        void Solution()
        {
            var n = 13;
            var arr = new [] {4,1,1,4,2,3,4,4,1,2,4,9,3};
            
            var differentNumbersFound = new HashSet<int>(arr).ToArray();
            Array.Sort(differentNumbersFound);

            var arrUniqueNumberTuples = Enumerable.Range(0, differentNumbersFound.Length).Select(
                i => (number: differentNumbersFound[i], count: 0)).ToArray();

            for (int i = 0; i < n; i++)
            {
                for (int tupleIndex = 0; tupleIndex < arrUniqueNumberTuples.Length; tupleIndex++)
                {
                    if (arr[i] == arrUniqueNumberTuples[tupleIndex].number)
                    {
                        arrUniqueNumberTuples[tupleIndex].count++;
                    }
                }
            }

            var result = arrUniqueNumberTuples.OrderByDescending(x => x.count).First();
            
            Console.WriteLine($"{result.number} ({result.count} times)");
        }
    }
}
