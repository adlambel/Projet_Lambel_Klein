using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1.Modeles
{
    public class Place
    {
        public Match m { get; set; }
        public int NbPlace { get; set; }

        public Place(Match match)
        {
            m = match;
        }
    }
}
