﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P07DataBinding
{
    internal class ManagerZawodnikow
    {
        private Zawodnik[] zawodnicyCache;
        public Zawodnik[] WczytajZawodnikow()
        {
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(url);

            string[] wiersze = dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Zawodnik[] zawodnicy = new Zawodnik[wiersze.Length - 1];

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');

                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = Convert.ToInt32(komorki[0]);

                if (!string.IsNullOrEmpty(komorki[1]))
                    z.Id_trenera = Convert.ToInt32(komorki[1]);

                z.Imie = komorki[2];
                z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                z.Wzrost = Convert.ToInt32(komorki[6]);
                z.Waga = Convert.ToInt32(komorki[7]);

                zawodnicy[i - 1] = z;
            }
            zawodnicyCache = zawodnicy;
            return zawodnicy;
        }


        public string[] PodajKraje()
        {

            // unikam ponownego wczytania danych dzieki zastosowaniu cache'u
            // Zawodnik[] zawodnicy = WczytajZawodnikow();

            Zawodnik[] zawodnicy = zawodnicyCache;

            if (zawodnicyCache == null)
                throw new Exception("Najpierw wczytaj zawodnikow");

            HashSet<string> kraje = new HashSet<string>();
            foreach (var z in zawodnicyCache)
                kraje.Add(z.Kraj);

            return kraje.ToArray();
        }
    }
}
