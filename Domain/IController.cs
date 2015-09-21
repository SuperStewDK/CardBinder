using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/**
 * Author: Mikkel B. Christensen, Steffen Rasmussen.
 * Purpose: This interface is to allow a uniform manner of access to the domain layer from other layers.
 */


namespace Domain
{
    public interface IController
    {
        String createUser(string userName, string password);
        User findUser(string userName);
        String createCard(string cardName, string imagePath, int friendship, int bravery, int humor, int starfactor);
        ArrayList getCards(); //Retrieves an array of one of each card-type on the system.


        //Currently unused functionality. Meant to be used in conjunction with promotional offers.
        String createRewardCard();

    }
}
