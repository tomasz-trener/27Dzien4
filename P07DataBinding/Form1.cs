using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik[] zawodnicy = mz.WczytajZawodnikow();

            lbDane.DataSource = zawodnicy; // wiązanie danych 
            lbDane.DisplayMember = "ImieNazwisko";
        }

        private void btnPodajTemperature_Click(object sender, EventArgs e)
        {
            // checmy odczytać, który zawodnik jest aktualnie zaznaczony 
            Zawodnik zaznaczony= (Zawodnik)lbDane.SelectedItem;

            ManagerPogody mp = new ManagerPogody(Jednostka.Celsjusz);
            double temp = mp.PodajTemperature(zaznaczony.Kraj);

            MessageBox.Show(Convert.ToString(temp));

            lblRaport.Text = String.Format("W kraju {0}, skąd pochodzi zawodnik {1} temperatura wynosi {2}",
                zaznaczony.Kraj, zaznaczony.ImieNazwisko, temp) ;

            lblRaport.MaximumSize = new Size(250, 0);
            lblRaport.AutoSize = true;
        }
    }
}
