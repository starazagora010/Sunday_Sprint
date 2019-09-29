using System;

namespace MaxNSeq
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var inputSize = int.Parse(Console.ReadLine());
            var inputArr = new int[inputSize];

            for (int i = 0; i < inputSize; i++)
            {
                inputArr[i] = int.Parse(Console.ReadLine());
            }

            var maxCount = 1;
            var currentCount = 1;
            for (int i = 0; i < inputSize - 1; i++)
            {
                if (inputArr[i] == inputArr[i + 1])
                {
                    currentCount++;
                }
                else
                {
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                    }

                    currentCount = 1;
                }
            }

            if (maxCount < currentCount)
            {
                maxCount = currentCount;
            }

            Console.WriteLine(maxCount);
        }
    }
}