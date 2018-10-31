namespace MaximalSum
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


            int[,] sumDigit = new int[rowAndColum[0], rowAndColum[1]];
            for (int height = 0; height < rowAndColum[0]; height++)
            {
                int[] number = Console.ReadLine()
                               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

                for (int addNumber = 0; addNumber < rowAndColum[1]; addNumber++)
                {
                    sumDigit[height, addNumber] = number[addNumber];
                }
            }

            int sum = 0;
            int maxIndex = 0;
            int maximumCurrent = 0;

            for (int height = 0; height < sumDigit.GetLength(0) - 2; height++)
            {
                for (int weigth = 0; weigth < sumDigit.GetLength(1) - 2; weigth++)
                {
                    int maxSum = sumDigit[height, weigth] + sumDigit[height, weigth + 1] +
                        sumDigit[height, weigth + 2];
                    int sumNumber = sumDigit[height + 1, weigth] + sumDigit[height + 1, weigth + 1] +
                        sumDigit[height + 1, weigth + 2];
                    int nextSum = sumDigit[height + 2, weigth] + sumDigit[height + 2, weigth + 1] + 
                        sumDigit[height + 2, weigth + 2];
                    int total = maxSum + sumNumber + nextSum;

                    if (total > sum)
                    {
                        sum = total;
                        maxIndex = height;
                        maximumCurrent = weigth;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");

            Console.WriteLine(sumDigit[maxIndex, maximumCurrent] + " " +
                sumDigit[maxIndex, maximumCurrent + 1] + " " +
                sumDigit[maxIndex, maximumCurrent + 2]);

            Console.WriteLine(sumDigit[maxIndex + 1, maximumCurrent] + " " +
                sumDigit[maxIndex + 1, maximumCurrent + 1] + " " +
                sumDigit[maxIndex + 1, maximumCurrent + 2]);

            Console.WriteLine(sumDigit[maxIndex + 2, maximumCurrent] + " " +
                sumDigit[maxIndex + 2, maximumCurrent + 1] + " " +
                sumDigit[maxIndex + 2, maximumCurrent + 2]);
        }
    }
}
