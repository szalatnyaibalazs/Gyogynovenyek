using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyogynovenyek
{
 
    class Program
    {
        static List<Noveny> novenyek = new List<Noveny>();

        static Dictionary<string, int> reszek = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            Beolvas();
            ElsoFeladat();
            MasodikFealadat();
            HarmadiKFeladat();
            NegyedikFeladat();
            Console.ReadKey();
        }

        static void Beolvas()
        {
            StreamReader ol = new StreamReader("noveny.csv");
            while (!ol.EndOfStream)
            {
                novenyek.Add(new Noveny(ol.ReadLine()));
            }
            ol.Close();
        }
        static void ElsoFeladat()
        {
            Console.WriteLine($"1. fealadat: Növények száma: {novenyek.Count}");
        }
        static void MasodikFealadat()
        {
            Console.WriteLine("\n2. Feladat: Gyüjthető részek:");
            foreach (var n in novenyek)
            {
                if (!reszek.ContainsKey(n.Resz))
                {
                    reszek.Add(n.Resz,0);
                }
            }

            foreach (var n in novenyek)
            {
                reszek[n.Resz]++;
            }
            foreach (var r in reszek)
            {
                Console.WriteLine($"{r.Key}: {r.Value}");
            }
        }
        static void HarmadiKFeladat()
        {
            int max = 0;
            foreach (var n in novenyek)
            {
                if (n.Idotartam >max)
                {
                    max = n.Idotartam;
                }
            }
            foreach (var n in novenyek)
            {
                if (n.Idotartam == max)
                {
                    Console.WriteLine($"\n3.Fealdat:Legtöbb idő amíg gyüjthető: {max}\nNövény(ek):\n{n.Nev}");
                }
            }
        }
        static void NegyedikFeladat()
        {
            double Szum = 0;
            double Atlag = 0;
            foreach (var n in novenyek)
            {
                Szum += n.Idotartam;
            }
            Atlag = Szum / novenyek.Count;
            Console.WriteLine($"\n4.feladat: Átlagos gyüjthető időtartam:{Atlag}");
        }
    }
}
