using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{    
    class Destroyer : Ship
    {
        int position;

        public Destroyer()
        {
            BoatSize = 2;
        }

        public int Placement()
        {            
            Console.WriteLine("Please enter the coordinates for your submarine: ");
            position = int.Parse(Console.ReadLine());
                        
            return position;
        }





    }
}
