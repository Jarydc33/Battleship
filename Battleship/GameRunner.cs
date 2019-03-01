using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public class GameRunner
    {        
        Player player1;
        Player player2;
        
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
        }

        public void StartTurns()
        {

        }
               
             
    }
}
