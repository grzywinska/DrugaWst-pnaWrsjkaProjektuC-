using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WersjaDrugaProjektu
{
    public class Klient
    {
        public int IdentyfikatorKlienta { get; set; }
        public string DaneKlienta { get; set; }
        public decimal NumerRachunku { get; set; }
        public int NumerRezerwacji { get; set; }
        public string RodzajPlatnosci { get; set; }
        public void SzczegoloweDaneKlienta() //przedstawia szczegóły klienta
        {
            string imie;
            string nazwisko;
            int numerTelefonu;
        }
        public void RezerwowanyPokoj() //Ta metoda zawiera pozycje, które są zamawiane przez klienta
        {

        }
        public void StatusPlatnosci() //mówi, czy klient zapłacił, czy nie.
        {
            bool czyZaplacono;
        }
    }
}
