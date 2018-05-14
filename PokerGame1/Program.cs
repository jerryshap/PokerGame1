using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerGame1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Card[] playingCard = new Card[52];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        
            CardTable x = new CardTable();
            

     


            Application.Run(x);

            

        }
    }
}
