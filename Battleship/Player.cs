using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Player
    {
        public string[,] gameBoard;
        Destroyer destroyer;
        Submarine submarine;
        Battleship battleship;
        Carrier carrier;

        public Player()
        {
            gameBoard = new string[20, 20];
            Destroyer destroyer;
            Submarine submarine;
            Battleship battleship;
            Carrier carrier;

        }

        public void GenerateInitialGameBoard()
        {
            for(int i = 0; i<20; i++)
            {
                for(int j = 0; j<20; j++)
                {
                    gameBoard[i, j] = ".";
                    Console.Write(gameBoard[i,j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }

        public void UpdateGameBoard(int location1, int location2)
        {
            gameBoard[location1, location2] = "S";

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {                    
                    Console.Write(gameBoard[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
