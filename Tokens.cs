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
    public partial class Tokens : Form
    {
        int threats;
        int blackmails;
        int golds;

        string person;

        int aux;

        public int[,] Uncertain { get; set; } = new int[12, 3];

        public int Person2Number(string person)
        {
            switch (person)
            {
                case "General":
                    return 0;

                case "Captain":
                    return 1;

                case "Innkeeper":
                    return 2;

                case "Magistrate":
                    return 3;

                case "Priest":
                    return 4;

                case "Aristocrat":
                    return 5;

                case "Merchant":
                    return 6;

                case "Printer":
                    return 7;

                case "Rogue":
                    return 8;

                case "Spy":
                    return 9;

                case "Apothecary":
                    return 10;

                case "Mercenary":
                    return 11;

                default:
                    return 100;
            }
        }

        public Tokens(string pessoa, int coins, int mails, int force, int[,] Incerto)
        {
            InitializeComponent();
            this.Text = "Offerts for " + pessoa;
            person = pessoa;
            
            aux = Person2Number(pessoa);

            Uncertain = Incerto;
            
            threats = force + Incerto[aux, 0];
            blackmails = mails + Incerto[aux, 1];
            golds = coins + Incerto[aux, 2];

            Labels();
        }
        
        public void Labels()
        {
            this.Ameaças.Text = "" + Uncertain[aux, 0];
            this.Chantagens.Text = "" + Uncertain[aux, 1];
            this.Ouro.Text = "" + Uncertain[aux, 2];
        }

        private void IncreaseThreats_Click(object sender, EventArgs e)
        {
            if (Uncertain[aux, 0] < threats)
            {
                if (aux != 0 & aux != 1 & aux != 8 & aux != 10 & aux != 11)
                {
                    Uncertain[aux, 0]++;
                    Labels();
                }
                else
                    MessageBox.Show("   You can't threaten  the " + person + "!");
            }
            else
                MessageBox.Show("   You don't have more threats!");
        }

        private void IncreaseBlackmails_Click(object sender, EventArgs e)
        {
            if (Uncertain[aux, 1] < blackmails)
            {
                if (aux != 2 & aux != 3 & aux != 8 & aux != 9 & aux != 11) 
                {
                    Uncertain[aux, 1]++;
                    Labels();
                }
                else
                    MessageBox.Show("You can't blackmail  the " + person + "!");
            }
            else
                MessageBox.Show("You don't have more blackmails!");
        }

        private void IncreaseGold_Click(object sender, EventArgs e)
        {
            if (Uncertain[aux, 2] < golds)
            {
                Uncertain[aux, 2]++;
                Labels();
            }
            else
                MessageBox.Show("   You don't have more gold!");
        }

        private void DecreaseGold_Click(object sender, EventArgs e)
        {
            if (Uncertain[aux, 2] > 0) Uncertain[aux, 2]--;
            Labels();
        }

        private void DecreaseBlackmails_Click(object sender, EventArgs e)
        {
            if (Uncertain[aux, 1] > 0) Uncertain[aux, 1]--;
            Labels();
        }
    }
}
