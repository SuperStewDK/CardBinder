using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Author: Mikkel B. Christensen
 * Purpose: A reward card is meant to contain a code which can be exchanged for merchandise.
 */

namespace Domain
{
    public class RewardCard : Card
    {

        public String RewardCode { get; set; }

        public RewardCard() : base()
        {
            RewardCode = generateRewardCode();
        }




        private String generateRewardCode()
        {
            Random random = new Random();
            string characterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] code = new Char[10];

            for(int i = 0; i < code.Length; i++)
            {
                code[i] = characterSet[random.Next(characterSet.Length)];
            }

            return new String(code);
        }


    }




}
