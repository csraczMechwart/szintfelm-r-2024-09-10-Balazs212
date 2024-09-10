using System;
using System.Collections.Generic;
using System.Linq;
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
                adatok.Add(Meccs);
            }
        }

        public void Feladat2()
        {
            Console.WriteLine("1. feladat:");
            Console.WriteLine($"Írja be egy mérkőzés számát: ");
            int valasztottForduloSzama = Convert.ToInt32(Console.ReadLine());
            List<meccs> valasztottFordulo = adatok.Where(x => x.fordulo == valasztottForduloSzama).ToList();
            for (int i = 0; i < valasztottFordulo.Count(); i++)
            {
                Console.WriteLine($"{valasztottFordulo[i].hazaiNev}-{valasztottFordulo[i].vendegNev}: {valasztottFordulo[i].hazaiVeg}-{valasztottFordulo[i].vendegVeg} ({valasztottFordulo[i].hazaiFel}-{valasztottFordulo[i].vendegFel})");
            }
        }
    }
}
