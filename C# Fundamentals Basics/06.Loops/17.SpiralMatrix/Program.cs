using System;

namespace _17.SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new int[matrixSize, matrixSize];

            // variant one fill 1..N*N L->R->B->T->.. for matrix[y,x] as a shrinking border
            var startBorderIn = 0;
            var endBorderOut = matrixSize;
            var indexer = 1;
            while (endBorderOut - startBorderIn > 0)
            {
                // right
                for (int toRight = startBorderIn; toRight < endBorderOut; toRight++)
                {
                    matrix[startBorderIn, toRight] = indexer++;
                }

                // bottom
                for (int toBottom = startBorderIn + 1; toBottom < endBorderOut; toBottom++)
                {
                    matrix[toBottom, endBorderOut - 1] = indexer++;
                }

                // TODO: left + up - problem
                // left 
                for (int toLeft = endBorderOut - 2; toLeft >= startBorderIn; toLeft--)
                {
                    matrix[endBorderOut - 1, toLeft] = indexer++;
                }

                // up
                for (int toTop = endBorderOut - 2; toTop > startBorderIn; toTop--)
                {
                    matrix[toTop, startBorderIn] = indexer++;
                }

                // matrix border size shrink
                startBorderIn++;
                endBorderOut--;
            }

            PrintCompleteMatrix(matrix);
        }

        static void PrintCompleteMatrix(int[,] matrix)
        {
            // printing the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}