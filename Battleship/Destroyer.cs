using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{    
    class Destroyer : Ship
    {                
        public Destroyer()
        {
            BoatSize = 2;
            type = "D";
           
        }

        public int[] Placement()
        {
            Console.WriteLine("Please enter the coordinates for your Destroyer: ");

            Data[0] = int.Parse(Console.ReadLine());
            Data[1] = int.Parse(Console.ReadLine());
            Data[2] = int.Parse(Console.ReadLine());
            Data[3] = int.Parse(Console.ReadLine());
            Data[4] = BoatSize;

            return Data;

        }





    }
}
