using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1.ViewModel
{
    public class AddJoueurViewModel
    {
        public Joueur JoueurToAdd { get; set; }

        public AddJoueurViewModel()
        {
            JoueurToAdd = new Joueur();
        }

    }
}
