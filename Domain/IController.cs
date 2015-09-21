using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/**
 * Author: Mikkel B. Christensen
 * Purpose: This interface is to allow a uniform manner of access to the domain layer from other layers.
 */


namespace Domain
{
    interface IController
    {
        String createUser(string userName, string password);
        User findUser(string userName);
        String createCard(string cardName, string imagePath, int friendship, int bravery, int humor, int starfactor);
        Card[] displayCards(); //Retrieves an array of one of each card-type on the system.



    }
}
