namespace MatrixOfPalindromes
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
         {
            int[] input = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

            string[,] letter = new string[input[0], input[1]];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int row = 0; row < input[0]; row++)
            {
                for (int col = 0; col < input[1]; col++)
                {
                    letter[row, col] = alphabet[row].ToString() + alphabet[row + col].ToString() + alphabet[row].ToString();
                }
            }

            for (int row = 0; row < letter.GetLength(0); row++)
            {
                for (int col = 0; col < letter.GetLength(1); col++)
                {
                    Console.Write(letter[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
