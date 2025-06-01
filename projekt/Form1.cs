using System;
using System.IO;
using System.Windows.Forms;

namespace KolkoIKrzyzyk
{
    public partial class Form1 : Form
    {
        string kto = "X";
        int[] plansza = new int[9];
        int punktyX = 0, punktyO = 0;
        int rundy = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Tura gracza: X";
        }

        private void KliknieciePrzycisku(object sender, EventArgs e)
        {
            Button klikniety = (Button)sender;
            int numer = Convert.ToInt32(klikniety.Name.Replace("button", "")) - 1;

            if (plansza[numer] == 0)
            {
                klikniety.Text = kto;
                plansza[numer] = kto == "X" ? 1 : 2;
                klikniety.Enabled = false;

                if (Wygrana())
                {
                    MessageBox.Show("Wygrał gracz: " + kto);
                    if (kto == "X") punktyX++; else punktyO++;
                    buttonReset.Text = "X: " + punktyX + " | O: " + punktyO;
                    ZablokujPrzyciski();
                    ZapiszDoPliku(kto);
                    return;
                }

                if (Remis())
                {
                    MessageBox.Show("Remis!");
                    ZapiszDoPliku("Remis");
                    ResetPoRemisie(1); // REKURENCJA
                }

                kto = kto == "X" ? "O" : "X";
                this.Text = "Tura gracza: " + kto;
            }
        }

        private bool Wygrana()
        {
            int[,] wygrane = new int[,]
            {
                {0,1,2}, {3,4,5}, {6,7,8},
                {0,3,6}, {1,4,7}, {2,5,8},
                {0,4,8}, {2,4,6}
            };

            for (int i = 0; i < 8; i++)
            {
                int a = wygrane[i, 0], b = wygrane[i, 1], c = wygrane[i, 2];
                if (plansza[a] != 0 && plansza[a] == plansza[b] && plansza[b] == plansza[c])
                    return true;
            }

            return false;
        }

        private bool Remis()
        {
            for (int i = 0; i < 9; i++)
                if (plansza[i] == 0) return false;
            return true;
        }

        private void KlikniecieReset(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++) plansza[i] = 0;

            for (int i = 1; i <= 9; i++)
            {
                Button p = (Button)Controls["button" + i];
                p.Text = "";
                p.Enabled = true;
            }

            kto = "X";
            this.Text = "Tura gracza: X";
            buttonReset.Text = "Restart";
        }

        private void ZablokujPrzyciski()
        {
            for (int i = 1; i <= 9; i++)
                Controls["button" + i].Enabled = false;
        }

        private void ZapiszDoPliku(string wynik)
        {
            rundy++;
            using (StreamWriter plik = new StreamWriter("wyniki.txt", true))
            {
                plik.WriteLine("Runda: " + rundy + " | Wynik: " + wynik);
            }
        }

        private void ResetPoRemisie(int licznik)
        {
            if (licznik <= 0)
            {
                KlikniecieReset(null, null);
                return;
            }
            else
            {
                ResetPoRemisie(licznik - 1);
            }
        }
    }
}
