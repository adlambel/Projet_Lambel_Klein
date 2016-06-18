using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TD1.Modeles;

namespace TD1.ViewModel
{
    public class IdentificationViewModel
    {

        public User utilisateur { get; set; }

        public DelegateCommand ConnexionCommand { get; set; }

        public DelegateCommand InscriptionCommand { get; set; }

        public Identification fenetre { get; set; }

        public IdentificationViewModel(Identification id)
        {

            utilisateur = new User("", "");

            ConnexionCommand = new DelegateCommand(OnConnexionCommand, CanExecuteConnexionCommand);
            InscriptionCommand = new DelegateCommand(OnInscriptionCommand, CanExecuteInscriptionCommand);

            fenetre = id;
        }

        private bool CanExecuteConnexionCommand(object o)
        {
            return true;
        }

        private void OnConnexionCommand(object obj)
        {
            if (utilisateur.Identifiant == "" && utilisateur.Mdp == "")
            {
                MessageBoxResult conf = MessageBox.Show("Veuillez vous authentifier avant de commencer", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (recherche(utilisateur))
                {
                    MessageBoxResult conf = MessageBox.Show("Bienvenue !", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    utilisateur.IsConnected = true;
                    fenetre.Close();    
                }
                else
                {
                    MessageBoxResult conf = MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            
        }

        private bool CanExecuteInscriptionCommand(object o)
        {
            return true;
        }

        public void OnInscriptionCommand(object obj)
        {
            Inscription ins = new Inscription();
            ins.Name = "Inscription";
            ins.ShowDialog();
        }

        public bool recherche(User utilisateur)
        {
            string line;
            string[] valeurs;

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Adrien\Downloads\Projet\MasterDetails\TD1\Files\Users.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(utilisateur.Identifiant) && line.Contains(utilisateur.Mdp))
                {
                    valeurs = line.Split();
                    utilisateur.Nom = valeurs[2];
                    utilisateur.Prenom = valeurs[3];
                    utilisateur.Email = valeurs[4];
                    file.Close();
                    return true;
                }
            }
            file.Close();
            return false;
        }
    }
}
