using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public class GameRunner
    {        
        Player player1;
        Player player2;        
        bool AllSunk;
        bool Player2Turn;
        
        public GameRunner()
        {
            player1 = new Player();
            player2 = new Player();
            PlacePieces();                 
        }

        public void PlacePieces()
        {
            player1.GenerateInitialGameBoard();
            player1.PlacePieces();
            player2.GenerateInitialGameBoard();
            player2.PlacePieces();
            StartTurns();
        }

        public void StartTurns()
        {
            if (AllSunk)
            {

            }
            else if (!Player2Turn)
            {
                Console.WriteLine("Player 1 it is your turn to shoot a missile at the opponents board!");
                Console.ReadLine();
                player1.TakeTurn(player2.gameBoard);
                Player2Turn = true;
                StartTurns();
            }
            else
            {
                Console.WriteLine("Player 2 it is your turn to shoot a missile at the opponents board!");
                Console.ReadLine();
                player2.TakeTurn(player1.gameBoard);
                Player2Turn = false;
                StartTurns();
            }
        }
               
             
    }
}
