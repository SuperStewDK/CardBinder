using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Author: Mikkel B. Christensen
 * Purpose: This object represents cards which are members of the collectible series.
 * MUST extend the Card class.
 */

namespace Domain
{
    public class CollectableCard : Card
    {

        //Stats
        public int Friendship { get; set; }
        public int Bravery { get; set; }
        public int Humor { get; set; }
        public int StarFactor { get;set; }



        //Call the parent class' constructor
        public CollectableCard() : base()
        {
    
        }

        /**
        * Used for creating a card of a non-generic type
        */
        public CollectableCard(String name, String imagePath, int friendship, int bravery, int humor, int starFactor)
        {
            Name = name;
            ImagePath = imagePath;
            Friendship = friendship;
            Bravery = bravery;
            Humor = humor;
            StarFactor = starFactor;
        }

        public CollectableCard(String name, String imagePath) : this(name,imagePath,55,55,55,55)
        {

        }

        public CollectableCard(String name, int friendship, int bravery, int humor, int starFactor) : this(name, "",friendship, bravery, humor, starFactor)
        {

        }


    }
}
