using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerGame1
{
    public partial class CardTable : Form
    {

        private Card MyCard;

        private Image i;

        List<PictureBox> lstRawPictureBoxsA = new List<PictureBox>();

        List<PictureBox> lstRawPictureBoxsB = new List<PictureBox>();

        List<PictureBox> lstSortPictureBoxsA = new List<PictureBox>();

        List<PictureBox> lstSortPictureBoxsB = new List<PictureBox>();

        List<PictureBox> MuckListPictureBoxs = new List<PictureBox>();

        private Deck aDeck = new Deck();
        public CardTable()
        {
            InitializeComponent();


            foreach(PictureBox p  in Controls.OfType<PictureBox>())
            {

                if (p.Name.Length >= 8 && p.Name.Substring(7, 1) == "A")
                   lstRawPictureBoxsA.Add(p);

                if (p.Name.Length >= 8 && p.Name.Substring(7, 1) == "B")
                    lstRawPictureBoxsB.Add(p);
                
            }

            var lclSortPictureBoxsA = from lstRawPictureBoxA in lstRawPictureBoxsA
                                      orderby lstRawPictureBoxA.Name.ToString()
                                      select lstRawPictureBoxA;

            var lclSortPictureBoxsB = from lstRawPictureBoxB in lstRawPictureBoxsB
                                      orderby lstRawPictureBoxB.Name.ToString()
                                      select lstRawPictureBoxB;

            lstSortPictureBoxsA.AddRange(lclSortPictureBoxsA);

            lstSortPictureBoxsB.AddRange(lclSortPictureBoxsB);


        }

        public void setImageMuckPile(Image ipImage)
        {
            MuckListPictureBoxs.Add(new PictureBox());

            if(MuckListPictureBoxs.Count == 1)
                MuckListPictureBoxs[MuckListPictureBoxs.Count - 1].Location = new Point(MuckPile.Location.X, MuckPile.Location.Y);
            else
                MuckListPictureBoxs[MuckListPictureBoxs.Count - 1].Location = new Point(MuckListPictureBoxs[MuckListPictureBoxs.Count - 2].Location.X - 5, MuckListPictureBoxs[MuckListPictureBoxs.Count - 2].Location.Y + 5);

            MuckListPictureBoxs[MuckListPictureBoxs.Count - 1].Size = new Size(MuckPile.Size.Width, MuckPile.Size.Height);

            MuckListPictureBoxs[MuckListPictureBoxs.Count - 1].BackgroundImageLayout = ImageLayout.Tile;

            MuckListPictureBoxs[MuckListPictureBoxs.Count - 1].SizeMode = PictureBoxSizeMode.Zoom;

            MuckListPictureBoxs[MuckListPictureBoxs.Count - 1].Image = ipImage;

            MuckListPictureBoxs[MuckListPictureBoxs.Count - 1].Visible = true;

            //MuckListPictureBoxs[MuckListPictureBoxs.Count - 1].BackgroundImage = Properties.Resources.blue_back;

            MuckListPictureBoxs[MuckListPictureBoxs.Count - 1].BackColor = Color.Green;

            MuckListPictureBoxs[MuckListPictureBoxs.Count - 1].Anchor = AnchorStyles.Left;

            //InitializeComponent();

            this.Controls.Add(MuckListPictureBoxs[MuckListPictureBoxs.Count - 1]);

            MuckListPictureBoxs[MuckListPictureBoxs.Count - 1].Update();
        }
        public void setImageFlop1(Image ipImage)
        {
            Flop1.Image = ipImage;

            Flop1.Update();
        }

        public void setImageFlop2(Image ipImage)
        {
            Flop2.Image = ipImage;

            Flop2.Update();
        }

        public void setImageFlop3(Image ipImage)
        {
            Flop3.Image = ipImage;

            Flop3.Update();
        }

        public void setImageTurn(Image ipImage)
        {
            Turn.Image = ipImage;

            Turn.Update();
        }

        public void setImageRiver(Image ipImage)
        {
            River.Image = ipImage;

            River.Update();
        }

        public void setImageplayer1A(Image ipImage)
        {
            player1A.Image = ipImage;

            player1A.Refresh();

        }

        public void setImageplayer1B(Image ipImage)
        {
            player1B.Image = ipImage;

            player1B.Refresh();
        }

        public void setImageplayer2A(Image ipImage)
        {
            player2A.Image = ipImage;

            player2A.Refresh();
        }

        public void setImageplayer2B(Image ipImage)
        {
            player2B.Image = ipImage;

            player2B.Refresh();
        }
        public void setImageplayer3A(Image ipImage)
        {
            player3A.Image = ipImage;

            player3A.Refresh();

        }

        public void setImageplayer3B(Image ipImage)
        {
            Player3B.Image = ipImage;

            Player3B.Refresh();
        }
        public void setImageplayer4A(Image ipImage)
        {
            player4A.Image = ipImage;

            player4A.Refresh();

        }

        public void setImageplayer4B(Image ipImage)
        {
            player4B.Image = ipImage;

            player4B.Refresh();

        }
        public void setImageplayer5A(Image ipImage)
        {
            player5A.Image = ipImage;

            player5A.Refresh();

        }

        public void setImageplayer5B(Image ipImage)
        {
            player5B.Image = ipImage;

            player5B.Refresh();

        }
        public void setImageplayer6A(Image ipImage)
        {
            player6A.Image = ipImage;

            player6A.Refresh();

        }

        public void setImageplayer6B(Image ipImage)
        {
            player6B.Image = ipImage;

            player6B.Refresh();

        }
        public void setImageplayer7A(Image ipImage)
        {
            player7A.Image = ipImage;

            player7A.Refresh();

        }

        public void setImageplayer7B(Image ipImage)
        {
            player7B.Image = ipImage;

            player7B.Refresh();

        }
        public void setImageplayer8A(Image ipImage)
        {
            player8A.Image = ipImage;

            player8A.Refresh();

        }

        public void setImageplayer8B(Image ipImage)
        {
            player8B.Image = ipImage;

            player8B.Refresh();
        }

        void wait(int x)
        {
            DateTime t = DateTime.Now;
            DateTime tf = DateTime.Now.AddSeconds(x);

            while (t < tf)
            {
                t = DateTime.Now;
            }
        }


        private void butnDeal_Click(object sender, EventArgs e)
        {

            foreach (PictureBox p in Controls.OfType<PictureBox>())
            {
                p.Image = null;
            }

            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix] is PictureBox && this.Controls[ix].Name.ToString() == "")
                    this.Controls[ix].Dispose();
            }

            MuckListPictureBoxs.Clear();

            MessageBox.Show("Ready to deal?");

                aDeck.Shuffle();


           //  Deal First Card To each Player (8)
           foreach (var lstSortPictureBoxA in lstSortPictureBoxsA)
            {
                MyCard = aDeck.DealCard();

                wait(1);

                try
                {
                    i = MyCard.CardImageFront;

                    if (i == null)
                    {
                        MessageBox.Show("i is null " + lstSortPictureBoxA.Name.ToString());
                    }

                    if (lstSortPictureBoxA.Name.ToString() != "player4A" && lstSortPictureBoxA.Name.ToString() != "player5A")
                    i.RotateFlip(RotateFlipType.Rotate90FlipNone);

                    lstSortPictureBoxA.Image = i;

                    lstSortPictureBoxA.Refresh();

                    if (lstSortPictureBoxA.Name.ToString() != "player4A" && lstSortPictureBoxA.Name.ToString() != "player5A")
                        i.RotateFlip(RotateFlipType.Rotate270FlipNone);
                   // i.Dispose();
                }
                catch(Exception ex )
                {
                    MessageBox.Show(ex.Message.ToString());
                }                                   
            }

            //  Deal First Card To each Player (8)
            foreach (var lstSortPictureBoxB in lstSortPictureBoxsB)
            {
                MyCard = aDeck.DealCard();
                wait(1);
                try
                {


                    Image i = MyCard.CardImageFront;                    

                    if (i == null)
                    {
                        MessageBox.Show("I got a null i for " + lstSortPictureBoxB.ToString());
                    }


                    if (lstSortPictureBoxB.Name.ToString() != "player4B" && lstSortPictureBoxB.Name.ToString() != "player5B")
                        i.RotateFlip(RotateFlipType.Rotate90FlipNone);

                    lstSortPictureBoxB.Image = i;

                    lstSortPictureBoxB.Refresh();

                    if (lstSortPictureBoxB.Name.ToString() != "player4B" && lstSortPictureBoxB.Name.ToString() != "player5B")
                        i.RotateFlip(RotateFlipType.Rotate270FlipNone);
                   
                    // i.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() );
                }

            }

            MessageBox.Show("Firsy Bet");


            // Deal table
            MyCard = aDeck.DealCard();

            wait(1);

            setImageMuckPile(MyCard.CardImageBack);

            MyCard = aDeck.DealCard();

            wait(1);

            setImageFlop1(MyCard.CardImageFront);

            MyCard = aDeck.DealCard();

            wait(1);

            setImageFlop2(MyCard.CardImageFront);

            MyCard = aDeck.DealCard();

            wait(1);

            setImageFlop3(MyCard.CardImageFront);

            MessageBox.Show ("Second Bet (Turn Card)");

            MyCard = aDeck.DealCard();

            wait(1);

            setImageMuckPile(MyCard.CardImageBack);

            MyCard = aDeck.DealCard();

            wait(1);

            setImageTurn(MyCard.CardImageFront);

            MessageBox.Show("Third Bet (River)");


            MyCard = aDeck.DealCard();

            wait(1);

            setImageMuckPile(MyCard.CardImageBack);

            MyCard = aDeck.DealCard();

            wait(1);

            setImageRiver(MyCard.CardImageFront);


            butnDeal.Text = "Play Again";

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void CardTable_Load(object sender, EventArgs e)
        {

        }
    }
}
