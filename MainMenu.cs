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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void RuleSheet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sjgames.com/revolution/img/revolution_rules.pdf");
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var origem = (Label)sender;
            switch (origem.TabIndex)
            {
                case 1:
                    Bomb1.Visible = true;
                    break;

                case 2:
                    Bomb2.Visible = true;
                    players3.Visible = false;
                    players4.Visible = false;
                    break;

                case 3:
                    Bomb3.Visible = true;
                    players3.Visible = false;
                    players4.Visible = false;
                    break;

                case 0:
                    if (Convert.ToInt32(origem.Tag) == 3) minibomb3.Visible = true;
                    if (Convert.ToInt32(origem.Tag) == 4) minibomb4.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Bomb1.Visible = false;
            Bomb2.Visible = false;
            Bomb3.Visible = false;
            minibomb3.Visible = false;
            minibomb4.Visible = false;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            players3.Visible = true;
            players4.Visible = true;
        }

        private void Players_Click(object sender, EventArgs e)
        {
            players3.Visible = false;
            players4.Visible = false;
            var origem = (Label)sender;
            Board board = new Board(Convert.ToInt32(origem.Tag));
            this.Hide();
            board.ShowDialog();
            this.Show();
        }

        private void Tutorial_Click(object sender, EventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            this.Hide();
            tutorial.ShowDialog();
            this.Show();
        }
    }
}
