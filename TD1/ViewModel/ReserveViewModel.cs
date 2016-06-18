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
    public class ReserveViewModel
    {
        public Place PlaceToAdd { get; set; }
        public DelegateCommand ConfirmCommand { get; set; }
        public ReserveView fenetre { get; set; }
        public ReserveViewModel(Match m, ReserveView r)
        {
            PlaceToAdd = new Place(m);
            ConfirmCommand = new DelegateCommand(OnConfirmCommand, CanExecuteConfirmCommand);
            fenetre = r;
        }

        private bool CanExecuteConfirmCommand(object o)
        {
           
                return true;
            
        }

        private void OnConfirmCommand(object obj)
        {
            if (PlaceToAdd.NbPlace != 0)
                fenetre.Close();
            else
            {
                MessageBoxResult conf = MessageBox.Show("Veuillez rentrer un nombre de Places", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
