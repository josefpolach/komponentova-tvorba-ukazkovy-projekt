using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Videopujcovna
{
    public class Zakaznik
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Adresa { get; set; }

        public BindingList<Medium> Polozky { get; set; }

        public Zakaznik(string jmeno, string prijmeni, string adresa)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Adresa = adresa;
            this.Polozky = new BindingList<Medium>();
        }

    }
}
