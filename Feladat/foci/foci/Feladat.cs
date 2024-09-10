using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace foci
{
    internal class Feladat
    {
        List<meccs> adatok = new List<meccs>();
        public Feladat()
        {
            foreach (var item in File.ReadAllLines("meccs.txt", Encoding.UTF8).Skip(1))
            {

                string[] resz = item.Split(' ');
                int fordulo = Convert.ToInt32(resz[0]);
                int hazaiVeg = Convert.ToInt32(resz[1]);
                int vendegVeg = Convert.ToInt32(resz[2]);
                int hazaiFel = Convert.ToInt32(resz[3]);
                int vendegFel = Convert.ToInt32(resz[4]);
                string hazaiNev = resz[5];
                string vendegNev = resz[6];
                meccs Meccs = new meccs(fordulo, hazaiVeg, vendegVeg, hazaiFel, vendegFel, hazaiNev, vendegNev);
                Adatok.Add(Meccs);
            }
        }

        internal List<meccs> Adatok { get => adatok; set => adatok = value; }

        public void Feladat2()
        {
            Console.WriteLine("2. feladat:");
            Console.WriteLine($"Írja be egy mérkőzés számát: ");
            int valasztottForduloSzama = (Console.ReadLine().Length>0) ? Convert.ToInt32(Console.ReadLine()) : 0;
            List<meccs> valasztottFordulo = Adatok.Where(x => x.fordulo == valasztottForduloSzama).ToList();
            for (int i = 0; i < valasztottFordulo.Count(); i++)
            {
                Console.WriteLine($"{valasztottFordulo[i].hazaiNev}-{valasztottFordulo[i].vendegNev}: {valasztottFordulo[i].hazaiVeg}-{valasztottFordulo[i].vendegVeg} ({valasztottFordulo[i].hazaiFel}-{valasztottFordulo[i].vendegFel})");
            }
        }

        public void Feladat3()
        {
            Console.WriteLine("\n3. feladat:");
            Console.WriteLine($"Fordító csapatok: ");
            foreach (var i in Adatok)
            {
                if (i.hazaiFel<i.vendegFel && i.hazaiVeg>i.vendegVeg)
                {
                    Console.WriteLine($"{i.fordulo} {i.hazaiNev}");
                }
                if (i.hazaiFel > i.vendegFel && i.hazaiVeg < i.vendegVeg)
                {
                    Console.WriteLine($"{i.fordulo} {i.vendegNev}");
                }
            }
        }
    }
}
