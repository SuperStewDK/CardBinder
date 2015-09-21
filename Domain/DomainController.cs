using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
* Author:   Mikkel B. Christensen
* Purpose:  A controller to manage the event flow of actions taken in the domain layer.
*            Also holds lists of every object initialized
*/


namespace Domain
{
    public class DomainController : IController
    {

        ArrayList UserList = new ArrayList();


        public RewardCard LatestRewardCard { get; set; }
        public CollectableCard LatestCollectableCard { get; set; }


        private static DomainController instance;

        public static DomainController getInstance()
        {
            if (instance == null)
                instance = new DomainController();
            return instance;
        }

        private DomainController()
        {

        }


        public string createCard(string cardName, string imagePath, int friendship, int bravery, int humor, int starfactor)
        {
            return "";
        }

        public string createRewardCard()
        {
            RewardCard rewardCard = new RewardCard();
            LatestRewardCard = rewardCard;
            return rewardCard.RewardCode;
        }

        public CollectableCard cardTest(string name, string path)
        {
            LatestCollectableCard = new CollectableCard(name, path);
            return LatestCollectableCard;

        }

        public string createUser(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Card[] displayCards()
        {
            throw new NotImplementedException();
        }

        public User findUser(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
