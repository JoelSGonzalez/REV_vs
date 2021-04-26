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
    public partial class Analisis : Form
    {
        string winner, person;
        public Analisis(int[,] Tokens, int player, int limit, int who)
        {
            InitializeComponent();
            if (limit == 3) this.ClientSize = new System.Drawing.Size(366, 284);
            if (player == 0) winner = "Nobody";
            else winner = "Player " + player.ToString();
            person = Person(who);
            this.Text = "Bids fot the " + person;
            
            WriteLabel(RedT, Tokens);
            WriteLabel(RedB, Tokens);
            WriteLabel(RedG, Tokens);
            WriteLabel(GreenT, Tokens);
            WriteLabel(GreenB, Tokens);
            WriteLabel(GreenG, Tokens);
            WriteLabel(BlueT, Tokens);
            WriteLabel(BlueB, Tokens);
            WriteLabel(BlueG, Tokens);
            WriteLabel(YellowT, Tokens);
            WriteLabel(YellowB, Tokens);
            WriteLabel(YellowG, Tokens);
        }

        public void WriteLabel(Label label, int[,] Tokens)
        {
            label.Text = "" + Tokens[Convert.ToInt16(label.Tag), label.TabIndex - 1];
        }

        public string Person(int aux)
        {
            switch (aux)
            {
                case 0:
                    return "General";

                case 1:
                    return "Captain";

                case 2:
                    return "Innkeeper";

                case 3:
                    return "Magistrate";

                case 4:
                    return "Priest";

                case 5:
                    return "Aristocrat";

                case 6:
                    return "Merchant";

                case 7:
                    return "Printer";

                case 8:
                    return "Rogue";

                case 9:
                    return "Spy";

                case 10:
                    return "Apothecary";

                case 11:
                    return "Mercenary";

                default:
                    return "Enknown";
            }
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            MessageBox.Show(winner + " won the bid for the " + person + "!");
            this.Close();
        }
    }
}
