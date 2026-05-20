using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_01
{
    class Program
    {
        public static void Main()
        {
            //InputManager.GetBoardSize();
            //InputManager.GetPosition(1, 5, out int numrow, out int numcol);
            //Console.Write("the num of row is: {0}, the num of column is: {1}", numrow, numcol);


            char[,] testBoard = new char[4, 4]
               {
                { 'x', 'o', ' ', 'x' },
                { ' ', 'x', 'o', ' ' },
                { 'o', ' ', 'x', 'o' },
                { 'x', ' ', ' ', 'o' }
            };

            Board dummyBoard = new Board();
            DisplayManager.PrintBoard(dummyBoard);

        }

    }
}
