using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieKalkulator
{
    internal class Kalkulator
    {

        public double WykonajDzialanie(string rownanie)
        {
            int pozPlus = rownanie.IndexOf('+');
            int pozMinus = rownanie.IndexOf('-');
            int pozMnozenie = rownanie.IndexOf('*');
            int pozDzielnie = rownanie.IndexOf('/');

            int pozZnak;
            if (pozPlus > -1)
                pozZnak = pozPlus;
            else if (pozMinus > -1)
                pozZnak = pozMinus;
            else if (pozMnozenie > -1)
                pozZnak = pozMnozenie;
            else if (pozDzielnie > -1)
                pozZnak = pozDzielnie;
            else
                throw new ArgumentException("Niepoprawne równanie");

            // rozdzielenie rownania na skladowe
            string op = rownanie.Substring(pozZnak, 1);
            int liczba1 = Convert.ToInt32(rownanie.Substring(0, pozZnak));
            int liczba2 = Convert.ToInt32(rownanie.Substring(pozZnak+1));

            //45+3
            //0123

            return wykonajDzialanie(liczba1, liczba2, Convert.ToChar(op));
        }

        // kopiujemy tę metodę z projektu z dnia 3 (P03Zadanie kalkulator)
        private double wykonajDzialanie(int a, int b, char znak)
        {
            double wynik;
            if (znak == '+')
                wynik = a + b;
            else if (znak == '-')
                wynik = a - b;
            else if (znak == '*')
                wynik = a * b;
            else if (znak == '/')
            {
                if (b == 0)
                    return Double.NaN;
                wynik = Convert.ToDouble(a) / b;
            }
            else
            {
                throw new ArgumentException("Nieprawidłowy operator");
            }

            return wynik;
        }
    }
}
