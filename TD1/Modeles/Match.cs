using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    public class Match
    {

        public string Equipe1{ get; set; }

        public string Equipe2 { get; set; }

        public DateTime Date { get; set; }

        public string Lieu { get; set; }

        public string URLImage1 { get; set; }

        public string URLImage2 { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Equipe2);
        }

    }

}

