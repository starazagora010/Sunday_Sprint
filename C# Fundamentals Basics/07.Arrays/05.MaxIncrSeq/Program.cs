using System;

namespace _05.MaxIncrSeq
{
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

            Console.WriteLine("------");
            Solution_V01(inputArr);
            Solution_V02(inputArr);


        }

        static void Solution_V01(int[] inputArr)
        {
            var maxCount = 1;
            var currentCount = 1;
            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                if (inputArr[i] < inputArr[i + 1])
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

        static void Solution_V02(int[] inputArr)
        {
            var maxSeqCount = 1;
            var currentComparedSeqCount = 1;
            for (int i = 0; i < inputArr.Length - 1; i++)
            {

                if (inputArr[i] < inputArr[i+1])
                {
                    currentComparedSeqCount++;
                }
                // i + 1 == inputArr.Length 
                //  !!!!! you have not for True ?assign ? // this is wrong
                else if ( i + 1 == inputArr.Length  || inputArr[i] >= inputArr[i + 1])
                {
                    if (currentComparedSeqCount > maxSeqCount)
                    {
                        maxSeqCount = currentComparedSeqCount;
                        currentComparedSeqCount = 1;
                    }
                }
            }

            Console.WriteLine(maxSeqCount);
        }
    }
}
