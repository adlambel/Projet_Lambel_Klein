using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    public class Joueur
    {
        private int _age;

        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateNaissance.Year -
                  (DateTime.Now.Month < DateNaissance.Month ? 1 :
                  (DateTime.Now.Month == DateNaissance.Month && DateTime.Now.Day < DateNaissance.Day) ? 1 : 0);
            }
          set {
              _age = value; 
          }
        }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        public string Poste { get; set; }

        public string Nationalite { get; set; }

        public string URLImage { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Prenom, Nom);
        }

    }
}
