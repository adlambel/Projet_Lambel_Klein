using Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TD1.Modeles;

namespace TD1.ViewModel
{
   public class ListJoueurViewModel: NotifyPropertyChangedBase
    {
        private User _user;
        private Joueur _personne;
        private Match _match;
        private Place _place;
        public ObservableCollection<Joueur> ListeJoueur { get; set; }
        public ObservableCollection<Match> ListeMatch { get; set; }
        public DateTime DateNaissance { get; private set; }

        public DelegateCommand AddCommand { get; set; }

        public DelegateCommand EditCommand { get; set; }
        public DelegateCommand DeleteCommand { get; set; }
        public DelegateCommand IdentificationCommand { get; set; }
        public DelegateCommand ReserveCommand { get; set; }



        public ListJoueurViewModel(){
        ListeJoueur = new ObservableCollection<Joueur>()
            {
                new Joueur
                {
                    Nom = "Kayser",
                    Prenom = "Benjamin",
                    DateNaissance = new DateTime(1984, 7, 26),
                    Poste = "Talonneur",
                    Nationalite = "Française",
                    URLImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e2/USO-ASM_-_20140927_-_Benjamin_Kayser_1.jpg/220px-USO-ASM_-_20140927_-_Benjamin_Kayser_1.jpg"
                },

                new Joueur
                {
                    Nom = "Van Der Westhuizen",
                    Prenom = "Marthinus",
                    DateNaissance = new DateTime(1984, 2, 3),
                    Poste = "Talloneur",
                    Nationalite = "Afrique du Sud",
                    URLImage = "http://t0.gstatic.com/images?q=tbn:ANd9GcRl7kFlLP2i9MaESpqTFCUqU5XCAcJekTH8doNvlBBUrFAHMdqrh3KRbg4"
                },

                new Joueur
                {
                    Nom = "Vincent",
                    Prenom = "Debaty",
                    DateNaissance = new DateTime(1981, 10, 2),
                    Poste = "Pilier",
                    Nationalite = "Française",
                    URLImage = "http://www.lamontagne.fr/photoSRC/bqViVeldaWelbKxCPNWs_pusXXdNGltxXD4uu1iw_sR0IkLcazbGupnwlQUaVQo_pWI48f0HY_sxYvETMFwM2diAkJo-_/1060735.jpeg"
                },

                 new Joueur
                {
                    Nom = "Domingo",
                    Prenom = "Thomas",
                    DateNaissance = new DateTime(1985, 8, 20),
                    Poste = "Pilier",
                    Nationalite = "Française",
                    URLImage = "http://www.asm-rugby.com/sites/default/files/thumbnails/image/150527-domingo.jpg"
                },

                 new Joueur
                {
                    Nom = "Chaume",
                    Prenom = "Raphaël",
                    DateNaissance = new DateTime(1989, 4, 24),
                    Poste = "Pilier",
                    Nationalite = "Française",
                    URLImage = "http://www.asm-rugby.com/sites/default/files/styles/photo_joueur_staff/public/thumbnails/image/CHAUME%20Raphae%E2%95%A0%C3%AAl.png?itok=V2g5mXbr"
                },

                 new Joueur
                {
                    Nom = "Falgoux",
                    Prenom = "Etienne",
                    DateNaissance = new DateTime(1993, 1, 19),
                    Poste = "Pilier",
                    Nationalite = "Française",
                    URLImage = "https://www.midi-olympique.fr/sites/default/files/styles/avatar/public/visuel/J_PORTRAIT_1406.png?itok=rGuPTTB-"
                },

                 new Joueur
                {
                    Nom = "Ric",
                    Prenom = "Clément",
                    DateNaissance = new DateTime(1988, 7, 18),
                    Poste = "Pilier",
                    Nationalite = "Française",
                    URLImage = "http://www.asm-rugby.com/sites/default/files/styles/photo_joueur_staff/public/thumbnails/image/RIC%20Cle%E2%95%A0%C3%BCment.png?itok=OITFqxY7"
                },

                 new Joueur
                {
                    Nom = "Kotze",
                    Prenom = "Daniel",
                    DateNaissance = new DateTime(1987, 3, 28),
                    Poste = "Pilier",
                    Nationalite = "Française",
                    URLImage = "http://www.asm-rugby.com/sites/default/files/styles/photo_joueur_staff/public/thumbnails/image/KOTZE%20Daniel.png?itok=QpaLyd_y"
                },

                 new Joueur
                {
                    Nom = "Zirakashvili",
                    Prenom = "Davit",
                    DateNaissance = new DateTime(1983, 9, 20),
                    Poste = "Pilier",
                    Nationalite = "Géorgienne",
                    URLImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Davit_Zirakashvili.jpg/220px-Davit_Zirakashvili.jpg"
                },

                 new Joueur
                {
                    Nom = "Simutoga",
                    Prenom = "Mickaël",
                    DateNaissance = new DateTime(1996, 9, 29),
                    Poste = "Pilier",
                    Nationalite = "Française",
                    URLImage = "http://www.lesvignerons.org/images/philippe/Espoirs_CDM/simutoga.jpeg"
                },

                  new Joueur
                {
                    Nom = "Cudmore",
                    Prenom = "Jamie",
                    DateNaissance = new DateTime(1978, 9, 6),
                    Poste = "Deuxième ligne",
                    Nationalite = "Canadienne",
                    URLImage = "http://i.eurosport.com/2015/04/02/1448537-30967643-2560-1440.jpg?w=700"
                },

                   new Joueur
                {
                    Nom = "Jacquet",
                    Prenom = "Loïc",
                    DateNaissance = new DateTime(1985, 3, 31),
                    Poste = "Deuxième ligne",
                    Nationalite = "Française",
                    URLImage = "http://www.asm-rugby.com/sites/default/files/styles/image_principale_article/public/thumbnails/image/151021-jacquet-quizz.jpg?itok=uHuTqlmx"
                },

                    new Joueur
                {
                    Nom = "Rougerie",
                    Prenom = "Aurélien",
                    DateNaissance = new DateTime(1980, 9, 26),
                    Poste = "Centre",
                    Nationalite = "Française",
                    URLImage = "http://www.asm-rugby.com/sites/default/files/styles/photo_joueur_staff/public/thumbnails/image/ROUGERIE%20Aure%E2%95%A0%C3%BClien.png?itok=LXBREZmD"
                },


                new Joueur
                {
                    Nom = "Ulugia",
                    Prenom = "John",
                    DateNaissance = new DateTime(1986, 1, 17),
                    Poste = "Talonneur",
                    Nationalite = "Australienne",
                    URLImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/JOHN_ULUGIA_2.jpg/800px-JOHN_ULUGIA_2.jpg"

                }
            };

        ListeMatch = new ObservableCollection<Match>()
            {
                new Match
                {
                    Equipe1 = "ASM",
                    Equipe2 = "Union Bordeaux Bègles",
                    Date = new DateTime(2016, 6, 4),
                    Lieu = "Stade Marcel Michelin",
                    URLImage1 = "http://www.asm-rugby.com/sites/all/themes/asm/images/logo-asm-fb.jpg",
                    URLImage2 = "https://upload.wikimedia.org/wikipedia/fr/thumb/7/73/Union_Bordeaux_Begles_(logo).svg/1269px-Union_Bordeaux_Begles_(logo).svg.png"
                 },

                new Match
                {
                    Equipe1 = "ASM",
                    Equipe2 = "Stade Toulousain",
                    Date = new DateTime(2016, 6, 11),
                    Lieu = "Stade Marcel Michelin",
                    URLImage1 = "http://www.asm-rugby.com/sites/all/themes/asm/images/logo-asm-fb.jpg",
                    URLImage2 = "http://i.skyrock.net/0623/13880623/pics/353814724.gif"
                 },

                new Match
                {
                    Equipe1 = "ASM",
                    Equipe2 = "RC Toulon",
                    Date = new DateTime(2016, 6, 18),
                    Lieu = "Stade Marcel Michelin",
                    URLImage1 = "http://www.asm-rugby.com/sites/all/themes/asm/images/logo-asm-fb.jpg",
                    URLImage2 = "http://www.lerugbynistere.fr/photos/rugby-club-toulonnais.jpg"
                 },
            };

        AddCommand = new DelegateCommand(OnAddCommand, CanExecuteAddCommand);

        EditCommand = new DelegateCommand(OnEditCommand, CanExecuteEditCommand);

        DeleteCommand = new DelegateCommand(OnDeleteCommand, CanExecuteDeleteCommand);

        IdentificationCommand = new DelegateCommand(OnIdentificationCommand, CanExecuteIdentificationCommand);

        ReserveCommand = new DelegateCommand(OnReserveCommand, CanExecuteReserveCommand);
        }

        private bool CanExecuteReserveCommand(object obj)
        {
                return true;
        }

        private void OnReserveCommand(object obj)
        {
                ReserveView reserve = new ReserveView(Match);
                reserve.Name = "Réservation";
                reserve.ShowDialog();
                if (reserve.ViewModel.PlaceToAdd.NbPlace != 0)
                {
                    u.ListePlace.Add(reserve.ViewModel.PlaceToAdd);
                }
                NotifyPropertyChanged("u.ListePlace");
            
        }

        private bool CanExecuteDeleteCommand(object obj)
        {
            return true;
        }

        private void OnDeleteCommand(object obj)
        {
            if (u == null)
            {
                MessageBoxResult conf = MessageBox.Show("Veuillez vous authentifier avant de commencer", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (u.IsAdmin())
                {
                    MessageBoxResult conf = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce Joueur ?", "Supprimer", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (conf == MessageBoxResult.Yes)
                    {
                        ListeJoueur.Remove(Personne);
                       // NotifyPropertyChanged("ListeJoueur");
                    }
                }
                else
                {
                    MessageBoxResult conf = MessageBox.Show("Vous n'avez pas l'accès Administrateur", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        private bool CanExecuteAddCommand(object obj)
       {
                return true;
        }

        private void OnAddCommand(object obj)
        {
            if (u == null)
            {
                MessageBoxResult conf = MessageBox.Show("Veuillez vous authentifier avant de commencer", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (u.IsAdmin())
                {
                    AddView add = new AddView();
                    add.Name = "Ajout";
                    add.ShowDialog();
                    ListeJoueur.Add(add.ViewModel.JoueurToAdd);
                    NotifyPropertyChanged("ListeJoueur");
                }
                else
                {
                    MessageBoxResult conf = MessageBox.Show("Vous n'avez pas l'accès Administrateur", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }



        private bool CanExecuteIdentificationCommand(object o)
        {
            return true;
        }

        public User u
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                NotifyPropertyChanged("_user");
            }
        }

        private void OnIdentificationCommand(object o)
        {
            if (u != null)
            {
                MessageBoxResult conf = MessageBox.Show("Si vous continuez, vous allez être déconnecté", "Information", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            Identification id = new Identification();
            id.Name = "Identification";
            id.ShowDialog();
            u = new User(id.ViewModel.utilisateur.Identifiant, id.ViewModel.utilisateur.Mdp, id.ViewModel.utilisateur.IsConnected, id.ViewModel.utilisateur.Nom, id.ViewModel.utilisateur.Prenom, id.ViewModel.utilisateur.Email);
            NotifyPropertyChanged("u");
        }

       
        public Joueur Personne
        {
            get
            {
                return _personne;
            }
            set
            {
                _personne = value;
                NotifyPropertyChanged("Personne");
            }
        }



      private void OnEditCommand(object obj)
        {
            if (u == null)
            {
                MessageBoxResult conf = MessageBox.Show("Veuillez vous authentifier avant de commencer", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (u.IsAdmin())
                {
                    EditView edit = new EditView(Personne);
                    edit.Name = "Edit";
                    edit.ShowDialog();
                    NotifyPropertyChanged("ListeJoueur");
                }
                else
                {
                    MessageBoxResult conf = MessageBox.Show("Vous n'avez pas l'accès Administrateur", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

      private bool CanExecuteEditCommand(object obj)
        {
            return true;
        }


        public Match Match
        {
            get
            {
                return _match;
            }
            set
            {
                _match = value;
                NotifyPropertyChanged("Match");
            }
        }

        public Place Place
        {
            get
            {
                return _place;
            }
            set
            {
                _place = value;
                NotifyPropertyChanged("Place");
            }
        }
    }
}

    