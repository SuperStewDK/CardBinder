using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
* Author: Mikkel B. Christensen, Steffen Rasmussen.
* Purpose: An object which represents a generic card in the system.
*/


namespace Domain
{
    public class Card
    {
        public String Name { get; set; }
        public String ImagePath { get; set; }
        public int SerialNumber { get; set; }

        public int friendship { get; set; }
        public int bravery { get; set; }
        public int humor { get; set; }
        public int starfactor { get; set; }

        /**
        * Should not generally be used unless manually setting the card name and image path manually directly after object instantiation.
        */
        public Card()
        {
            
        }

    }
}
