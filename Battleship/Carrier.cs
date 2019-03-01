using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Carrier : Ship
    {
        public Carrier()
        {
            BoatSize = 5;
            type = "C";
        }

        public int[] Placement()
        {
            Console.WriteLine("Please enter the coordinates for your Carrier: ");

            Data[0] = int.Parse(Console.ReadLine());
            Data[1] = int.Parse(Console.ReadLine());
            Data[2] = int.Parse(Console.ReadLine());
            Data[3] = int.Parse(Console.ReadLine());
            Data[4] = BoatSize;

            return Data;

        }
    }
}
