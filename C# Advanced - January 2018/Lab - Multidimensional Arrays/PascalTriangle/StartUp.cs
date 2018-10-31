namespace PascalTriangle
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            long countTriangle = long.Parse(Console.ReadLine());

            long[][] num = new long[countTriangle][];

            for (long currentHeight = 0; currentHeight < countTriangle; currentHeight++)
            {
                num[currentHeight] = new long[currentHeight + 1];
                num[currentHeight][0] = 1;
                num[currentHeight][currentHeight] = 1;

                if (currentHeight >= 2)
                {
                    for (long widthCounter = 1; widthCounter < currentHeight; widthCounter++)
                    {
                        num[currentHeight][widthCounter] =
                            num[currentHeight - 1][widthCounter - 1] +
                            num[currentHeight - 1][widthCounter];
                    }
                }
            }
            for (long row = 0; row < num.Length; row++)
            {
                for (long col = 0; col < num[row].Length; col++)
                {
                    Console.Write(num[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
