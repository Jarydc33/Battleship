using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Submarine : Ship
    {
        public Submarine()
        {
            BoatSize = 3;
            type = "S";
        }

        public int[] Placement()
        {
            Console.WriteLine("Please enter the coordinates for your Submarine: ");

            Data[0] = int.Parse(Console.ReadLine());
            Data[1] = int.Parse(Console.ReadLine());
            Data[2] = int.Parse(Console.ReadLine());
            Data[3] = int.Parse(Console.ReadLine());
            Data[4] = BoatSize;

            return Data;

        }
    }
}
