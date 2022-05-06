using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WersjaDrugaProjektu
{
    public class Rachunek
    {
        public int IdentyfikatorRachunku { get; set; }
        public List<Serwer> IdentyfikatorZamowienia { get; set; } = new List<Serwer>();
        public List<Pokoj> CalyRachunek { get; set; } = new List<Pokoj>();
        public void PelnaKwota() // ta metoda oblicza rachunek dla określoneo pokoju/wynajmu
        {

        }
    }
}
