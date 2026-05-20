namespace Ex02_01
{
    internal static class Utils
    {
        public static char ConvertEnumToChar(ePlayerSymbol? i_Symbol)
        {
            char symbolChar = ' ';

            if (i_Symbol == ePlayerSymbol.X)
            {
                symbolChar = 'X';
            }
            else if (i_Symbol == ePlayerSymbol.O)
            {
                symbolChar = 'O';
            }
            
            return symbolChar;
        }
    }
}
