using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_01
{
    internal class GameManager
    {
        private Board m_GameBoard;
        private eGameType m_GameType = 0;
        private static bool s_QuitGame = false;

        public static bool QuitGame
        {
            get 
            {
                return s_QuitGame;
            }
            set
            {
                s_QuitGame = value;
            }
        }


        public void StartGame()
        {
            int boardSize = InputManager.GetBoardSize();
            if (!s_QuitGame)
            {
                m_GameBoard = new Board(boardSize);
                int tempGameType = InputManager.GetGameType();
                Player player1 = new Player(ePlayerSymbol.O);
                Player player2 = new Player(ePlayerSymbol.X);
                AIPlayer playerAI = new AIPlayer();
                if (!s_QuitGame)
                {
                    m_GameType = (eGameType)tempGameType;
                    bool playGame = true;
                    while (playGame)
                    {
                        if (m_GameType == eGameType.player)
                        {
                            RunTwoPlayers(player1, player2);
                        }
                        else
                        {
                            RunPlayerVsComputer(player1, playerAI);
                        }
                        if (!s_QuitGame)
                        {
                            playGame = InputManager.AnotherGame();
                            m_GameBoard = new Board(boardSize);
                        }
                        else
                        {
                            playGame = false;
                        }
                    }
                }
            }
        }

        public void RunPlayerVsComputer(Player player1, AIPlayer player2)
        {
            ePlayerSymbol? gameWinner = null;
            bool isBoardFull = false;
            DisplayManager.PrintBoard(m_GameBoard);
            while (!s_QuitGame && gameWinner == null && !isBoardFull)
            {
                if(!UpdatePlayerMoveOnBoard(player1, 1))
                {
                    DisplayManager.PrintBoard(m_GameBoard);
                    gameWinner = m_GameBoard.GetGameWinner();
                    isBoardFull = m_GameBoard.IsBoardFull();

                    if (gameWinner == null && !isBoardFull)
                    {
                        UpdateAIPlayerMoveOnBoard(player2, 2);
                        DisplayManager.PrintBoard(m_GameBoard);
                        gameWinner = m_GameBoard.GetGameWinner();
                        isBoardFull = m_GameBoard.IsBoardFull();
                    }
                }
                
            }
            if (gameWinner == ePlayerSymbol.O)
            {
                player1.IncreaseScore();
            }
            else
            {
                player2.IncreaseScore();
            }
            DisplayManager.PrintEndScreen(gameWinner, s_QuitGame);
            if (!s_QuitGame)
            {
                DisplayManager.PrintScore(player1.Score, player2.score, "Computer");
            }
        }
        public void RunTwoPlayers(Player player1, Player player2)
        {
            ePlayerSymbol? gameWinner = null;
            bool isBoardFull = false;
            DisplayManager.PrintBoard(m_GameBoard);
            while (!s_QuitGame && gameWinner ==null && !isBoardFull)
            {
                if (!UpdatePlayerMoveOnBoard(player1, 1))
                {
                    DisplayManager.PrintBoard(m_GameBoard);
                    gameWinner = m_GameBoard.GetGameWinner();
                    isBoardFull = m_GameBoard.IsBoardFull();

                    if (gameWinner == null && !isBoardFull)
                    {
                        if (!UpdatePlayerMoveOnBoard(player2, 2))
                        {
                            DisplayManager.PrintBoard(m_GameBoard);
                            gameWinner = m_GameBoard.GetGameWinner();
                            isBoardFull = m_GameBoard.IsBoardFull();
                        }
                    }
                }
                
            }

            if(gameWinner == ePlayerSymbol.O)
            {
                player1.IncreaseScore();
            }
            else
            {
                player2.IncreaseScore();
            }
            
            DisplayManager.PrintEndScreen(gameWinner, s_QuitGame);
            if (!s_QuitGame)
            {
                DisplayManager.PrintScore(player1.Score, player2.Score, "Player 2");
            }
        }

        public bool UpdatePlayerMoveOnBoard(Player i_Player, int i_NumOfPlayer)
        {
            bool isQuit = false;
            InputManager.GetPosition(i_NumOfPlayer, m_GameBoard.BoardSize, out int numInRow, out int numInCol);
            if (numInCol != -1 &&  numInRow != -1)
            {
                Move placeInMatPlayer1 = new Move(numInRow - 1, numInCol - 1);

                while (!m_GameBoard.CheckValidMove(placeInMatPlayer1) && !isQuit)
                {
                    DisplayManager.PrintInvalidCellMessage();
                    InputManager.GetPosition(i_NumOfPlayer, m_GameBoard.BoardSize, out numInRow, out numInCol);
                    if (numInCol != -1 && numInRow != -1)
                    {
                        placeInMatPlayer1 = new Move(numInRow - 1, numInCol - 1);
                    }
                    else
                    {
                        isQuit = true;
                    }
                }
                m_GameBoard.UpdateMove(placeInMatPlayer1, i_Player.Symbol);
            }
            else
            {
                isQuit = true;
            }
            return isQuit;
        }

        public void UpdateAIPlayerMoveOnBoard(AIPlayer i_Player, int i_NumberOfPlayer)
        {
            Move placeOnBoard = i_Player.generateRandomMove(m_GameBoard);
            m_GameBoard.UpdateMove(placeOnBoard, i_Player.symbol);
        }
    }

    
}
