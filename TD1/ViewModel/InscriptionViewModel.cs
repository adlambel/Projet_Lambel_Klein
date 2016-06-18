using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD1.Modeles;

namespace TD1.ViewModel
{
    public class InscriptionViewModel
    {
        public User UserToAdd { get; set; }

        public Inscription fenetre { get; set; }

        public DelegateCommand InscriptionCommand { get; set; }

        public InscriptionViewModel(Inscription ins)
        {
            UserToAdd = new User("","",false,"","","");
            InscriptionCommand = new DelegateCommand(OnInscriptionCommand, CanExecuteInscriptionCommand);
            fenetre = ins;
        }

        private bool CanExecuteInscriptionCommand(object o)
        {
            return true;
        }

        public void OnInscriptionCommand(object obj)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Adrien\Downloads\Projet\MasterDetails\TD1\Files\Users.txt", true))
            {
                file.WriteLine(UserToAdd.ToString() + " " + UserToAdd.Nom + " " + UserToAdd.Prenom + " " + UserToAdd.Email);
            }
            fenetre.Close();
        }
        

    }
}
