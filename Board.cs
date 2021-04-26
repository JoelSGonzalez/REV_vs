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
    public partial class Board : Form
    {

        int[] Threats = new int[4];
        int[] Blackmails = new int[4];
        int[] Golds = new int[4];
        int[] Support = new int[4];

        int Turn = 1;
        int maximum;
        int[,] Positions = new int[100, 2];

        int[] Plantation = new int[6];
        int[] Tavern = new int[4];
        int[] Cathedral = new int[7];
        int[] Fortress = new int[8];
        int[] Harbor = new int[6];
        int[] TownHall = new int[7];
        int[] Market = new int[5];

        int[,,] Subornos = new int[12, 3, 4];
        int[,] UnConfirmed = new int[12, 3];
        int[,] Tokens = new int[3,4];

        public Board(int PlayerLimit)
        {
            maximum = PlayerLimit;
            InitializeComponent();
            if (PlayerLimit == 3) this.player4.Visible = false;
            InitializePositions();
            Patronage(1);
            Patronage(2);
            Patronage(3);
            Patronage(4);
            ExibirJogador(Turn);
            Labels();
            Atualizar();
        }

        public void FillTokens(int temp)
        {
            int i, j;
            for (i=0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Tokens[i, j] = Subornos[temp, i, j];
                }
            }
        }

        public int CountTokens()
        {
            int i, j, result = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (Tokens[i, j] != 0) result++;
                }
            }
            return result;
        }

        public void AnalizeBids()
        {
            int i, j, result = 0;
            
            for (i = 0; i < 12; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    result = Comparing(Subornos[i, j, 0], Subornos[i, j, 1], Subornos[i, j, 2], Subornos[i, j, 3]);
                    FillTokens(i);
                    if (result != 0)
                    {
                        break;
                    }
                }
                if (CountTokens() != 0)
                {
                    Analisis tabela = new Analisis(Tokens, result, maximum, i);
                    tabela.ShowDialog();
                    if (result != 0)
                    {
                        WinnerHandler(i, result);
                    }
                }
            }
            if (AnalizeEnd()) EndTheGame();
        }

        public bool AnalizeEnd()
        {
            int influences = 0;
            influences += CountArray(Plantation, 6);
            influences += CountArray(Tavern, 4);
            influences += CountArray(Cathedral, 7);
            influences += CountArray(TownHall, 7);
            influences += CountArray(Fortress, 8);
            influences += CountArray(Market, 5);
            influences += CountArray(Harbor, 6);
            if (influences == 0) return true;
            else return false;
        }

        public void EndTheGame()
        {
            int winner;
            winner = CompareVector(Plantation, 6);
            if (winner != 0) AddSupport(winner, 30);
            winner = CompareVector(Tavern, 4);
            if (winner != 0) AddSupport(winner, 20);
            winner = CompareVector(Cathedral, 7);
            if (winner != 0) AddSupport(winner, 35);
            winner = CompareVector(TownHall, 7);
            if (winner != 0) AddSupport(winner, 45);
            winner = CompareVector(Fortress, 8);
            if (winner != 0) AddSupport(winner, 50);
            winner = CompareVector(Market, 5);
            if (winner != 0) AddSupport(winner, 25);
            winner = CompareVector(Harbor, 6);
            if (winner != 0) AddSupport(winner, 40);
            for (int i = 0; i<maximum; i++)
            {
                Support[i] += 5 * Threats[i];
                Support[i] += 3 * Blackmails[i];
                Support[i] += Golds[i];
            }
            winner = Comparing(Support[0], Support[1], Support[2], Support[3]);
            MessageBox.Show("This game's WINNER is...\n Player" + winner + ", with" + Support[winner - 1] + " Support!");
            this.Close();
        }

        public int CompareVector(int[] vetor, int limit)
        {
            int[] players = new int[4];
            int winner = 0;
            for (int i = 0; i < limit; i++)
            {
                players[vetor[i] - 1] += 1;
            }
            winner = Comparing(players[0], players[1], players[2], players[3]);
            return winner;
        }

        public int CountArray(int[] vetor, int limit)
        {
            int result = 0;
            for (int i = 0; i < limit; i++)
            {
                if (vetor[i] == 0) result += 1;
            }
            return result;
        }

        public int Comparing(int num1, int num2, int num3, int num4)
        {
            int[] Valores = new int[4];
            Valores[0] = num1;
            Valores[1] = num2;
            Valores[2] = num3;
            Valores[3] = num4;
            int Value = 0, Temp=0, Quantity = 0, winner;
            for (int i = 0; i < 4; i++)
            {
                if (Valores[i] > Value)
                {
                    Value = Valores[i];
                    Temp = i;
                }

            }
            for (int i = 0; i < 4; i++)
            {
                if (Valores[i] == Valores[Temp]) Quantity++;
            }
            if (Quantity == 1)
                winner = Temp + 1;
            else
                winner = 0;
            return winner;
        }

        public void WinnerHandler(int character, int winner)
        {
            switch (character)
            {
                case 0:
                    AddToken(winner, "Threat", 1);
                    AddSupport(winner, 1);
                    AtribuirFortress(winner);
                    AtualizeFortress();
                    break;

                case 1:
                    AddToken(winner, "Threat", 1);
                    AddSupport(winner, 1);
                    AtribuirHarbor(winner);
                    AtualizeHarbor();
                    break;

                case 2:
                    AddToken(winner, "Blackmail", 1);
                    AddSupport(winner, 3);
                    AtribuirTavern(winner);
                    AtualizeTavern();
                    break;

                case 3:
                    AddToken(winner, "Blackmail", 1);
                    AddSupport(winner, 1);
                    AtribuirTownHall(winner);
                    AtualizeTownHall();
                    break;

                case 4:
                    AddSupport(winner, 6);
                    AtribuirCathedral(winner);
                    AtualizeCathedral();
                    break;

                case 5:
                    AddToken(winner, "Gold", 3);
                    AddSupport(winner, 5);
                    AtribuirPlantation(winner);
                    AtualizePlantation();
                    break;

                case 6:
                    AddToken(winner, "Gold", 5);
                    AddSupport(winner, 3);
                    AtribuirMarket(winner);
                    AtualizeMarket();
                    break;

                case 7:
                    AddSupport(winner, 10);
                    break;

                case 8:
                    AddToken(winner, "Blackmail", 2);
                    break;

                case 9:
                    MorstrarFormDeEscolha("Spy", winner);
                    break;

                case 10:
                    MorstrarFormDeEscolha("Apothecary", winner);
                    break;

                case 11:
                    AddToken(winner, "Threat", 1);
                    AddSupport(winner, 3);
                    break;
            }
        }

        public void ExibirJogador(int jogador)
        {
            switch (jogador)
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
            this.Ameaças.Text = "" + Threats[jogador-1];
            this.Chantagens.Text = "" + Blackmails[jogador-1];
            this.Ouro.Text = "" + Golds[jogador-1];
            this.Text = "PLAYER " + jogador;
            

            ShowSupport(jogador);
        }

        public void ShowSupport(int player)
        {
            int valor = Support[player - 1] % 100;

            switch (player)
            {
                case 1:
                    this.RedIcon.Visible = true;
                    this.BlueIcon.Visible = false;
                    this.GreenIcon.Visible = false;
                    this.YellowIcon.Visible = false;
                    this.RedIcon.Location = new System.Drawing.Point(Positions[valor, 0], Positions[valor, 1]);
                    break;

                case 2:
                    this.RedIcon.Visible = false;
                    this.BlueIcon.Visible = true;
                    this.GreenIcon.Visible = false;
                    this.YellowIcon.Visible = false;
                    this.BlueIcon.Location = new System.Drawing.Point(Positions[valor, 0], Positions[valor, 1]);
                    break;

                case 3:
                    this.RedIcon.Visible = false;
                    this.BlueIcon.Visible = false;
                    this.GreenIcon.Visible = true;
                    this.YellowIcon.Visible = false;
                    this.GreenIcon.Location = new System.Drawing.Point(Positions[valor, 0], Positions[valor, 1]);
                    break;

                case 4:
                    this.RedIcon.Visible = false;
                    this.BlueIcon.Visible = false;
                    this.GreenIcon.Visible = false;
                    this.YellowIcon.Visible = true;
                    this.YellowIcon.Location = new System.Drawing.Point(Positions[valor, 0], Positions[valor, 1]);
                    break;
            }
        }

        public void Labels()
        {
            int num1 = CalcularRecurso("threats");
            int num2 = CalcularRecurso("blackmails");
            int num3 = CalcularRecurso("gold");

            this.Ameaças.Text = "" + num1;
            this.Chantagens.Text = "" + num2;
            this.Ouro.Text = "" + num3;
        }

        public void InitializePositions()
        {
            for(int i = 0; i < 100; i++)
            {
                if (i == 0)
                {
                    Positions[i, 0] = 534;
                    Positions[i, 1] = 22;
                }
                else if (i < 25)
                {
                    if (i%5 == 0)
                    {
                        Positions[i, 0] = Positions[i - 5, 0] + 119;
                        if (i == 10)
                            Positions[i, 0]--;
                    }
                    else if ((i - 1)%5 == 0)
                    {
                        Positions[i, 0] = Positions[i - 1, 0] + 30;
                    }
                    else 
                        Positions[i, 0] = Positions[i - 1, 0] + 20;

                    Positions[i, 1] = 22;
                }
                else if (i == 25)
                {
                    Positions[i, 0] = 1128;
                    Positions[i, 1] = 22;
                }
                else if (i < 50)
                {
                    Positions[i, 0] = 1128;
                    if (i % 5 == 0)
                    {
                        Positions[i, 1] = Positions[i - 5, 1] + 119;
                        ///*
                        if (i == (30))
                            Positions[i, 1] --;//*/
                    }
                    else if ((i - 1) % 5 == 0)
                    {
                        Positions[i, 1] = Positions[i - 1, 1] + 30;
                        ///*
                        if (i == (46))
                            Positions[i, 1]--;//*/
                    }
                    else
                        Positions[i, 1] = Positions[i - 1, 1] + 20;
                }
                else if (i == 50)
                {
                    Positions[i, 0] = 1128;
                    Positions[i, 1] = 616;
                }
                else if (i < 75)
                {
                    if (i % 5 == 0)
                    {
                        Positions[i, 0] = Positions[i - 5, 0] - 119;
                        ///*
                        if (i == 65)
                            Positions[i, 0] = Positions[i, 0] +2;//*/
                        ///*
                        if (i == 70)
                            Positions[i, 0] = Positions[i, 0] -1;//*/
                    }
                    else if ((i - 1) % 5 == 0)
                    {
                        Positions[i, 0] = Positions[i - 1, 0] - 29;
                        ///*
                        if (i == 66)
                            Positions[i, 0] = Positions[i, 0] - 1;//*/
                    }
                    else
                        Positions[i, 0] = Positions[i - 1, 0] - 20;

                    Positions[i, 1] = 616;
                }
                else if (i == 75)
                {
                    Positions[i, 0] = 534;
                    Positions[i, 1] = 616;
                }
                else
                {
                    Positions[i, 0] = 534;
                    if (i % 5 == 0)
                    {
                        Positions[i, 1] = Positions[i - 5, 1] - 119;
                        ///*
                        if (i == 95)
                            Positions[i, 1] = Positions[i, 1] + 2;//*/
                    }
                    else if ((i - 1) % 5 == 0)
                    {
                        ///*
                        if (i == 91)
                            Positions[i, 1] = Positions[i - 1, 1] - 29;
                        else
                            Positions[i, 1] = Positions[i - 1, 1] - 30;
                    }
                    else
                    {
                        Positions[i, 1] = Positions[i - 1, 1] - 20;
                        if (i == 87)
                            Positions[i, 1] = Positions[i, 1] +1;
                    }
                }
            }
        }

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

        public void ResetUnconfirmed()
        {
            for (int a = 0; a < 12; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    UnConfirmed[a, b] = 0;
                }
            }
        }

        public void ConfirmUnconfirmed()
        {
            int i, j;
            for (i = 0; i < 12; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Subornos[i, j, Turn - 1] = UnConfirmed[i, j];
                }
            }

            if (Turn < maximum) Turn++;
            else if (Turn == maximum)
            {
                Turn = 1;
                EmptyTokens();
                AnalizeBids();
                Patronage(1);
                Patronage(2);
                Patronage(3);
                Patronage(4);
                CleanBids();
            }
            else
                MessageBox.Show("An error has occured!");
            ExibirJogador(Turn);
            ResetUnconfirmed();
            Labels();
        }

        public void MostrarFormSecundária(string pessoa)
        {
            int aux = Person2Number(pessoa);

            int num1 = CalcularRecurso("threats");
            int num2 = CalcularRecurso("blackmails");
            int num3 = CalcularRecurso("gold");

            Tokens ofertas = new Tokens(pessoa, num3, num2, num1, UnConfirmed);
            ofertas.ShowDialog();

            UnConfirmed[aux, 0] = ofertas.Uncertain[aux, 0];
            UnConfirmed[aux, 1] = ofertas.Uncertain[aux, 1];
            UnConfirmed[aux, 2] = ofertas.Uncertain[aux, 2];

            Labels();

        }

        public void MorstrarFormDeEscolha(string pessoa, int player)
        {
            int aux = Person2Number(pessoa);

            Selecttion escolha = new Selecttion(Plantation, Tavern, Cathedral, Fortress, Harbor, TownHall, Market, aux, player);
            escolha.ShowDialog();

            Plantation = escolha.Plantation;
            Tavern = escolha.Tavern;
            Cathedral = escolha.Cathedral;
            Fortress = escolha.Fortress;
            Harbor = escolha.Harbor;
            TownHall = escolha.TownHall;
            Market = escolha.Market;

            Atualizar();
        }

        public void EmptyTokens()
        {
            for (int i = 0; i < 4; i++)
            {
                Threats[i] = 0;
                Blackmails[i] = 0;
                Golds[i] = 0;
            }
        }

        public void Patronage(int player)
        {
            int tokens = 0;
            tokens += Threats[player - 1];
            tokens += Blackmails[player - 1];
            tokens += Golds[player - 1];
            if (tokens < 5) AddToken(player, "Gold", 5 - tokens);
        }

        public void AddSupport(int player, int times)
        {
            Support[player - 1] += times;
        }

        public void AddToken(int player, string token, int times)
        {
            switch (token)
            {
                case "Gold":
                    Golds[player - 1] += times;
                    break;

                case "Blackmail":
                    Blackmails[player - 1] += times;
                    break;

                case "Threat":
                    Threats[player - 1] += times;
                    break;
            }
        }

        public void AtribuirFortress(int player)
        {
            for (int i = 0; i < 8; i++)
            {
                if (Fortress[i] == 0)
                {
                    Fortress[i] = player;
                    break;
                }
            }
        }

        public void AtribuirHarbor(int player)
        {
            for (int i = 0; i < 6; i++)
            {
                if (Harbor[i] == 0)
                {
                    Harbor[i] = player;
                    break;
                }
            }
        }

        public void AtribuirTavern(int player)
        {
            for (int i = 0; i < 4; i++)
            {
                if (Tavern[i] == 0)
                {
                    Tavern[i] = player;
                    break;
                }
            }
        }

        public void AtribuirTownHall(int player)
        {
            for (int i = 0; i < 7; i++)
            {
                if (TownHall[i] == 0)
                {
                    TownHall[i] = player;
                    break;
                }
            }
        }

        public void AtribuirCathedral(int player)
        {
            for (int i = 0; i < 7; i++)
            {
                if (Cathedral[i] == 0)
                {
                    Cathedral[i] = player;
                    break;
                }
            }
        }

        public void AtribuirPlantation(int player)
        {
            for (int i = 0; i < 6; i++)
            {
                if (Plantation[i] == 0)
                {
                    Plantation[i] = player;
                    break;
                }
            }
        }

        public void AtribuirMarket(int player)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Market[i] == 0)
                {
                    Market[i] = player;
                    break;
                }
            }
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

        public int CalcularRecurso(string recurso)
        {
            int a, b;
            switch (recurso)
            {
                case "threats":
                    a = 0;
                    b = Threats[Turn - 1];
                    break;

                case "blackmails":
                    a = 1;
                    b = Blackmails[Turn - 1];
                    break;

                case "gold":
                    a = 2;
                    b = Golds[Turn - 1];
                    break;

                default:
                    a = 0;
                    b = 0;
                    break;
            }
            for (int i = 0; i < 12; i++)
            {
                b -= UnConfirmed[i, a];
            }
            return b;
        }

        public void CleanBids()
        {
            for (int a = 0; a < 12; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        Subornos[a, b, c] = 0;
                    }
                }
            }
        }

        private void ResetBids_Click(object sender, EventArgs e)
        {
            ResetUnconfirmed();
            Labels();
        }

        private void ConfirmBids_Click(object sender, EventArgs e)
        {
            int ocupied=0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (UnConfirmed[i, j] != 0)
                    {
                        ocupied++;
                        break;
                    }
                }
            }
            if (Ameaças.Text == "0" & Chantagens.Text == "0" & Ouro.Text == "0")
            {
                if (ocupied <= 6)
                {
                    ConfirmUnconfirmed();
                }
                else
                    MessageBox.Show("   You can not bid on more than SIX characters in one turn!");
            }
            else
                MessageBox.Show("   You must use all your tokens each turn!");
        }

        private void GenericBid_Click(object sender, EventArgs e)
        {
            var origem = (Button)sender;
            MostrarFormSecundária(origem.Tag.ToString());
        }

        private void Generic_MouseEnter(object sender, EventArgs e)
        {
            var origem = (Panel)sender;
            ExibirJogador(Convert.ToUInt16(origem.Tag));
        }

        private void Generic_MouseLeave(object sender, EventArgs e)
        {
            ExibirJogador(Turn);
            Labels();
        }
    }
}
