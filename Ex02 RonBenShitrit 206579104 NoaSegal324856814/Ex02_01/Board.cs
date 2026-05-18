using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_01
{
    internal class Board
    {
        char[,] m_board;
        int m_BoardSize;

        public Board()
        {
            m_BoardSize = InputManager.GetBoardSize();
            m_board = new char[m_BoardSize, m_BoardSize];
            for(int row = 0; row < m_BoardSize; row++)
            {
                for(int column = 0; column < m_BoardSize; column++)
                {
                    m_board[row, column] = ' ';
                }
            }
        }

        public char[,] GetBoard()
        {
            return m_board;
        }
    }
}
