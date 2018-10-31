namespace GroupNumber
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

            int[] sizes = new int[3];

            foreach (var item in input)
            {
               sizes[Math.Abs(item % 3)]++;
            }

            int[][] allNum = new int[3][];

            for (int counter = 0; counter < sizes.Length; counter++)
            {
                allNum[counter] = new int[sizes[counter]];
            }

            int[] index = new int[3];
            foreach (var item in input)
            {
                var remainder = Math.Abs(item % 3);
                allNum[remainder][index[remainder]] = item;
                index[remainder]++;
            }

            for (int row = 0; row < allNum.Length; row++)
            {
                for (int col = 0; col < allNum[row].Length; col++)
                {
                    Console.Write(allNum[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
