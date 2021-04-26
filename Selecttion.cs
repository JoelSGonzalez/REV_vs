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
    public partial class Selecttion : Form
    {
        public int[] Plantation { get; set; } = new int[6];
        public int[] Tavern { get; set; } = new int[4];
        public int[] Cathedral { get; set; } = new int[7];
        public int[] Fortress { get; set; } = new int[8];
        public int[] Harbor { get; set; } = new int[6];
        public int[] TownHall { get; set; } = new int[7];
        public int[] Market { get; set; } = new int[5];

        byte function = 0;

        int Turn;

        int counter = 0;
        int[] Indices = new int[2];
        int[] Locais = new int[2];
        int[] array0;
        int[] array1;

        public Selecttion(int[] Area1, int[] Area2, int[] Area3, int[] Area4, int[] Area5, int[] Area6, int[] Area7, int aux, int player)
        {

            Plantation = Area1;
            Tavern = Area2;
            Cathedral = Area3;
            Fortress = Area4;
            Harbor = Area5;
            TownHall = Area6;
            Market = Area7;

            Turn = player;

            if (aux == 9)
            {
                this.Text = "Witch influence should the Spy replace?";
                function = 1;
            }
            if (aux == 10)
            {
                this.Text = "Witch influences should the Apothecary change places?";
                function = 2;
            }
            InitializeComponent();
            switch (Turn)
            {
                case 1:
                    this.BackColor = System.Drawing.Color.DarkRed;
                    break;

                case 2:
                    this.BackColor = System.Drawing.Color.DarkBlue;
                    break;

                case 3:
                    this.BackColor = System.Drawing.Color.DarkGreen;
                    break;

                case 4:
                    this.BackColor = System.Drawing.Color.Goldenrod;
                    break;
            }
            Atualizar();
        }
        
        public void Atualizar()
        {
            AtualizePlantation();
            AtualizeTavern();
            AtualizeTownHall();
            AtualizeMarket();
            AtualizeHarbor();
            AtualizeFortress();
            AtualizeCathedral();
        }

        public void AtualizePlantation()
        {
            switch (Plantation[0])
            {
                case 1:
                    this.Plantation1.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Plantation1.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Plantation1.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Plantation1.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Plantation1.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Plantation[1])
            {
                case 1:
                    this.Plantation2.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Plantation2.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Plantation2.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Plantation2.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Plantation2.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Plantation[2])
            {
                case 1:
                    this.Plantation3.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Plantation3.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Plantation3.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Plantation3.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Plantation3.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Plantation[3])
            {
                case 1:
                    this.Plantation4.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Plantation4.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Plantation4.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Plantation4.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Plantation4.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Plantation[4])
            {
                case 1:
                    this.Plantation5.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Plantation5.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Plantation5.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Plantation5.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Plantation5.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Plantation[5])
            {
                case 1:
                    this.Plantation6.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Plantation6.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Plantation6.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Plantation6.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Plantation6.BackColor = System.Drawing.Color.White;
                    break;
            }
        }

        public void AtualizeTavern()
        {
            switch (Tavern[0])
            {
                case 1:
                    this.Tavern1.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Tavern1.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Tavern1.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Tavern1.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Tavern1.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Tavern[1])
            {
                case 1:
                    this.Tavern2.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Tavern2.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Tavern2.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Tavern2.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Tavern2.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Tavern[2])
            {
                case 1:
                    this.Tavern3.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Tavern3.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Tavern3.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Tavern3.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Tavern3.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Tavern[3])
            {
                case 1:
                    this.Tavern4.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Tavern4.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Tavern4.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Tavern4.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Tavern4.BackColor = System.Drawing.Color.White;
                    break;
            }
        }

        public void AtualizeTownHall()
        {
            switch (TownHall[0])
            {
                case 1:
                    this.TownHall1.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.TownHall1.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.TownHall1.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.TownHall1.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.TownHall1.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (TownHall[1])
            {
                case 1:
                    this.TownHall2.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.TownHall2.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.TownHall2.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.TownHall2.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.TownHall2.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (TownHall[2])
            {
                case 1:
                    this.TownHall3.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.TownHall3.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.TownHall3.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.TownHall3.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.TownHall3.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (TownHall[3])
            {
                case 1:
                    this.TownHall4.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.TownHall4.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.TownHall4.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.TownHall4.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.TownHall4.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (TownHall[4])
            {
                case 1:
                    this.TownHall5.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.TownHall5.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.TownHall5.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.TownHall5.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.TownHall5.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (TownHall[5])
            {
                case 1:
                    this.TownHall6.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.TownHall6.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.TownHall6.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.TownHall6.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.TownHall6.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (TownHall[6])
            {
                case 1:
                    this.TownHall7.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.TownHall7.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.TownHall7.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.TownHall7.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.TownHall7.BackColor = System.Drawing.Color.White;
                    break;
            }
        }

        public void AtualizeMarket()
        {
            switch (Market[0])
            {
                case 1:
                    this.Market1.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Market1.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Market1.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Market1.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Market1.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Market[1])
            {
                case 1:
                    this.Market2.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Market2.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Market2.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Market2.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Market2.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Market[2])
            {
                case 1:
                    this.Market3.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Market3.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Market3.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Market3.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Market3.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Market[3])
            {
                case 1:
                    this.Market4.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Market4.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Market4.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Market4.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Market4.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Market[4])
            {
                case 1:
                    this.Market5.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Market5.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Market5.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Market5.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Market5.BackColor = System.Drawing.Color.White;
                    break;
            }
        }

        public void AtualizeHarbor()
        {
            switch (Harbor[0])
            {
                case 1:
                    this.Harbor1.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Harbor1.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Harbor1.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Harbor1.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Harbor1.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Harbor[1])
            {
                case 1:
                    this.Harbor2.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Harbor2.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Harbor2.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Harbor2.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Harbor2.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Harbor[2])
            {
                case 1:
                    this.Harbor3.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Harbor3.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Harbor3.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Harbor3.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Harbor3.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Harbor[3])
            {
                case 1:
                    this.Harbor4.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Harbor4.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Harbor4.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Harbor4.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Harbor4.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Harbor[4])
            {
                case 1:
                    this.Harbor5.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Harbor5.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Harbor5.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Harbor5.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Harbor5.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Harbor[5])
            {
                case 1:
                    this.Harbor6.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Harbor6.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Harbor6.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Harbor6.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Harbor6.BackColor = System.Drawing.Color.White;
                    break;
            }
        }

        public void AtualizeFortress()
        {
            switch (Fortress[0])
            {
                case 1:
                    this.Fortress1.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Fortress1.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Fortress1.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Fortress1.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Fortress1.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Fortress[1])
            {
                case 1:
                    this.Fortress2.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Fortress2.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Fortress2.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Fortress2.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Fortress2.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Fortress[2])
            {
                case 1:
                    this.Fortress3.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Fortress3.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Fortress3.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Fortress3.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Fortress3.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Fortress[3])
            {
                case 1:
                    this.Fortress4.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Fortress4.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Fortress4.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Fortress4.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Fortress4.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Fortress[4])
            {
                case 1:
                    this.Fortress5.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Fortress5.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Fortress5.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Fortress5.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Fortress5.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Fortress[5])
            {
                case 1:
                    this.Fortress6.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Fortress6.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Fortress6.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Fortress6.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Fortress6.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Fortress[6])
            {
                case 1:
                    this.Fortress7.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Fortress7.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Fortress7.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Fortress7.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Fortress7.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Fortress[7])
            {
                case 1:
                    this.Fortress8.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Fortress8.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Fortress8.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Fortress8.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Fortress8.BackColor = System.Drawing.Color.White;
                    break;
            }
        }

        public void AtualizeCathedral()
        {
            switch (Cathedral[0])
            {
                case 1:
                    this.Cathedral1.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Cathedral1.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Cathedral1.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Cathedral1.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Cathedral1.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Cathedral[1])
            {
                case 1:
                    this.Cathedral2.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Cathedral2.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Cathedral2.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Cathedral2.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Cathedral2.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Cathedral[2])
            {
                case 1:
                    this.Cathedral3.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Cathedral3.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Cathedral3.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Cathedral3.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Cathedral3.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Cathedral[3])
            {
                case 1:
                    this.Cathedral4.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Cathedral4.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Cathedral4.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Cathedral4.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Cathedral4.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Cathedral[4])
            {
                case 1:
                    this.Cathedral5.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Cathedral5.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Cathedral5.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Cathedral5.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Cathedral5.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Cathedral[5])
            {
                case 1:
                    this.Cathedral6.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Cathedral6.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Cathedral6.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Cathedral6.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Cathedral6.BackColor = System.Drawing.Color.White;
                    break;
            }

            switch (Cathedral[6])
            {
                case 1:
                    this.Cathedral7.BackColor = System.Drawing.Color.Red;
                    break;

                case 2:
                    this.Cathedral7.BackColor = System.Drawing.Color.Blue;
                    break;

                case 3:
                    this.Cathedral7.BackColor = System.Drawing.Color.Green;
                    break;

                case 4:
                    this.Cathedral7.BackColor = System.Drawing.Color.Yellow;
                    break;

                default:
                    this.Cathedral7.BackColor = System.Drawing.Color.White;
                    break;
            }
        }

        public void EventHandler2(int index, int tag)
        {
            if (function == 1)
            {
                Substituir2(index, tag);
            }
            else if (function == 2)
            {
                Trocar2(index, tag);
            }
        }

        public void Trocar2(int local, int i)
        {
            if (counter == 0)
            {
                array0 = Index2Array(local);
                if (array0[i - 1] != 0)
                {
                    Locais[0] = local;
                    Indices[0] = i - 1;
                    counter++;
                }
                else
                {
                    MessageBox.Show("   You can't swap influences on an empty space!\n" +
                        "\t   Please select another space.");
                    counter = 0;
                }
            }

            else if (counter == 1)
            {
                if (local != Locais[0])
                {
                    array1 = Index2Array(local);
                    if (array1[i - 1] != array0[Indices[0]])
                    {
                        if (array1[i - 1] != 0)
                        {
                            Locais[1] = local;
                            Indices[1] = i - 1;
                            counter++;
                        }
                        else
                        {
                            MessageBox.Show("   You can't swap influences on an empty space!\n" +
                                "\t Please select 2 other spaces.");
                            counter = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("   You can't swap influences of the same color!\n" +
                            "\t Please select 2 other spaces.");
                        counter = 0;
                    }
                }
                else
                {
                    MessageBox.Show("   You can't swap influences of the same region!\n" +
                            "\t Please select 2 other spaces.");
                    counter = 0;
                }
            }

            if (counter == 2)
            {
                int copy = array0[Indices[0]];
                array0[Indices[0]] = array1[Indices[1]];
                array1[Indices[1]] = copy;
                ValidateCopy(array0, Locais[0]);
                ValidateCopy(array1, Locais[1]);
                this.Close();
            }
        }

        public void Substituir2(int local, int i)
        {
            switch (local)
            {
                case 1:
                    if (Plantation[i - 1] != 0)
                    {
                        if (Plantation[i - 1] != Turn)
                        {
                            Plantation[i - 1] = Turn;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("\tThis space is already in your influence!\n" +
                                "          Please select another one.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("   You can't replace an empty space!\n" +
                            "          Please select another one.");
                    }
                    break;

                case 2:
                    if (Tavern[i - 1] != 0)
                    {
                        if (Tavern[i - 1] != Turn)
                        {
                            Tavern[i - 1] = Turn;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("\tThis space is already in your influence!\n" +
                                "          Please select another one.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("   You can't replace an empty space!\n" +
                            "          Please select another one.");
                    }
                    break;

                case 3:
                    if (Cathedral[i - 1] != 0)
                    {
                        if (Cathedral[i - 1] != Turn)
                        {
                            Cathedral[i - 1] = Turn;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("\tThis space is already in your influence!\n" +
                                "          Please select another one.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("   You can't replace an empty space!\n" +
                            "          Please select another one.");
                    }
                    break;

                case 4:
                    if (TownHall[i - 1] != 0)
                    {
                        if (TownHall[i - 1] != Turn)
                        {
                            TownHall[i - 1] = Turn;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("\tThis space is already in your influence!\n" +
                                "          Please select another one.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("   You can't replace an empty space!\n" +
                            "          Please select another one.");
                    }
                    break;

                case 5:
                    if (Fortress[i - 1] != 0)
                    {
                        if (Fortress[i - 1] != Turn)
                        {
                            Fortress[i - 1] = Turn;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("\tThis space is already in your influence!\n" +
                                "          Please select another one.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("   You can't replace an empty space!\n" +
                            "          Please select another one.");
                    }
                    break;
                case 6:
                    if (Market[i - 1] != 0)
                    {
                        if (Market[i - 1] != Turn)
                        {
                            Market[i - 1] = Turn;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("\tThis space is already in your influence!\n" +
                                "          Please select another one.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("   You can't replace an empty space!\n" +
                            "          Please select another one.");
                    }
                    break;

                case 7:
                    if (Harbor[i - 1] != 0)
                    {
                        if (Harbor[i - 1] != Turn)
                        {
                            Harbor[i - 1] = Turn;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("\tThis space is already in your influence!\n" +
                                "          Please select another one.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("   You can't replace an empty space!\n" +
                            "          Please select another one.");
                    }
                    break;
            }
        }

        public int[] Index2Array(int place)
        {
            int[] erro = new int[2] { 1, 1 };
            switch (place)
            {
                case 1:
                    return Plantation;

                case 2:
                    return Tavern;

                case 3:
                    return Cathedral;

                case 4:
                    return TownHall;

                case 5:
                    return Fortress;

                case 6:
                    return Market;

                case 7:
                    return Harbor;

                default:
                    return erro;
            }
        }

        public void ValidateCopy(int[] copy, int original)
        {
            switch (original)
            {
                case 1:
                    Plantation = copy;
                    break;

                case 2:
                    Tavern = copy;
                    break;

                case 3:
                    Cathedral = copy;
                    break;

                case 4:
                    TownHall = copy;
                    break;

                case 5:
                    Fortress = copy;
                    break;

                case 6:
                    Market = copy;
                    break;

                case 7:
                    Harbor = copy;
                    break;
            }
        }

        private void Generic_Click(object sender, EventArgs e)
        {
            var origem = (Panel)sender;
            int TagValue = Convert.ToInt16(origem.Tag);
            EventHandler2(origem.TabIndex, TagValue);
        }
    }
}
