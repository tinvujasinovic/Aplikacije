using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriranjeLozinke
{
    public class LozinkaKorisnika
    {
        public string Lozinka { get; set; }


        //generiranje lozinke koja se pridodaje korisniku kod registracije
        public string GenerirajLozinku()
        {
            string lozinka = "";

            string malaSlova = "abcdefghijklmnopqrstuvwxyz";
            string velikaSlova = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string brojevi = "0123456789";

            Random random = new Random();

            for (int i = 1; i <= 3; i++)
            {
                lozinka = lozinka.Insert(random.Next(lozinka.Length), malaSlova[random.Next(malaSlova.Length - 1)].ToString());
            }

            for (int i = 1; i <= 3; i++)
            {
                lozinka = lozinka.Insert(random.Next(lozinka.Length), velikaSlova[random.Next(velikaSlova.Length - 1)].ToString());
            }
            for (int i = 1; i <= 3; i++)
            {
                lozinka = lozinka.Insert(random.Next(lozinka.Length), brojevi[random.Next(brojevi.Length - 1)].ToString());
            }

            Lozinka = lozinka;

            return Lozinka;
        }
    }
}
