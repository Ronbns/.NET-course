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
        private int m_BoardSize;
        private ePlayerSymbol[,] m_GameBoard;


        public int BoardSize
        {
            get
            {
                return m_BoardSize;
            }
            set
            {
            }
        }


        public ePlayerSymbol[,] GameBoard
        {
            get 
            {  
                return m_GameBoard; 
            }
            set
            {
            }
        }


        public Board(int i_BoardSize)
        {
            m_BoardSize = i_BoardSize;
            m_GameBoard = new ePlayerSymbol[m_BoardSize, m_BoardSize];
            for (int row = 0; row < m_BoardSize; row++)
            {
                for (int column = 0; column < m_BoardSize; column++)
                {
                    m_GameBoard[row, column] = ePlayerSymbol.Space;
                }
            }
        }

        public List<Move> GetAllAvailableMoves()
        {
            List<Move> availableMoves = new List<Move>();
            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    if (m_GameBoard[i, j] == ePlayerSymbol.Space)
                    {
                        Move availableMove = new Move(i, j);
                        availableMoves.Add(availableMove);
                    }
                }
            }
            return availableMoves;
        }

        public bool CheckValidMove(Move i_Move)
        {
            return m_GameBoard[i_Move.m_row, i_Move.m_col] == ePlayerSymbol.Space;
        }

        public void UpdateMove(Move i_move, ePlayerSymbol playerSymbol)
        {
            if (CheckValidMove(i_move))
            {
                m_GameBoard[i_move.m_row, i_move.m_col] = playerSymbol;
            }
        }

        public void DeleteMove(Move i_move)
        {
            m_GameBoard[i_move.m_row, i_move.m_col] = ePlayerSymbol.Space;
        }

        public ePlayerSymbol? GetGameWinner()
        {
            ePlayerSymbol? gameWinner = null;
            if (HasDiagonalOf(ePlayerSymbol.X) || HasColumnOf(ePlayerSymbol.X) || HasRowOf(ePlayerSymbol.X))
            {
                gameWinner = ePlayerSymbol.O;
            }
            else if (HasDiagonalOf(ePlayerSymbol.O) || HasColumnOf(ePlayerSymbol.O) || HasRowOf(ePlayerSymbol.O))
            {
                    gameWinner = ePlayerSymbol.X;
            } 
            return gameWinner;
        }
        public bool IsBoardFull()
        {
            int filledCells = 0;
            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    if (m_GameBoard[i, j] != ePlayerSymbol.Space)
                    {
                        filledCells++;
                    }
                }
            }
            return (filledCells == m_BoardSize*m_BoardSize);
        }

        public bool HasRowOf(ePlayerSymbol i_playerSymbol)
        {
            for (int i = 0; i < m_BoardSize;  i++)
            {
                bool hasRowOf = true;
                for (int j = 0 ; j < m_BoardSize; j++)
                { 
                    if (m_GameBoard[i, j] != i_playerSymbol)
                    {
                        hasRowOf = false; 
                    }
                }
                if (hasRowOf)
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasColumnOf(ePlayerSymbol i_playerSymbol)
        {
            for (int i = 0; i < m_BoardSize; i++)
            {
                bool HasColumnOf = true;
                for (int j = 0; j < m_BoardSize; j++)
                {
                    if (m_GameBoard[j,i] != i_playerSymbol)
                    {
                        HasColumnOf = false;
                    }
                }
                if (HasColumnOf)
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasDiagonalOf(ePlayerSymbol i_playerSymbol)
        {
            bool hasLeftDiagonalOf = true;
            bool hasRightDiagonalOf = true;

            for (int i = 0; i < m_BoardSize ; i++)
            {
                if (m_GameBoard[i,i] != i_playerSymbol)
                {
                    hasLeftDiagonalOf = false;
                }
            }
            for (int i = 0; i < m_BoardSize; i++)
            {
                if (m_GameBoard[i, m_BoardSize - 1 - i] != i_playerSymbol)
        {
                    hasRightDiagonalOf = false;
                }
            }
            return hasLeftDiagonalOf || hasRightDiagonalOf;
        }
    }
}
