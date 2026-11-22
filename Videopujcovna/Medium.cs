using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videopujcovna
{
    public class Medium
    {
        public string Nazev { get; set; }
        public string Zanr { get; set; }
        public int Cena { get; set; }
        public string Typ {
            get { return this.GetType().Name; }
        }

        public Medium(string nazev, string zanr, int cena)
        {
            this.Nazev = nazev;
            this.Zanr = zanr;
            this.Cena = cena;
        }
    }

    public class CD : Medium
    {
        public string Interpret { get; set; }

        public CD(string nazev, string zanr, string interpret, int cena) : base(nazev, zanr, cena)
        {
            this.Interpret = interpret;
        }
    }

    public class Dvd : Medium
    {
        public string Reziser { get; set; }

        public Dvd(string nazev, string zanr, string reziser, int cena) : base(nazev, zanr, cena)
        {
            this.Reziser = reziser;
        }
    }
}
