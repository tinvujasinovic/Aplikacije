using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsni
{
    class Program
    {
        static int trenutnoNajbolje;
        static string putanjaDatoteke;
        static int brojPoveznica;
        static int brojFrekvencija;
        static double Tau0;
        static double[,] Tau;
        static int[,] poveznice;
        static double alfa, ro;
        static int brojMrava;
        static Mrav[] poljeMrava;
        static double[,] matricaVjerojatnosti;
        static double vjerojatnost;
        static double sumaVjerojatnosti;
        static double deltaTau;
        static int iteracije;
        static double tauMin;
        static double tauMax;
        static int[] brojPonavljanja;
        static double[,] etaMatrica;
        static double beta;

        static void Main(string[] args)
        {
            putanjaDatoteke = OtvoriDatoteku();
            Tau0 = 1;
            tauMax = 1000;
            tauMin=0.001*Tau0;

            Console.Write("Upišite parametar alfa: ");
            alfa = double.Parse(Console.ReadLine());

            Console.Write("Upišite parametar beta: ");
            beta = double.Parse(Console.ReadLine());

            Console.Write("Upišite parametar ro: ");
            ro = double.Parse(Console.ReadLine());

            Console.Write("Upišite broj poveznica: ");
            brojPoveznica = int.Parse(Console.ReadLine());

            Console.Write("Upišite broj frekvencija: ");
            brojFrekvencija = int.Parse(Console.ReadLine());

            Console.Write("Upišite broj mrava: ");
            brojMrava = int.Parse(Console.ReadLine());

            Console.Write("Upišite broj iteracija; ");
            iteracije = int.Parse(Console.ReadLine());

            Tau = new double[brojPoveznica, brojFrekvencija];

            for (int y = 0; y < brojPoveznica; y++)
            {
                for (int x = 0; x < brojFrekvencija; x++)
                {
                    Tau[y, x] = Tau0;
                }
            }

            brojPonavljanja = new int[brojFrekvencija];
            for (int i = 0; i < brojFrekvencija; i++)
            {
                brojPonavljanja[i] = 0;
            }

            etaMatrica = new double[brojPoveznica, brojFrekvencija];
            for (int l = 0; l < brojPoveznica; l++)
            {
                for (int f = 0; f < brojFrekvencija; f++)
                {
                    etaMatrica[l, f] = 0.5;
                }
            }

            poveznice = new int[brojPoveznica, brojPoveznica];

            int n = 0, m = 0;
            int counter = brojPoveznica;
            while (counter > 0)
            {
                Console.Write("Upiši vrijednost c(" + (m + 1) + "," + (n + 1) + "): ");
                try
                {
                    int unos = int.Parse(Console.ReadLine());
                    poveznice[m, n] = unos;
                    n++;
                    if (n == brojPoveznica)
                    {
                        counter--;
                        n = 0;
                        m++;
                    }
                }
                catch
                {
                    Console.WriteLine("Upiši broj!");
                }
            }

            poljeMrava = new Mrav[brojMrava];

            for (int i = 0; i < brojMrava; i++)
            {
                poljeMrava[i] = new Mrav();
            }

            matricaVjerojatnosti = new double[brojPoveznica,brojFrekvencija];

            for (int X = 0; X < iteracije; X++)
            {
                for (int l = 0; l < brojPoveznica; l++)
                {
                    for (int f = 0; f < brojFrekvencija; f++)
                    {
                        sumaVjerojatnosti = 0;
                        vjerojatnost = Math.Pow(Tau[l, f],alfa)* Math.Pow(etaMatrica[l,f],beta);
                        for (int i = 0; i < brojFrekvencija; i++)
                        {
                            sumaVjerojatnosti += (Math.Pow(Tau[l, i], alfa))*(Math.Pow(etaMatrica[l,i],beta));
                        }
                        matricaVjerojatnosti[l, f] = vjerojatnost / sumaVjerojatnosti;
                    }
                }

                Random rand = new Random();
                for (int j = 0; j < brojMrava; j++)
                {
                    for (int i = 0; i < brojPoveznica; i++)
                    {
                        double slucajni;
                        slucajni = rand.NextDouble();
                        double min = 0;
                        double max = 0;

                        for (int k = 0; k < brojFrekvencija; k++)
                        {
                            max += matricaVjerojatnosti[i, k];
                            if (slucajni >= min && slucajni < max)
                            {
                                brojPonavljanja[k]++;
                                poljeMrava[j].rjesenje[i] = k;
                                max = 0;
                                min = 1;
                                continue;
                            }
                            else
                            {
                                min += matricaVjerojatnosti[i, k];
                            }
                        }
                    }
                }

                int[] poljeSuma = new int[brojMrava];

                for (int z = 0; z < brojMrava; z++)
                {
                    int prvaFreq, drugaFreq, prvaPoveznica, drugaPoveznica, kazna, sumaKazni;
                    prvaPoveznica = 0;
                    drugaPoveznica = 0;
                    kazna = 0;
                    sumaKazni = 0;
                    for (int i = 0; i < brojPoveznica; i++)
                    {
                        for (int k = 0; k < brojPoveznica; k++)
                        {
                            if (k == i)
                            {
                                continue;
                            }
                            prvaPoveznica = i;
                            drugaPoveznica = k;
                            prvaFreq = poljeMrava[z].rjesenje[i];
                            drugaFreq = poljeMrava[z].rjesenje[k];
                            if (Math.Abs(prvaFreq - drugaFreq) < poveznice[prvaPoveznica, drugaPoveznica])
                            {
                                kazna = poveznice[prvaPoveznica, drugaPoveznica] - Math.Abs(prvaFreq - drugaFreq);
                                sumaKazni += kazna;
                            }
                        }
                    }
                    poljeSuma[z] = sumaKazni;
                }

                double minSuma = 10000;
                trenutnoNajbolje = 0;
                for (int i = 0; i < brojMrava; i++)
                {
                    if (poljeSuma[i] < minSuma)
                    {
                        minSuma = poljeSuma[i];
                        trenutnoNajbolje = i;
                    }  
                }

                for (int l = 0; l < brojPoveznica; l++)
                {
                    for (int f = 0; f < brojFrekvencija; f++)
                    {
                        double trenutnaVrijednost = Tau[l, f];
                        Tau[l, f] = (1 - ro) * trenutnaVrijednost;
                        if (Tau[l, f] < tauMin)
                        {
                            Tau[l, f] = tauMin;
                        }
                    }
                }
                for (int p = 0; p < brojPoveznica; p++)
                { 
                    int indeks = poljeMrava[trenutnoNajbolje].rjesenje[p];
                    deltaTau = 1 / (minSuma+0.1);
                    Tau[p, indeks]+=deltaTau;
                    if (Tau[p, indeks] > tauMax)
                    {
                        Tau[p, indeks] = tauMax;
                    }
                }

                for (int l = 0; l < brojPoveznica; l++)
                {
                    for (int f = 0; f < brojFrekvencija; f++)
                    {
                        double vrijednost = etaMatrica[l, f];
                        etaMatrica[l, f] = vrijednost / (brojPonavljanja[f] + 1);
                    }
                }


                for (int i = 0; i < brojFrekvencija; i++)
                {
                    brojPonavljanja[i] = 0;
                }
                if (minSuma == 0)
                {
                    UpisiTekst(putanjaDatoteke, minSuma.ToString());
                    break;
                }
                UpisiTekst(putanjaDatoteke, minSuma.ToString());
            }
        }

        class Mrav
        {
            public int[] rjesenje;
            public Mrav()
            {
                rjesenje = new int[brojPoveznica];
            }
        }

        //funkcija za stvaranje nove .txt datoteke 
        static string OtvoriDatoteku()
        {
            DateTime dateTime = DateTime.Now;
            string nazivDatoteke = dateTime.ToString();
            string ispravanNazivDatoteke = nazivDatoteke.Replace(":", "-");

            string putanjaMape = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "files");
            if (!Directory.Exists(putanjaMape))
            {
                Directory.CreateDirectory(putanjaMape);
            }

            string putanjaDatoteke = Path.Combine(putanjaMape, ispravanNazivDatoteke + ".txt");

            var datoteka = File.CreateText(putanjaDatoteke);
            datoteka.Close();

            return putanjaDatoteke;
        }

        //funkcija za upis teksta u datoteku
        static void UpisiTekst(string putanjaDatoteke, string vrijednost)
        {
            using (StreamWriter sw = File.AppendText(putanjaDatoteke))
            {
                sw.WriteLine(vrijednost);
            }
        }
    }
}

   
