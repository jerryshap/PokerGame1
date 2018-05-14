using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PokerGame1
{
    public class Deck
    {
        string[] Suites = {"S","C","H","D" };

        string[] CardValues = {"A","2","3","4","5","6","7","8","9","10","J","Q","K" };

        int dealCard = 0;

        Card[] playingCard = new Card[52];


        static Random _ramdom = new Random();
        public Deck()
        {
            
            int cardPointer = 0;

            for (int SuiteCounter = 0; SuiteCounter <= 3; ++SuiteCounter)
            {
                for (int ValueCounter = 0; ValueCounter <= 12; ++ValueCounter)
                {
                    string CardName = CardValues[ValueCounter] + Suites[SuiteCounter];

                    Card aCard = new Card(CardName);

                    playingCard[cardPointer] = aCard;

                    cardPointer++;
                }

               
            }
        }

        public Card DealCard()
        {

            Card crdDealCard;

            crdDealCard = playingCard[dealCard];

            dealCard++;

            return crdDealCard;
            
        }

        public void Shuffle()
        {
            dealCard = 0;

            int n = playingCard.Length;

            for (int i = 0; i < n; i++)
            {
                int r = i + _ramdom.Next(n - i);

                Card t = playingCard[r];

                playingCard[r] = playingCard[i];

                playingCard[i] = t;
            }
        }
    }
}
