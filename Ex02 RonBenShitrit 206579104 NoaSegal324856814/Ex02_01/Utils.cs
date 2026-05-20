using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_01
{
    internal static class Utils
    {
        public static char ConvertEnumToString(ePlayerSymbol? i_Symbol)
        {
            char chSymbol = ' ';
            if ((int)i_Symbol == 1)
            {
                chSymbol = 'X';
            }
            else
            {
                if((int)i_Symbol == 2)
                {
                    chSymbol = 'O';
                }
            }
            
            return chSymbol;
        }
    }
}
