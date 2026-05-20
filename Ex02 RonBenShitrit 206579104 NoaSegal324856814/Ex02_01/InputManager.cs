using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_01
{
    public enum eGameType
    {
        player = 0,
        computer = 1
    }

    public static class InputManager
    {
        
        public static int GetBoardSize()
        {
            return CheckIfValidNumberWithCondition("Enter size of board: ", 3, 9, out bool isQuit);
        }



        public static int CheckIfValidNumberWithCondition(string i_text, int i_min, int i_max, out bool o_isQuit)
        {
            Console.WriteLine(i_text);
            string input = Console.ReadLine();
            int validOutput = -1;
            bool exit = false;
            if (CheckIfQ(input))
            {
                exit = true;
            }
            if (!exit)
            {
                while (!int.TryParse(input, out validOutput) || validOutput < i_min || validOutput > i_max)
                {
                    Console.WriteLine("Invalid input, try again");
                    input = Console.ReadLine();
                }
            }
            
            o_isQuit = exit;
            return validOutput;
        }

        public static void GetPosition(int i_playerNum,int io_boardSize, out int o_numInRow, out int o_numInColumn)
        {
            o_numInRow = -1;
            o_numInRow = CheckIfValidNumberWithCondition($"Player number {i_playerNum}, please enter row number: ", 1, io_boardSize, out bool isQuit);
            o_numInColumn = -1;
            if (!isQuit)
            {
                o_numInColumn = CheckIfValidNumberWithCondition("Please enter column number: ", 1, io_boardSize, out isQuit);
            }
        }

        public static int GetGameType()
        {
            Console.WriteLine("What game do you want to play?");
            return CheckIfValidNumberWithCondition("Enter 0 for two players and 1 for player vs computer", 0, 1, out bool isQuit);
        }

        public static bool AnotherGame()
        {
            bool result = false;
            int numInput = CheckIfValidNumberWithCondition("Do you want to play again? enter 0 for another game and 1 to exit", 0, 1, out bool isQuit);
            if(numInput == 0 || !isQuit)
            {
                result = true;
            }
            return result;
        }

        public static bool CheckIfQ(string i_strInput)
        {
            bool exit = false;
            if (i_strInput.ToLower() == "q")
            {
                GameManager.QuitGame = true;
                exit = true;
            }
            return exit;
        }
    }

}
