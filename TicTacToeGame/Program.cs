﻿using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            TicTacToeGameClass.AssignEmptySpace();
            TicTacToeGameClass.PlayerChoosing();
        }
    }
}
