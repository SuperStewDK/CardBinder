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
 
        //used to track how far we are in the series of cards when creating / destroying card types.
        static int currentInSeries;



        /**
        * Should not generally be used unless manually setting the card name and image path manually directly after object instantiation.
        */
        public Card()
        {
            SerialNumber = getAndIncrementSerial();
            
        }


        /**
        * The serial number tracks across the type how far in the series we are
        * This method is then used to assing a new serial number to a card when we create a new card.
        */
        public int getAndIncrementSerial()
        {
            int currentIncrement = currentInSeries;
            currentInSeries++;
            return currentIncrement;
        }
    }
}
