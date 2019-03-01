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

        public void PlacePieces()
        {
            int[] location = new int[4];

            Console.WriteLine("Please enter the coordinates for your destroyer: ");
            location[0] = int.Parse(Console.ReadLine());
            location[1] = int.Parse(Console.ReadLine());
                    
            gameBoard[location[0], location[1]] = "+";
            if (gameBoard[location[0], location[1]] != ".")
            {
                Console.WriteLine("You already placed a boat in that location!");
                PlacePieces();
            }

            location[2] = int.Parse(Console.ReadLine());
            location[3] = int.Parse(Console.ReadLine());
            gameBoard[location[2], location[3]] = "+";
            if (gameBoard[location[2], location[3]] != ".")
            {
                Console.WriteLine("You already placed a boat in that location!");
                PlacePieces();
            }
            PieceFiller(location);

        }

        public void PieceFiller(int[] ArrayFiller)
        {
            Console.Clear();
            
            if (ArrayFiller[0] == ArrayFiller[2])
            {
                int i = 1;
                while (gameBoard[ArrayFiller[0], ArrayFiller[i] + 1] != "+")
                {
                   
                    gameBoard[ArrayFiller[0], ArrayFiller[i] + 1] = "+";
                    i++;
                   
                }
            }
            else
            {
                int i = 0;
                while (gameBoard[ArrayFiller[i] + 1, ArrayFiller[1]] != "+")
                {                   
                    gameBoard[ArrayFiller[i] + 1, ArrayFiller[1]] = "+";
                    i++;                
                }
            }

            if (location1 + location2 - (location3 + location4) > size - 1)
            {

                Console.WriteLine("Youre boat can`t be longer than " + size + ", please place again.");
                PlacePieces();
            }
            else if ((location3 + location4) - (location1 + location2) > size - 1)
            {
                Console.WriteLine("Youre boat can`t be longer than " + size + ", please place again.");
                PlacePieces();
            }


            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(player1.gameBoard[i, j] + " ");
                }
                Console.Write("\n");

            }
        }

    }
}



 if (location1 == location3)
            {
                while (player1.gameBoard[location1, location2 + 1] != newType)
                {
                    if (player1.gameBoard[location1, location2] != ".")
                    {
                        Console.WriteLine("You already placed a boat in that location!");
                        PlacePieces();
                    }
                    else
                    {
                        player1.gameBoard[location1, location2 + 1] = newType;
                        location2++;
                    }
                }
            }