namespace SquareWithMaximumSum
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                          .Split(new string[] { ", " }, StringSplitOptions.None)
                          .Select(int.Parse)
                          .ToArray();

            int[,] number = new int[input[0], input[1]];

            for (int row = 0; row < input[0]; row++)
            {
                int[] square = Console.ReadLine()
                               .Split(new string[] { ", " }, StringSplitOptions.None)
                               .Select(int.Parse)
                               .ToArray();

                for (int col = 0; col < input[1]; col++)
                {
                    number[row, col] = square[col];
                }
            }

            int sum = 0;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < number.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < number.GetLength(1) - 1; col++)
                {
                    int max = (number[row, col]+ number[row, col + 1]) + 
                          (number[row + 1, col] + number[row + 1, col + 1]);

                    if (max > sum)
                    {
                        sum = max;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine(number[maxRow, maxCol] + " " + number[maxRow, maxCol + 1]);
            Console.WriteLine(number[maxRow + 1, maxCol] + " " + number[maxRow + 1, maxCol + 1]);
            Console.WriteLine(sum);
        }
    }
}
