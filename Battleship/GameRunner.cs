using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class GameRunner
    {        
        Player player1;
        Player player2;
        Destroyer destroyer;
        Submarine submarine;
        Battleship battleship;
        Carrier carrier;
        int[] Data;

        public GameRunner()
        {
            player1 = new Player();
            player2 = new Player();
            destroyer = new Destroyer();
            submarine = new Submarine();
            battleship = new Battleship();
            carrier = new Carrier();
            Data = new int[5];
            player1.GenerateInitialGameBoard();
            PlacePieces();
                        
        }

        public void PlacePieces()
        {
            Data = destroyer.Placement();
            player1.UpdateGameBoard(Data[0], Data[1], Data[2], Data[3], Data[4], Data[4]);
            Data = submarine.Placement();
            player1.UpdateGameBoard(Data[0], Data[1], Data[2], Data[3], Data[4], Data[4]);
            Data = battleship.Placement();
            player1.UpdateGameBoard(Data[0], Data[1], Data[2], Data[3], Data[4], Data[4]);
            Data = carrier.Placement();
            player1.UpdateGameBoard(Data[0], Data[1], Data[2], Data[3], Data[4], Data[4]);

        }


    }
}
