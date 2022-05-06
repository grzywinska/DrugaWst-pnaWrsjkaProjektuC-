using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WersjaDrugaProjektu
{
    public class Apartment
    {
        public int NumerPokoju { get; set; }
        public bool StatusPokoju { get; set; } //można dać string i dane wolny, zajęty, sprzątanie
        public List<Serwer> IdentyfikatorSerwera { get; set; } = new List<Serwer>(); // to może bardziej pasować do klasy serwer
        public List<Klient> IdentyfikatorKlienta { get; set; } = new List<Klient>();
        public void SzczegolyPokoju() //ta metoda zawiera szczegóły pokoju wraz z klientem i liczbą miejsc
        {
            int iloscMiejscWPokoju;
            bool czyJestKlimatyzacja;
            int przypisanyKlient;
        }
        public void StatusDostepnosciPokoju() //ta metoda określa, czy pokój jest zajęty, czy nie
        {
            bool czyJestDostepny = true;
        }

    }
}
