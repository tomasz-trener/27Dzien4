using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03ZadanieKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJeden_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "1";
        }

        private void btnDwa_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "2";
        }

        private void btnPrzycisk_Click(object sender, EventArgs e)
        {
            Button tenKliekniety = (Button)sender;
            txtWyswietlacz.Text += tenKliekniety.Text;
        }

        private void btnRownaSie_Click(object sender, EventArgs e)
        {

        }
    }
}
