using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WersjaDrugaProjektu
{
    public class Rezerwacja
    {
        public List<Serwer> IdentyfikatorZamowienia { get; set; } = new List<Serwer>();
        public List<Pokoj> IdentyfikatorLozek { get; set; } = new List<Pokoj>();
        //nazwa przedmiotu
        //ilość
        public int IloscLozek { get; set; }
        public List<Klient> DaneKlienta { get; set; } = new List<Klient>();
        public List<Serwer> IdentyfikatorSerwera { get; set; } = new List<Serwer>();
        public void ZarezerwowanyPokoj() //ta metoda porządkuje pozycje wybrane przez użytkownika z menu
        {

        }
    }
}
