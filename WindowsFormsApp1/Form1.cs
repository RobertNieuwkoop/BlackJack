using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;

namespace WindowsFormsApp1
{
    public partial class BlackJackForm: Form
    {
        Deck deck = new Deck();
        public BlackJackForm()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Card drawnCard = deck.DrawCard();
            if(drawnCard != null)
            {
                cardLabel.Text = drawnCard.ToString();
                pictureBox1.Image = drawnCard.Image;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
