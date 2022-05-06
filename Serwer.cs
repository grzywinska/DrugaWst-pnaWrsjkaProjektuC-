using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WersjaDrugaProjektu
{
    //Zawiera szczegóły serwera, tabelę, do której są przypisane, kolejność, która aktualnie obsługuje, itp.
    public class Serwer : Employees
    {
        public int IdentyfikatorSerwera { get; set; }
        public int IdentyfikatorZamowienia { get; set; }

    }
}
