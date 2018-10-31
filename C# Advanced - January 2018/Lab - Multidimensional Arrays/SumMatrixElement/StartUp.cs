namespace SumMatrixElement
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

            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < input[0]; row++)
            {
                int[] digit = Console.ReadLine()
                              .Split(new string[] { ", " }, StringSplitOptions.None)
                              .Select(int.Parse)
                              .ToArray();

                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = digit[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
