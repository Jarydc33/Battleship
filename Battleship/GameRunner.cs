using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class GameRunner
    {        
        Player player1;
        Player player2;
                
        public GameRunner()
        {
            player1 = new Player();
            player2 = new Player();           
            player1.GenerateInitialGameBoard();
            PlacePieces();
                        
        }

        public void PlacePieces()
        {
            int[] location1 = new int[2];
            int[] location2 = new int[2];

            Destroyer temp = new Destroyer();
            location1[0] = temp.Placement();
            location1[1] = temp.Placement();
            player1.UpdateGameBoard(location1[0],location1[1]);

            location2[0] = temp.Placement();
            location2[1] = temp.Placement();
            player1.UpdateGameBoard(location2[0], location2[1]);

        }


    }
}
