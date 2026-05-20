namespace Ex02_01
{
    public enum ePlayerSymbol
    {
        Space, X, O
    }

    internal class Player
    {
        private ePlayerSymbol m_Symbol;
        private int m_Score;
        public int Score
        {
            get
            {
                return m_Score;
            }
            set
            {
                m_Score = value;
            }
        }
        
        public ePlayerSymbol Symbol
        {
            get
            {
                return m_Symbol;
            }
            set
            {
                m_Symbol = value;
            }
        }
        public Player(ePlayerSymbol symbol)
        {
            m_Symbol = symbol;
            m_Score = 0;
        }
        public void IncreaseScore()
        {
            m_Score += 1;
        }

        public void GetNextMove()
        {
            // call input function
        }

    }
}
