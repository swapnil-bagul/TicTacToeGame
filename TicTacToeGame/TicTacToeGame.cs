using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToeGameClass
    {
        public static void AssignEmptySpace()
        {
            char[] space = new char[10];

            for (int i = 1; i < 10; i++)
            {
                space[i] = ' ';
            }   
        }
    }
}
