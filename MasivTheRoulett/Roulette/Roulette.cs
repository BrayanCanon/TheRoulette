using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasivTheRoulett.Roulette
{

    public class Roulette
    {
        private int id = 0;
        private string state = "Active";
        List<string> bets = new List<string>();
        private int number = -1;
        private string color = "";
        private int betAmount = 0;

        public Roulette(int pId)
        {
            id = pId;
        }

        public void doBet()
        {

        }


    }
}
