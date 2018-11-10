using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreiranjeRacuna
{
    public class StavkeRacuna
    {
        private List<string> listaNazivaProizvoda;
        private List<double> listaCijenaProizvoda;
        private List<int> listaKolicinaProizvoda;
        private List<string> listaMjernihNaziv;
        public double Ukupno;

        /// <summary>
        /// Konstruktor forme koji prime liste s podacima kako bi se posložile u jednu listu za ispis
        /// </summary>
        public StavkeRacuna(List<string> listaNazivaProizvoda, List<double> listaCijenaProizvoda, List<int> listaKolicinaProizvoda, List<string> listaMjernihNaziv)
        {
            this.listaNazivaProizvoda = listaNazivaProizvoda;
            this.listaCijenaProizvoda = listaCijenaProizvoda;
            this.listaKolicinaProizvoda = listaKolicinaProizvoda;
            this.listaMjernihNaziv = listaMjernihNaziv;
        }
        /// <summary>
        /// Metoda koja podatke iz lista koje je primila klasa formatira za ispis u DGV preko jedne liste
        /// </summary>
        public List<Stavka> KreirajListuStavki()
        {
            List<Stavka> listaStavki = new List<Stavka>();
            int brojStavki = listaNazivaProizvoda.Count;
            for (int i = 0; i < brojStavki; i++)
            {
                Stavka stavka = new Stavka(listaNazivaProizvoda[i], listaMjernihNaziv[i], listaCijenaProizvoda[i], listaKolicinaProizvoda[i]);
                listaStavki.Add(stavka);
            }

            return listaStavki;
        }
        
    }
}
