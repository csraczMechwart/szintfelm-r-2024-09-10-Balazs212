using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foci
{
    internal class meccs
    {
        public meccs(int fordulo, int hazaiVeg, int vendegVeg, int hazaiFel, int vendegFel, string hazaiNev, string vendegNev)
        {
            this.fordulo = fordulo;
            this.hazaiVeg = hazaiVeg;
            this.vendegVeg = vendegVeg;
            this.hazaiFel = hazaiFel;
            this.vendegFel = vendegFel;
            this.hazaiNev = hazaiNev;
            this.vendegNev = vendegNev;
        }

        public int fordulo { get; set; }
        public int hazaiVeg { get; set; }
        public int vendegVeg { get; set; }
        public int hazaiFel { get; set; }
        public int vendegFel { get; set; }
        public string hazaiNev {  get; set; }
        public string vendegNev { get; set; }

    }
}
