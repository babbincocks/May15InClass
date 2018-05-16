using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Loader
{
    public partial class Form1 : Form
    {
        Point location = Point.Empty;
        CardFiles[] allCards = new CardFiles[56];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int c = 0;
            foreach (string card in ilCards.Images.Keys)
            {
                string cardName = card.Replace("_", " of ");
                cardName = cardName.Replace(".bmp", "");
                CardFiles info = new CardFiles(cardName, card);
                allCards[c] = info;
                lbCards.Items.Add(allCards[c].name);
                c++;
            }
        }

        private void lbCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int index = 0;
            foreach (CardFiles item in allCards)
            {
                if(lbCards.SelectedItem.ToString() == item.name.ToString())
                {
                    foreach (string card in ilCards.Images.Keys)
                    {
                        
                        if(card == item.file)
                        {
                            pbSelectedCard.Image = ilCards.Images[index];
                            pbSelectedCard.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        }
                        index++;
                    }

                    
                }
            }
            
            //pbSelectedCard.Image = ilCards.Images.
        }

        private void pbSelectedCard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                location = new Point(e.X, e.Y);
            }
        }

        private void pbSelectedCard_MouseMove(object sender, MouseEventArgs e)
        {
            if (location != Point.Empty)
            {
                Point newLocation = pbSelectedCard.Location;
                newLocation.X += e.X - location.X;
                newLocation.Y += e.Y - location.Y;
                pbSelectedCard.Location = newLocation;
            }
        }

        private void pbSelectedCard_MouseUp(object sender, MouseEventArgs e)
        {
            location = Point.Empty;
        }

        class CardFiles
        {
            string cardName;
            string cardFile;

            public CardFiles(string name, string file)
            {
                cardName = name;
                cardFile = file;
            }

            public string name
            {
                get { return cardName; }
                set { cardName = value; }
           
            }

            public string file
            {
                get { return cardFile; }
                set { cardFile = value; }

            }
        }

        List<PictureBox> picList = new List<PictureBox>();

        private void btnShow_Click(object sender, EventArgs e)
        {
            

            int leftPos = 340;
            int topPos = 12;
            int row = 1;
            for (int index = 0; index < ilCards.Images.Count; index++)
            {
                PictureBox newCard = new PictureBox();
                newCard.Size = new Size(50, 70);
                newCard.Location = new Point(leftPos, topPos);
                leftPos += 25;
                if (row > 9)
                {
                    topPos += 35;
                    leftPos -= 250;
                    row = 0;
                }
                newCard.Image = ilCards.Images[index];
                this.Controls.Add(newCard);
                newCard.BringToFront();
                newCard.MouseDown += new MouseEventHandler(picMouseDown);
                newCard.MouseMove += new MouseEventHandler(picMouseMove);
                newCard.MouseUp += new MouseEventHandler(picMouseUp);
                picList.Add(newCard);
                

                row++;
            }
        }
        int x = 0;
        int y = 0;
        bool drag = false;
        private void picMouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            drag = true;
        }

        private void picMouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                PictureBox pb = (PictureBox)sender;

                pb.Top += e.Y - y;
                pb.Left += e.X - x;
                pb.BringToFront();
            }
        }

        private void picMouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        
    }
}
