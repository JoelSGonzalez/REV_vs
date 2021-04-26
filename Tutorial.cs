using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REVOLUTION_continues
{
    public partial class Tutorial : Form
    {
        int page = 0;
        public Tutorial()
        {
            InitializeComponent();
            ShowTutorial();
        }

        public void ShowTutorial()
        {
            //*
            pictureBox0.Visible = false;
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
			pictureBox3.Visible = false;
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
            /*
			pictureBox6.Visible = false;
			pictureBox7.Visible = false;
			pictureBox8.Visible = false;
			pictureBox9.Visible = false;
			pictureBox10.Visible = false;
			pictureBox11.Visible = false;
            //*/
            if (page == 0) Previous.Visible = false;
            else Previous.Visible = true;
            switch (page)
            {
                case 0:
                    pictureBox0.Visible = true;
                    Instructions.Text = "   This is the Main Board. Since this adaptation is made for hotseat" +
                        " multiplayer, each round is divided in one turn for each player. The current player" +
                        " is on the name of the Window and his color is displayed in the background. Here you" +
                        " can see the Bid Board, the Resource Panel, City Map with the SUPPORT Score around the Map, and" +
                        " the Players' ICONS in the center of the Map.";
                    break;

                case 1:
                    pictureBox1.Visible = true;
                    Instructions.Text = "   This is the Resource Panel. It shows all of your  available TOKENS." +
                        " This Panel is automaticaly recalculated every round, and after you spend TOKENS.";
                    break;

                case 2:
                    pictureBox2.Visible = true;
                    Instructions.Text = "   This is the Bid Board. Here, you can open the Offer Window for each character" +
                        " separately, allowing you to make your bids . You can retrieve all your TOKENS to redistribute" +
                        " themusing de 'Reset' button.After you spend all your TOKENS, the 'Confirm' button will end" +
                        " your turn and register your offers.";
                    break;

                case 3:
                    pictureBox3.Visible = true;
                    Instructions.Text = "   This is the Offer Window, where you put your TOKENS for each character." +
                        " Add and remove your available TOKENS through each button for the specific TOKEN you wish.";
                    break;

                case 4:
                    pictureBox4.Visible = true;
                    Instructions.Text = "   You can put the mouse on each player's ICON to see they're respective" +
                        " resources at the start of the current round, such as TOKENS, wich will be displayed in" +
                        " the Resource Panel and SUPPORT, wich is shown oround the City Map. You can even see your" +
                        " own TOKENS from before spending on the bids.";
                    break;

                case 5:
                    pictureBox5.Visible = true;
                    Instructions.Text = "   After all players make they're bids," +
                        " this is where the results of the players' bids are shown. It also tells if someone won" +
                        " and wich player did. You can use the ENTER key to proceed.";
                    break;

                default:
                    this.Close();
                    break;
            }

        }

        private void Arrows_Click(object sender, EventArgs e)
        {
            var origem = (Label)sender;
            if(origem.TabIndex == 0)
            {
                page--;
            }
            else if (origem.TabIndex == 1)
            {
                page++;
            }
            ShowTutorial();
        }
    }
}
