using System.Collections.Generic;

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

            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    m_GameBoard[i, j] = ePlayerSymbol.Space;
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
            return m_GameBoard[i_Move.m_Row, i_Move.m_Col] == ePlayerSymbol.Space;
        }

        public void UpdateMove(Move i_Move, ePlayerSymbol i_PlayerSymbol)
        {
            if (CheckValidMove(i_Move))
            {
                m_GameBoard[i_Move.m_Row, i_Move.m_Col] = i_PlayerSymbol;
            }
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

            return (filledCells == m_BoardSize * m_BoardSize);
        }

        public bool HasRowOf(ePlayerSymbol i_PlayerSymbol)
        {
            bool foundRow = false;

            for (int i = 0; i < m_BoardSize; i++)
            {
                bool hasRowOf = true;

                for (int j = 0; j < m_BoardSize; j++)
                {
                    if (m_GameBoard[i, j] != i_PlayerSymbol)
                    {
                        hasRowOf = false;
                    }
                }

                if (hasRowOf)
                {
                    foundRow = true;
                }
            }

            return foundRow;
        }

        public bool HasColumnOf(ePlayerSymbol i_PlayerSymbol)
        {
            bool foundCol = false;

            for (int i = 0; i < m_BoardSize; i++)
            {
                bool hasColumnOf = true;

                for (int j = 0; j < m_BoardSize; j++)
                {
                    if (m_GameBoard[j, i] != i_PlayerSymbol)
                    {
                        hasColumnOf = false;
                    }
                }

                if (hasColumnOf)
                {
                    foundCol = true;
                }
            }

            return foundCol;
        }

        public bool HasDiagonalOf(ePlayerSymbol i_PlayerSymbol)
        {
            bool hasLeftDiagonalOf = true;
            bool hasRightDiagonalOf = true;

            for (int i = 0; i < m_BoardSize; i++)
            {
                if (m_GameBoard[i, i] != i_PlayerSymbol)
                {
                    hasLeftDiagonalOf = false;
                }
            }

            for (int i = 0; i < m_BoardSize; i++)
            {
                if (m_GameBoard[i, m_BoardSize - 1 - i] != i_PlayerSymbol)
                {
                    hasRightDiagonalOf = false;
                }
            }

            return hasLeftDiagonalOf || hasRightDiagonalOf;
        }
    }
}