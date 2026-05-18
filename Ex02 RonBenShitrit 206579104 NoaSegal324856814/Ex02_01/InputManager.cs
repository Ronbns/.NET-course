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
            return CheckIfValidNumberWithCondition("Enter size of board: ", 3, 9);
        }



        public static int CheckIfValidNumberWithCondition(string i_text, int i_min, int i_max)
        {
            Console.WriteLine(i_text);
            string input = Console.ReadLine();
            int validOutput;
            while(!int.TryParse(input, out validOutput) || validOutput < i_min ||validOutput > i_max)
            {
                Console.WriteLine("Invalid input, try again");
                input = Console.ReadLine();
            }
            return validOutput;
        }

        public static void GetPosition(int i_playerNum,int io_boardSize, out int o_numInRow, out int o_numInColumn)
        {
            o_numInRow = CheckIfValidNumberWithCondition($"Player number {i_playerNum}, please enter row number: ", 1, io_boardSize);
            o_numInColumn = CheckIfValidNumberWithCondition("Please enter column number: ", 1, io_boardSize);
        }

        public static eGameType GetGameType()
        {
            Console.WriteLine("What game do you want to play?");
            return (eGameType)CheckIfValidNumberWithCondition("Enter 0 for two players and 1 for player vs computer", 0, 1);
        }
    }

}
