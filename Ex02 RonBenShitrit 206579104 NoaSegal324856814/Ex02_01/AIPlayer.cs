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
        //public Move FindBestMove(Board i_board)
        //{
        //    int bestScore = int.MinValue;
        //    Move bestMove = null;
        //    List<Move> availableMoves = i_board.GetAllAvailableMoves();
        //    foreach (Move move in availableMoves)
        //    {
        //        i_board.UpdateMove(move, m_symbol);
        //        int score = Minimax(i_board, 0, ePlayerSymbol.O);
        //        i_board.DeleteMove(move);
        //        if (score > bestScore)
        //        {
        //            bestScore = score;
        //            bestMove = move;
        //        }
        //    }
        //    return bestMove;
        //}
        //public int Minimax(Board i_board, int i_step, ePlayerSymbol i_CurrentTurnPlayerSymbol)
        //{
        //    ePlayerSymbol? gamerWinner = i_board.GetGameWinner();
        //    if (gamerWinner == ePlayerSymbol.X)
        //    {
        //        return i_step-10;
        //    }
        //    if (gamerWinner == ePlayerSymbol.O)
        //    {
        //        return 10- i_step;
        //    }
        //    if (i_board.IsBoardFull())
        //    {
        //        return 0;
        //    }

        //    if (i_CurrentTurnPlayerSymbol == ePlayerSymbol.X)
        //    {
        //        int bestScore = int.MinValue;
        //        List<Move> availableMoves = i_board.GetAllAvailableMoves();
        //        foreach (Move move in availableMoves)
        //        {
        //            i_board.UpdateMove(move, i_CurrentTurnPlayerSymbol);
        //            int recursiveScore = Minimax(i_board, i_step + 1, ePlayerSymbol.O);
        //            i_board.DeleteMove(move);
        //            bestScore = Math.Max(bestScore, recursiveScore);
        //        }
        //        return bestScore;
        //    }
        //    else 
        //    {
        //        int bestScore = int.MaxValue;
        //        List<Move> availableMoves = i_board.GetAllAvailableMoves();
        //        foreach (Move move in availableMoves)
        //        {
        //            i_board.UpdateMove(move, i_CurrentTurnPlayerSymbol);
        //            int recursiveScore = Minimax(i_board,i_step + 1, ePlayerSymbol.X);
        //            i_board.DeleteMove(move);
        //            bestScore = Math.Min(bestScore, recursiveScore);
        //        }
        //        return bestScore;
        //    }
        //}
    }
}
