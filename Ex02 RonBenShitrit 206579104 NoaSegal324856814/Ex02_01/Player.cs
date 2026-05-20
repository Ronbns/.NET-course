namespace Ex02_01
{
    public enum ePlayerSymbol
    {
        Space, X, O
    }

    internal class Player
    {
        private ePlayerSymbol m_symbol
        {
            get 
            {
                return m_symbol;
            }
            set
            {
                m_symbol = value;
            }
        }
        private int m_score
        {
            get
            {
                return m_score;
            }
            set
            {
                m_score = value;
            }
        }

        public void IncreaseScore()
        {
            m_score += 1;
        }

        public void GetNextMove()
        {
            // call input function
        }

    }
}
