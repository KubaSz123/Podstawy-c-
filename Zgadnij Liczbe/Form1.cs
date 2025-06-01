using System;
using System.IO;
using System.Windows.Forms;

namespace ZgadnijLiczbe
{
    public partial class Form1 : Form
    {
        int wylosowana;
        int liczbaProb = 0;
        const int maxProby = 10;
        int[] ostatnieProby = new int[10];

        public Form1()
        {
            InitializeComponent();
            Restartuj();
        }

        private void btnSprawdz_Click(object sender, EventArgs e)
        {
            int wpisana;

            if (!int.TryParse(txtLiczba.Text, out wpisana))
            {
                lblWynik.Text = "Wpisz poprawną liczbę!";
                return;
            }

            if (liczbaProb < maxProby)
            {
                ostatnieProby[liczbaProb] = wpisana;
            }

            liczbaProb++;
            lblLicznik.Text = "Próba: " + liczbaProb + " z " + maxProby;

            if (wpisana == wylosowana)
            {
                lblWynik.Text = "Brawo! Zgadłeś.";
                lblWynik.BackColor = System.Drawing.Color.LightGreen;
                ZapiszDoPliku(wpisana);
                btnSprawdz.Enabled = false;
                return;
            }
            else if (wpisana < wylosowana)
            {
                lblWynik.Text = "Za mało!";
            }
            else
            {
                lblWynik.Text = "Za dużo!";
            }

            // 🔥❄️ Podpowiedź: ciepło / zimno
            int roznica = Math.Abs(wpisana - wylosowana);
            if (roznica > 30)
            {
                lblWynik.Text += "\nZimno ❄️";
                lblWynik.BackColor = System.Drawing.Color.LightBlue;
            }
            else if (roznica > 10)
            {
                lblWynik.Text += "\nCiepło 🌤";
                lblWynik.BackColor = System.Drawing.Color.Khaki;
            }
            else
            {
                lblWynik.Text += "\nGorąco 🔥";
                lblWynik.BackColor = System.Drawing.Color.OrangeRed;
            }

            if (liczbaProb >= maxProby && wpisana != wylosowana)
            {
                lblWynik.Text += "\nZa dużo prób. Resetuję grę.";

                // pokaż próby z tablicy
                lblWynik.Text += "\nTwoje próby: ";
                for (int i = 0; i < maxProby; i++)
                {
                    lblWynik.Text += ostatnieProby[i] + (i < maxProby - 1 ? ", " : "");
                }

                RestartujRekurencyjnie(1);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restartuj();
        }

        private void Restartuj()
        {
            Random rand = new Random();
            wylosowana = rand.Next(1, 101); // losuje 1–100
            liczbaProb = 0;
            txtLiczba.Text = "";
            lblWynik.Text = "Zgadnij liczbę od 1 do 100";
            lblLicznik.Text = "Próba: 0 z " + maxProby;
            lblWynik.BackColor = System.Drawing.Color.Transparent;
            btnSprawdz.Enabled = true;

            for (int i = 0; i < maxProby; i++)
            {
                ostatnieProby[i] = 0;
            }
        }

        private void RestartujRekurencyjnie(int i)
        {
            if (i > 0)
                RestartujRekurencyjnie(i - 1);
            else
                Restartuj();
        }

        private void ZapiszDoPliku(int zgadnieta)
        {
            using (StreamWriter sw = new StreamWriter("wynik.txt", true))
            {
                sw.WriteLine("Zgadnięta liczba: " + zgadnieta + " | Data: " + DateTime.Now);
            }
        }
    }
}
