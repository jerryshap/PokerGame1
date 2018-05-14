using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame1
{
    
    class Player
    {
        string PlayerName { get; set; }
        decimal PlayerBank { get; set; }
        int PlayerPosition { set; get; }
        bool Fold { set; get; }

        bool Broke { set; get; }

        public Player(string playerName, decimal playerBank)
        {
            Fold = false;
            PlayerName = playerName;
            PlayerBank = playerBank;
            if (PlayerBank > 0)
                Broke = false;
            else
                Broke = true;
        }

        public void Bet (decimal amt)
        {
            PlayerBank = PlayerBank - amt;

            if (PlayerBank <= 0)
                Broke = true;
        }

        public void FoldCards()
        {
            Fold = true;
        }

    }
}
