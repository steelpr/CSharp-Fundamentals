namespace dongerousFloor
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            string[,] floor = new string[8, 8];

            string indexed = string.Empty;


            for (int row = 0; row < 8; row++)
            {
                string[] input = Console.ReadLine()
                                    .Split(new char[] { ',' }, StringSplitOptions.None)
                                    .ToArray();
                for (int col = 0; col < 8; col++)
                {
                    floor[row, col] = input[col];
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] index = command.Split('-');

                string concatIndex = index[0] + index[1];

                char[] concatIndexToCharArray = concatIndex.ToCharArray();

                string step = concatIndexToCharArray[0].ToString();

                int firstRow = int.Parse(concatIndexToCharArray[1].ToString());
                int FirstCol = int.Parse(concatIndexToCharArray[2].ToString());
                int secondRow = int.Parse(concatIndexToCharArray[3].ToString());
                int secondCol = int.Parse(concatIndexToCharArray[3].ToString());


                if (secondRow > 7 || secondCol > 7)
                {
                    Console.WriteLine("Move go out of board!");
                }
                else if (floor[firstRow, FirstCol] == "x")
                {
                    {
                        Console.WriteLine("There is no such a piece!");
                    }
                }

                else if (step == "K")
                {
                    if (King(firstRow, FirstCol, secondRow, secondCol) == false)
                    {
                        Console.WriteLine("Invalid move!");
                    }
                    else
                    {
                        floor[firstRow, FirstCol] = "x";
                        floor[secondRow, secondCol] = "K";
                    }
                }
                else if (step == "P")
                {
                    if (Knight(firstRow, FirstCol, secondRow, secondCol) == false)
                    {
                        Console.WriteLine("Invalid move!");
                    }
                    else
                    {
                        floor[firstRow, FirstCol] = "x";
                        floor[secondRow, secondCol] = "P";
                    }
                }
            }

        }
        static bool Knight(int firstRow, int firstCol, int secondRow, int secondCol)
        {
            bool isTrue = false;
            if (firstRow - 1 == secondRow && firstCol == secondCol)
            {
                isTrue = true;
            }
            return isTrue;
        }

        static bool King(int firstRow, int firstCol, int secondRow, int secondCol)
        {
            bool isTrue = false;
            if (firstRow - 1 == secondRow && firstCol == secondCol || firstRow + 1 == secondRow && firstCol == secondCol ||
                firstRow == secondRow && firstCol - 1 == secondCol || firstRow == secondRow && firstCol + 1 == secondCol ||
                firstRow + 1 == secondRow && firstCol + 1 == secondCol || firstRow + 1 == secondRow && firstCol - 1 == secondCol ||
                firstRow - 1 == secondRow && firstCol - 1 == secondCol || firstRow - 1 == secondRow && firstRow + 1 == secondCol)
            {

                isTrue = true;
            }
            return isTrue;
        }
    }
}
