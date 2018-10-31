using System;
using System.Linq;

namespace DiagaonalDifference
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());

            long[,] diagonal = new long[input, input];

            for (long row = 0; row < input; row++)
            {
                long[] n = Console.ReadLine()
                          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(long.Parse)
                          .ToArray();

                for (long col = 0; col < input; col++)
                {
                    diagonal[row, col] = n[col];
                }
            }

            long sumFirstDiagonal = diagonal[0, 0] + diagonal[input - 1, input - 1];
            long sumSecondDiagonal = diagonal[input - 1, 0] + diagonal[0, input - 1];

            for (long row = 1; row < input - 1; row++)
            {
                sumFirstDiagonal += diagonal[row, row];
            }

            for (long row = 1; row < input - 1; row++)
            {
                sumSecondDiagonal += diagonal[row, input - row - 1];
            }

            Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));
        }
    }
}
