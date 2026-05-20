using System;
using System.Collections.Generic;

namespace Ex02_01
{
    internal class AIPlayer
    {
        private ePlayerSymbol m_Symbol;
        private int m_Score;

        public ePlayerSymbol Symbol
        {
            get 
            { 
                return m_Symbol; 
            }
            set
            {
            }
        }
        public int Score
        {
            get
            {
                return m_Score;
            }
            set
            {
            }
        }

        public AIPlayer()
        {
            m_Symbol = ePlayerSymbol.X;
            m_Score = 0;
        }

        public Move GenerateRandomMove(Board i_GameBoard)
        {
            List<Move> availableMoves = i_GameBoard.GetAllAvailableMoves();
            Random rand = new Random();
            int randIndex = rand.Next(availableMoves.Count);

            return availableMoves[randIndex];
        }
        public void IncreaseScore()
        {
            m_Score += 1;
        }
    }
}
