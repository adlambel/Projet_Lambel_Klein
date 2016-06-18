using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1.Modeles
{
    public class User
    {

        private string _identifiant;
        public string Identifiant
        {
            get
            {
                return _identifiant;
            }
            set
            {
                _identifiant = value;
            }
        }
        private string _mdp;
        public string Mdp
        {
            get
            {
                return _mdp;
            }
            set
            {
                _mdp = value;
            }
        }

        public bool IsConnected { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; } 

        public string Email { get; set; }

        public ObservableCollection<Place> ListePlace { get; set; }
        

        public User(string id, string mdp)
        {
            Identifiant = id;
            Mdp = mdp;
            IsConnected = false;
            ListePlace = new ObservableCollection<Place>();
        }

        public User(string id, string mdp, bool connect, string nom, string prenom, string email)
        {
            Identifiant = id;
            Mdp = mdp;
            IsConnected = connect;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            ListePlace = new ObservableCollection<Place>();
        }


        public bool IsAdmin()
        {
            if(Identifiant=="admin" && Mdp=="admin")
                return true;
            else return false;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Identifiant, Mdp);
        }
    }
}
