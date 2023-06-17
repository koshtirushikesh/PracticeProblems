using System;

namespace SamplePracticeProgram
{
    internal class TicTacToeGame
    {
        //Implement a program that simulates a tic-tac-toe game, using a 2D array to
        //represent the game board and allowing the user to make moves and check for
        //a winning condition.
        public void Disply()
        {
            Console.WriteLine("  1 |  2 |  3 ");
            Console.WriteLine("  4 |  5 |  6 ");
            Console.WriteLine("  7 |  8 |  9 ");
        }

        public void Play()
        {
            int[] possitionArrPlayer1 = new int[9];
            int[] possitionArrPlayer2 = new int[9];

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Enter possition for player 1: ");
                possitionArrPlayer1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Enter possition for player 2: ");
                possitionArrPlayer2[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
