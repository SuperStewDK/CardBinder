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
    public class DomainController
    {

        ArrayList UserList = new ArrayList();
        ArrayList CardList = new ArrayList();



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



        //Used for creating a new card
  

 

        public string createUser(string userName, string password)
        {
            UserList.Add(new User(userName, password));
            return "User created successfully";
        }

        public ArrayList getCards()
        {
            return CardList;
        }

        //Used to lookup a user by their exact username. 
        public User findUser(string userName)
        {
            foreach(User u in UserList)
            {
                if (u.Username == userName)
                    return u;
            }
            return null;

        }
    }
}
