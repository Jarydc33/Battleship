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
            player1.GenerateInitialGameBoard();
            player1.PlacePieces();
                                    
        }
               
             
    }
}
