using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreiranjeRacuna
{
    public class Stavka
    {
        public string NazivProizvoda { get; set; }
        public string MjernaJedinica { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public string Suma { get; set; }
        /// <summary>
        /// Konstruktor forme koji prima podatke o stavki te računa i formatira ukupni iznos te stavke
        /// </summary>
        public Stavka(string NazivProizvoda, string MjernaJedinica, double Cijena, int Kolicina)
        {
            this.NazivProizvoda = NazivProizvoda;
            this.MjernaJedinica = MjernaJedinica;
            this.Cijena = Cijena;
            this.Kolicina = Kolicina;
            Suma = (Kolicina * Cijena).ToString("n2");
        }

    }
}
