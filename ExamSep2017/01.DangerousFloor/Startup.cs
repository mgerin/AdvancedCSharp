namespace _01.DangerousFloor
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static string[][] chessBoard = new string[8][];

        public static void Main()
        {
            for (int i = 0; i < 8; i++)
            {
                chessBoard[i] = new string[8];
                chessBoard[i] = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                string result = CheckTurn(inputLine);
                if (result.Length > 0)
                {
                    Console.WriteLine(result);
                }
            }
        }

        private static string CheckTurn(string inputLine)
        {
            bool isValid = false;
            int resultRow = 0;
            int resultCol = 0;

            string symbol = inputLine[0].ToString();
            int currentRow = int.Parse(inputLine[1].ToString());
            int currentCol = int.Parse(inputLine[2].ToString());
            int moveRow = int.Parse(inputLine[4].ToString());
            int moveCol = int.Parse(inputLine[5].ToString());

            // Existing check
            if (chessBoard[currentRow][currentCol] != symbol)
            {
                return "There is no such a piece!";
            }

            // Invalid move check
            resultRow = Math.Abs(currentRow - moveRow);
            resultCol = Math.Abs(currentCol - moveCol);

            switch (symbol)
            {
                case "K":
                    if ((resultRow <= 1 && resultCol <= 1) && (resultRow + resultCol) != 0)
                    {
                        isValid = true;
                    }

                    break;
                case "R":
                    if ((resultRow >= 1 && resultCol == 0) || (resultRow == 0 && resultCol >= 1))
                    {
                        isValid = true;
                    }

                    break;
                case "B":
                    if (resultRow == resultCol)
                    {
                        isValid = true;
                    }

                    break;
                case "Q":
                    if ((resultRow >= 1 && resultCol == 0) || (resultRow == 0 && resultCol >= 1) || resultRow == resultCol)
                    {
                        isValid = true;
                    }

                    break;
                case "P":
                    if ((currentCol == moveCol) && (currentRow - moveRow == 1))
                    {
                        isValid = true;
                    }

                    break;
                default: return "There is no such a piece!";
            }

            // If move goes out of board
            if (moveRow > 7 || moveCol > 7)
            {
                return "Move go out of board!";
            }

            // Make move
            if (isValid)
            {
                chessBoard[currentRow][currentCol] = "x";
                chessBoard[moveRow][moveCol] = symbol;
                return string.Empty;
            }

            return "Invalid move!";
        }
    }
}