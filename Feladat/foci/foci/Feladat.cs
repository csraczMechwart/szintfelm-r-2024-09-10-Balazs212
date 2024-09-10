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
                int vendegVeg = Convert.ToInt32(resz[1]);
                int hazaiFel = Convert.ToInt32(resz[1]);
                int vendegFel = Convert.ToInt32(resz[1]);
                string hazaiNev = resz[2];
                string vendegNev = resz[3];
                meccs Meccs = new meccs(fordulo, hazaiVeg, vendegVeg, hazaiFel, vendegFel, hazaiNev, vendegNev);
                adatok.Add(Meccs);
            }
        }

        public void Feladat2()
        {

        }
    }
}
