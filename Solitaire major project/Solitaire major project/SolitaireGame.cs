using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solitaire_major_project
{
    public partial class SolitaireGame : Form
    {
        List<Card> CardsOnScreen = new List<Card>();
        public SolitaireGame()
        {
            InitializeComponent();
        }
        

        private void SolitaireGame_Load(object sender, EventArgs e)
        {
            
            deck deck = new deck();
            deck.Shuffle();
            for (int i = 24; i > 0; i--)
            {
                Card c = deck.Draw();
                c.Location = new Point(1*i, 53);
                c.Parent = this;

            }
            for (int i = 7; i > 0; i--)
            {
                Card c = deck.Draw();

                c.Location = new Point(1250, 500 + 10 * i);
                c.Parent = this;

            }
            for(int i = 6; i > 0; i--)
            {
                Card c = deck.Draw();

                c.Location = new Point(1050, 500 + 10 * i);
                c.Parent = this;
            }
            for (int i = 5; i > 0; i--)
            {
                Card c = deck.Draw();

                c.Location = new Point(850, 500 + 10 * i);
                c.Parent = this;
            }
            for (int i = 4; i > 0; i--)
            {
                Card c = deck.Draw();

                c.Location = new Point(650, 500 + 10 * i);
                c.Parent = this;
            }
            for (int i = 3; i > 0; i--)
            {
                Card c = deck.Draw();

                c.Location = new Point(450, 500 + 10 * i);
                c.Parent = this;
            }
            for (int i = 2; i > 0; i--)
            {
                Card c = deck.Draw();

                c.Location = new Point(250, 500 + 10 * i);
                c.Parent = this;
            }
            for (int i = 1; i > 0; i--)
            {
                Card c = deck.Draw();

                c.Location = new Point(50, 500 + 10 * i);
                c.Parent = this;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
