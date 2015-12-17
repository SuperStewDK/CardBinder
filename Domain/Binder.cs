using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


/*
* Currently unused
*
*/


namespace Domain
{
    public class Binder
    {
        // the binderid string shall contain user name and the number of binder, incremented if
        // the user has more binders
        public string binderId { get; set; }
        public string userId { get; set; }
        // arraylist containing cards
        public ArrayList cardList { get; set; }

        public Binder(string userid)
        {
            binderId = userid + "Binder";
            cardList = new ArrayList();
        }
    }
}
