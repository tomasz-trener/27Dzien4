﻿using P06ZadaniePogoda.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06ZadaniePogoda
{
    public partial class Form1 : Form
    {
        private /*const*/ string sciezkaMiasta = "C:\\dane\\miasta.txt";

        public Form1()
        {
            InitializeComponent();
            wczytajMiasta();
        }

        private void wczytajMiasta()
        {
            string[] miasta = File.ReadAllLines(sciezkaMiasta, Encoding.UTF8);

            cbMiasta.Items.Clear();
            // mozemy podobnie jak poprzednio w listbox uzupelnic w petli element po elemencie
            // zamiast tego mozemy zrobic to w jednej metodzie 
            cbMiasta.Items.AddRange(miasta);

        }


        private void btnPodajTemperature_Click(object sender, EventArgs e)
        {
            Jednostka wybranaJednostka = Jednostka.Celsjusz;
            if (rbFrenheit.Checked)
                wybranaJednostka = Jednostka.Farenheit;
            else if (rbKelvin.Checked)
                wybranaJednostka = Jednostka.Kelvin;

            string wybraneMiasto = cbMiasta.Text;

            ManagerPogody mp = new ManagerPogody(wybranaJednostka);
            double temp = mp.PodajTemperature(wybraneMiasto);

            lblRaport.Text = string.Format("Temperatura w mieście {0} wynosi {1} w jednostce {2}",
                wybraneMiasto, temp, wybranaJednostka);

            // Ustawienie obrazka 
            ManagerPogody mpCelsjusz = new ManagerPogody(Jednostka.Celsjusz);
            double tempCelsjusz = mpCelsjusz.PodajTemperature(wybraneMiasto);
            if (tempCelsjusz < 0)
                pbObrazek.Image = Resources.snow;
            else if (tempCelsjusz < 11)
                pbObrazek.Image = Resources.rain;
            else
                pbObrazek.Image = Resources.sun;
        }

        private void btnOtworzPlik_Click(object sender, EventArgs e)
        {
            ofdPliki.Filter = "Pliki tekstowe (*.txt)|*.txt|Pliki exe|*.exe";

            if (ofdPliki.ShowDialog() == DialogResult.OK)
            {
                sciezkaMiasta= ofdPliki.FileName;
                wczytajMiasta();
            }
        }
    }
}
