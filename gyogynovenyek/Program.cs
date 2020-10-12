using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyogynovenyek
{
    class Program
    {
        static List<Noveny> lista = new List<Noveny>();
        static Dictionary<string, int> reszek = new Dictionary<string, int>();
        static void Beolvas()
        {
            StreamReader be = new StreamReader("noveny.csv");
            while (!be.EndOfStream)
            {
                lista.Add(new Noveny(be.ReadLine()));
            }
            be.Close();

            Console.WriteLine("1. Feladat: Növények száma: {0}",lista.Count);
        }

        static void masodik()
        {
            Console.WriteLine("2. feladat: Gyűjthető részek");
            foreach (var i in lista)
            {
                if (!reszek.ContainsKey(i.Resz))
                {
                    reszek.Add(i.Resz, 0);

                }
            }
            foreach (var n in lista)
            {
               reszek[n.Resz]++;
            }
            foreach (var i in reszek)
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
        }
        static void HarmadikFeladat()
        {
            int max = 0;
            string noveny = "";
            foreach (var i in lista)
            {
                if (i.Idotartam > max)
                {
                    max = i.Idotartam;
                    noveny = i.Nev;
                }
            }
            Console.WriteLine("3. Feladat: Legtöbb idő amíg gyűjthető: {0}",max);
            Console.WriteLine("Növény(ek):\n{0}", noveny);
        }

        static void negyedik()
        {
            double atlag = 0;
            double szum = 0;

            foreach (var i in lista)
            {
                szum = i.Idotartam + szum;
            }

            atlag = Math.Round(szum / lista.Count,2);
            Console.WriteLine("4. Feladat: Átlagosan gyűjthető időtartam: {0} ",atlag);
        }

       
        static void Main(string[] args)
        {
            Beolvas();
            Console.WriteLine();
            masodik();
            Console.WriteLine();
            HarmadikFeladat();
            Console.WriteLine();
            negyedik();


            Console.ReadKey();
        }
    }
}
