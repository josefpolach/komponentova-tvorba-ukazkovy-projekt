using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Videopujcovna
{
    public static class Databaze
    {
        public static BindingList<Zakaznik> Zakaznici { get; set; }
        public static BindingList<Medium> Sklad { get; set; }

        static Databaze()
        {
            Zakaznici = new BindingList<Zakaznik>();
            Sklad = new BindingList<Medium>();

            Zakaznici.Add(new Zakaznik("Honza", "Novák", "Praha"));
            Zakaznici.Add(new Zakaznik("Pepa", "Vomáčka", "Kladno"));
            Zakaznici.Add(new Zakaznik("Karel", "Barel", "Benešov"));
            Zakaznici.Add(new Zakaznik("František", "Dobrota", "Blízká Vesnice"));

            Sklad.Add(new CD("František Dobrota", "pop","Buty",25));
            Sklad.Add(new CD("Sehnsucht", "rock", "Rammstein", 25));
            Sklad.Add(new CD("Země plná trpaslíků", "rock", "Kabát", 30));
            Sklad.Add(new CD("Vision of Light", "rock", "Steve Vai", 25));
            Sklad.Add(new CD("Plná teška", "psycho-hardcore", "Eva a Vašek", 5));

            Sklad.Add(new Dvd("Iron Man","scifi","Jon Favreau",25));
            Sklad.Add(new Dvd("Pelíšky", "komedie", "Jan Hřebejk", 25));
            Sklad.Add(new Dvd("Top Gun", "akční", "Tony Scott", 25));
            Sklad.Add(new Dvd("Kameňák", "psychologické drama", "Zdeněk Troška", 15));
            Sklad.Add(new Dvd("Star Wars", "scifi", "George Lucas", 25));

        }

        public static void NovyZakaznik(string jmeno, string prijmeni, string adresa) 
        {
            Zakaznici.Add(new Zakaznik(jmeno, prijmeni, adresa));
        }
    }
}
