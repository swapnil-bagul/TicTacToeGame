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
        public static void PlayerChoosing()
        {
            string player;
            string computer;

            Console.WriteLine("Choose X or O to for playing the game");
            player = Convert.ToString(Console.ReadLine()).ToUpper ();

            if (player == "O")
            {
                computer = "X";
                Console.WriteLine("Computer : " + computer);
            }
            else if (player == "X")
            {
                computer = "O";
                Console.WriteLine("Computer : " + computer);
            }
                
        }
    }
}
