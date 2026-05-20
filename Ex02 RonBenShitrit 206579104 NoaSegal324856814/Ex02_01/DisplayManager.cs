using System;
using Ex02.ConsoleUtils;

namespace Ex02_01
{
    internal class DisplayManager
    {
        public static void PrintBoard(Board i_currentBoard)
        {
            Screen.Clear();
            ePlayerSymbol[,] boardMatrix = i_currentBoard.GameBoard;
            Console.Write("  ");
            for(int i = 1; i <= boardMatrix.GetLength(0); i++)
            {
                Console.Write("{0}   ", i);
            }
            Console.WriteLine();
            for (int row = 0; row < boardMatrix.GetLength(0); row++)
            {
                Console.Write("{0}|", row + 1);
                for (int column = 0; column < boardMatrix.GetLength(1); column++)
                {
                    Console.Write(" {0} |", Utils.ConvertEnumToString(boardMatrix[row, column]));
                }
                Console.WriteLine();
                Console.Write("==");
                for (int column = 0; column < boardMatrix.GetLength(1); column++)
                {
                    Console.Write("====");
                }
                Console.WriteLine();
            }
        }

        public static void PrintInvalidCellMessage()
        {
            Console.WriteLine("Invalid point in board, please pick an empty spot");
        }

        public static void PrintEndScreen(ePlayerSymbol? i_GameWinner, bool i_isQuit)
        {
            Screen.Clear();
            if (i_isQuit)
            {
                Console.WriteLine("Bye bye");
            }
            else if (i_GameWinner == null)
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine("player {0} won! Congratulations!", Utils.ConvertEnumToString(i_GameWinner));
            }
        }

        

        public static void PrintScore(int i_ScorePlayer1, int i_ScorePlayer2, string i_Message)
        {
            Console.WriteLine("Player 1 score: {0}", i_ScorePlayer1);
            Console.WriteLine("{0} score: {1}",i_Message, i_ScorePlayer2);
        }
    }
}
