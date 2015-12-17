using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
* Author: Mikkel B. Christensen
* Purpose: Defines users within the domain.
*/


namespace Domain
{
    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public Binder UserBinder { get; set; }


        public User(String username, String password)
        {
            Username = username;
            Password = password;
            UserBinder = new Binder(username);
        }



    }
}
