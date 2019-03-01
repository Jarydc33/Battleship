﻿using System;
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
        int counter = 1;
        int size;
        string type;

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
                Console.Clear();
            }            
        }

        public void PlacePieces()
        {            
            int[] location = new int[4];

            if (counter == 1)
            {
                Console.WriteLine("Please enter the coordinates for your Destroyer: ");
                size = destroyer.BoatSize;
                type = destroyer.type;
            }
            else if(counter == 2)
            {
                Console.WriteLine("Please enter the coordinates for your Submarine: ");
                size = submarine.BoatSize;
                type = submarine.type;
            }
            else if(counter == 3)
            {
                Console.WriteLine("Please enter the coordinates for your Battleship: ");
                size = battleship.BoatSize;
                type = battleship.type;
            }
            else if(counter == 4)
            {
                Console.WriteLine("Please enter the coordinates for your Aircraft Carrier: ");
                size = carrier.BoatSize;
                type = carrier.type;
            }
            location[0] = StringChecker();
            location[1] = StringChecker();
            
            if (gameBoard[location[0], location[1]] != ".")
            {
                Console.WriteLine("You already placed a boat in that location!");
                gameBoard[location[0], location[1]] = ".";
                gameBoard[location[2], location[3]] = ".";
                PlacePieces();
            }
            gameBoard[location[0], location[1]] = type;

            location[2] = StringChecker();
            location[3] = StringChecker();

            if (gameBoard[location[2], location[3]] != ".")
            {
                Console.WriteLine("You already placed a boat in that location!");
                gameBoard[location[0], location[1]] = ".";
                gameBoard[location[2], location[3]] = ".";
                PlacePieces();
            }
            gameBoard[location[2], location[3]] = type;

            SizeChecker(location);
            PieceFiller(location);
            Console.Clear();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(gameBoard[i, j] + " ");
                }
                Console.Write("\n");                
            }
            counter++;
            if(counter < 5)
            {
                PlacePieces();
            }
            else
            {
                Console.WriteLine("Time for Player 2 to place his pieces! Press any key to start your turn.");
                Console.ReadLine();
            }
        }

        public void PieceFiller(int[] ArrayFiller)
        {
            
            if (ArrayFiller[0] == ArrayFiller[2])
            {
                int i = 1;
                while (gameBoard[ArrayFiller[0], ArrayFiller[1] + i] != type)
                {
                    gameBoard[ArrayFiller[0], ArrayFiller[1] + i] = type;
                    i++;
                }
            }
            else
            {
                int i = 0;
                while (gameBoard[ArrayFiller[0] + 1 , ArrayFiller[1]] != type)
                {
                    gameBoard[ArrayFiller[0] + 1 , ArrayFiller[1]] = type;
                    i++;
                }
            }
        }

        public void SizeChecker(int[] SizeArray) { 

            if (SizeArray[0] + SizeArray[1] - (SizeArray[2] + SizeArray[3]) > size - 1)
            {

                Console.WriteLine("Your boat can`t be longer than " + size + ", please enter the coordinates again.");
                PlacePieces();
            }
            else if (SizeArray[2] + SizeArray[3] - (SizeArray[0] + SizeArray[1]) > size - 1)
            {
                Console.WriteLine("Your boat can`t be longer than " + size + ", please enter the coordinate again.");
                PlacePieces();
            }
                                  
        }
        public int StringChecker()
        {
            bool test;
            int number;
            test = int.TryParse(Console.ReadLine(),out number);
            if (test)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Please enter an appropriate number.");
                PlacePieces();
                return 0;
            }
            
        }

    }
}
