using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public abstract class Ship
    {
        public int BoatSize;
        public string type;
        public bool isHit;
        public int i = 0;        
        public int[]Data = new int[5];       
    }
}
