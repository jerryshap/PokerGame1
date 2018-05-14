using PokerGame1.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame1
{
    public class Card
    {
      
        public  Image CardImageFront { set; get; }

        public Image CardImageBack { set; get; }
        
        String CardName { set; get; }
        int cardValue { set; get; }
        string cardSuite { set; get; }
        const string iPath = "C:\\Users\\Jerry\\source\\repos\\PokerGame1\\PokerGame1\\Resources\\";

        public Card(string iCardName)
        {
           // iCardName = iCardName + ".jpg";
            //CardImageFront = Image.FromFile(iPath + iCardName + ".jpg");

            object objF = Properties.Resources.ResourceManager.GetObject(iCardName);
            CardImageFront = ((System.Drawing.Image)(objF));

            object objB = Properties.Resources.ResourceManager.GetObject("Red_back");
            CardImageBack = ((System.Drawing.Image)(objB));

            CardName = iCardName;


        }
        public override string ToString()
        {
            return CardName;
        }
    }
}
