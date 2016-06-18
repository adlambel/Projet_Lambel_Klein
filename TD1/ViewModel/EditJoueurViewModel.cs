using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1.ViewModel
{
    public class EditJoueurViewModel
    {

        public Joueur JoueurToEdit { get; set; }

        public EditJoueurViewModel(Joueur j)
        {
            JoueurToEdit= j;
        }

    }
}
