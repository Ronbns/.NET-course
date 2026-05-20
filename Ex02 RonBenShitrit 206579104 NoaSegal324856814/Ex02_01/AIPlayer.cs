using System;
using System.Collections.Generic;

namespace Ex02_01

{
    internal class AIPlayer
    {
        private ePlayerSymbol m_symbol;
        private int m_score;

        public ePlayerSymbol symbol
        {
            get 
            { 
                return m_symbol; 
            }
            set
            {
            }
        }
        public int score
        {
            get
            {
                return m_score;
            }
            set
            {
            }
        }


        public AIPlayer()
        {
            m_symbol = ePlayerSymbol.X;
            m_score = 0;
        }

        public Move generateRandomMove(Board i_GameBoard)
        {
            List<Move> availableMoves = i_GameBoard.GetAllAvailableMoves();
            Random rand = new Random();
            int randIndex = rand.Next(availableMoves.Count);
            return availableMoves[randIndex];
        }
        public void IncreaseScore()
        {
            m_score += 1;
        }
    }
}
