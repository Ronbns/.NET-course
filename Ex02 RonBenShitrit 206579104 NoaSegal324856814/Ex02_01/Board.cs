using System.Collections.Generic;
namespace Ex02_01
{
    internal class Board
    {
        public int m_boardSize;
        public ePlayerSymbol?[,] m_board;    
        public Board(int i_boardSize)
        {
            m_boardSize = i_boardSize;
            m_board = new ePlayerSymbol?[i_boardSize, i_boardSize];
        }

        public List<Move> GetAllAvailableMoves()
        {
            List<Move> availableMoves = new List<Move>();
            for (int i = 0; i < m_boardSize; i++)
            {
                for (int j = 0; j < m_boardSize; j++)
                {
                    if (m_board[i, j] == null)
                    {
                        Move availableMove = new Move(i, j);
                        availableMoves.Add(availableMove);
                    }
                }
            }
            return availableMoves;
        }
        public bool CheckValidMove(Move i_move)
        {
            return m_board[i_move.m_row, i_move.m_col] == null;
        }

        public void UpdateMove(Move i_move, ePlayerSymbol playerSymbol)
        {
            if (CheckValidMove(i_move))
            {
                m_board[i_move.m_row, i_move.m_col] = playerSymbol;
            }
        }

        public void DeleteMove(Move i_move)
        {
            m_board[i_move.m_row, i_move.m_col] = null;
        }

        public ePlayerSymbol? GetGameWinner()
        {
            ePlayerSymbol? gameWinner = null;
            if (HasDiagonalOf(ePlayerSymbol.X) || HasColumnOf(ePlayerSymbol.X) || HasRowOf(ePlayerSymbol.X))
            {
                gameWinner = ePlayerSymbol.O;
            }
            if (HasDiagonalOf(ePlayerSymbol.O) || HasColumnOf(ePlayerSymbol.O) || HasRowOf(ePlayerSymbol.O))
            {
                gameWinner = ePlayerSymbol.X;
            }
            return gameWinner;
        }
        public bool IsBoardFull()
        {
            int filledCells = 0;
            for (int i = 0; i < m_boardSize; i++)
            {
                for (int j = 0; j < m_boardSize; j++)
                {
                    if (m_board[i, j] != null)
                    {
                        filledCells++;
                    }
                }
            }
            return (filledCells == m_boardSize*m_boardSize);
        }

        public bool HasRowOf(ePlayerSymbol i_playerSymbol)
        {
            for (int i = 0; i < m_boardSize;  i++)
            {
                bool hasRowOf = true;
                for (int j = 0 ; j < m_boardSize; j++)
                { 
                    if (m_board[i, j] != i_playerSymbol)
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
            for (int i = 0; i < m_boardSize; i++)
            {
                bool HasColumnOf = true;
                for (int j = 0; j < m_boardSize; j++)
                {
                    if (m_board[j,i] != i_playerSymbol)
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

            for (int i = 0; i < m_boardSize ; i++)
            {
                if (m_board[i,i] != i_playerSymbol)
                {
                    hasLeftDiagonalOf = false;
                }
            }
            for (int i = 0; i < m_boardSize; i++)
            {
                if (m_board[i, m_boardSize - 1 - i] != i_playerSymbol)
                {
                    hasRightDiagonalOf = false;
                }
            }
            return hasLeftDiagonalOf || hasRightDiagonalOf;
        }
    }
}
