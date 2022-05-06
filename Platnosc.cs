using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WersjaDrugaProjektu
{
    public class Platnosc
    {
        public List<Klient> IdentyfikatorPlatnosci { get; set; } = new List<Klient>();
        public List<Rachunek> IdentyfikatorRachunku { get; set; } = new List<Rachunek>();
        public void CzyZaplacono() //Pokazuje, czy płatność się powiodła, czy nie
        {

        }
    }
}
