using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public class Player
    {
        public string[,] gameBoard;
        Destroyer destroyer;
        Submarine submarine;
        Battleship battleship;
        Carrier carrier;

        public Player()
        {            
            destroyer = new Destroyer();
            submarine = new Submarine();
            battleship = new Battleship();
            carrier = new Carrier();

        }

        public void GenerateInitialGameBoard()
        {
            gameBoard = new string[20, 20];
            for (int i = 0; i<20; i++)
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

        public void UpdateGameBoard(int location1, int location2, int location3, int location4, int size, int type)
        {
            Console.Clear();
            string newType = type.ToString();
            gameBoard[location1, location2] = newType;
            gameBoard[location3, location4] = newType;
            if (location1 == location3)
            {
                while (gameBoard[location1, location2 + 1] != newType)
                {
                    gameBoard[location1, location2 + 1] = newType;
                    location2++;
                }
            }
            else
            {
                while (gameBoard[location1 + 1, location2] != newType)
                {
                    gameBoard[location1 + 1, location2] = newType;
                    location1++;
                }
            }

            if (location1 + location2 - (location3 + location4) > size -1) 
            {
                
                Console.WriteLine("Youre boat can`t be longer than " + size + ", please place again.");
                Console.ReadLine();
            }
            else if((location3 + location4) - (location1 + location2) > size -1)
            {
                Console.WriteLine("Youre boat can`t be longer than " + size + ", please place again.");
                Console.ReadLine();
            }


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
