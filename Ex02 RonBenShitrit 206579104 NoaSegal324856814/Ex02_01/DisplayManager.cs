using System;
using Ex02.ConsoleUtils;

namespace Ex02_01
{
    internal class DisplayManager
    {
        public static void PrintBoard(Board i_currentBoard)
        {
            Screen.Clear();
            char[,] boardMatrix = i_currentBoard.GetBoard();
            Console.Write("  ");
            for(int i = 1; i <= boardMatrix.GetLength(0); i++)
            {
                Console.Write("{0}   ", i);
            }
            Console.WriteLine();
            //add clearing the screen first
            for (int row = 0; row < boardMatrix.GetLength(0); row++)
            {
                Console.Write("{0}|", row + 1);
                for (int column = 0; column < boardMatrix.GetLength(1); column++)
                {
                    Console.Write(" {0} |", boardMatrix[row, column]);
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
    }
}
