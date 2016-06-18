using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TD1.ViewModel;

namespace TD1
{
    /// <summary>
    /// Logique d'interaction pour Inscription.xaml
    /// </summary>
    public partial class Inscription : Window
    {
        public InscriptionViewModel ViewModel { get; set; }
        public Inscription()
        {
            InitializeComponent();
            ViewModel = new InscriptionViewModel(this);
            DataContext = ViewModel;
        }
    }
}
