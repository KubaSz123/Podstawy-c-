using System;
using System.IO;
using System.Windows.Forms;

namespace ZgadnijLiczbe
{
    public partial class Form1 : Form
    {
        int wylosowana;
        int liczbaProb = 0;
        const int maxProby = 3;

        public Form1()
        {
            InitializeComponent();
            Restartuj();
        }

        private void btnSprawdz_Click(object sender, EventArgs e)
        {
            int wpisana;

            // sprawdź czy wpisano liczbę
            if (!int.TryParse(txtLiczba.Text, out wpisana))
            {
                lblWynik.Text = "Wpisz poprawną liczbę!";
                return;
            }

            liczbaProb++;

            if (wpisana == wylosowana)
            {
                lblWynik.Text = "Brawo! Zgadłeś.";
                ZapiszDoPliku(wpisana);
                btnSprawdz.Enabled = false;
            }
            else if (wpisana < wylosowana)
            {
                lblWynik.Text = "Za mało!";
            }
            else
            {
                lblWynik.Text = "Za dużo!";
            }

            if (liczbaProb >= maxProby && wpisana != wylosowana)
            {
                lblWynik.Text += "\nZa dużo prób. Resetuję grę.";
                RestartujRekurencyjnie(1);
            }
        }

        private void Restartuj()
        {
            Random rand = new Random();
            wylosowana = rand.Next(1, 101); // 1-100
            liczbaProb = 0;
            txtLiczba.Text = "";
            lblWynik.Text = "Zgadnij liczbę od 1 do 100";
            btnSprawdz.Enabled = true;
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

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restartuj();
        }
    }
}
