using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_01
{
    internal class DisplayManager
    {
        public static void PrintBoard(int[,] i_board)
        {
            //add clearing the screen first
            for (int row = 0; row < i_board.GetLength(0); row++)
            {
                for(int column = 0; column < i_board.GetLength(1); column++)
                {

                }
            }
            /**
              1 2 3 4 5 
            1|   |   |   |   |   |
            ======================
            2|   |   |   |   |   |
            =====================
            3|   |   |   |   |   |
            =====================
            4|   |   |   |   |   |
            =====================
            5|   |   |   |   |   |
            =====================

             **/
        }
    }
}
