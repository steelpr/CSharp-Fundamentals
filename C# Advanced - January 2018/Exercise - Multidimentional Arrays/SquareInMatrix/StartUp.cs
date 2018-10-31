namespace SquareInMatrix
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rowAndColum = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            string[,] square = new string[rowAndColum[0], rowAndColum[1]];

            for (int row = 0; row < rowAndColum[0]; row++)
            {
                string[] digit = Console.ReadLine()
                              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .ToArray();

                for (int col = 0; col < rowAndColum[1]; col++)
                {
                    square[row, col] = digit[col];
                }
            }

            int counter = 0;
            for (int row = 0; row < rowAndColum[0] - 1; row++)
            {
                for (int col = 0; col < rowAndColum[1] - 1; col++)
                {
                    bool firstIsTrue = square[row, col] == square[row, col + 1];
                    bool seconIsTrue = square[row + 1, col] == square[row + 1, col + 1];
                    bool firstColumn = square[row, col] == square[row + 1, col];
                    bool secondColumn = square[row, col + 1] == square[row + 1, col + 1];

                    if (firstIsTrue == true && seconIsTrue == true && firstColumn == true && secondColumn == true)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
