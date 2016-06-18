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
    /// Interaction logic for EditView.xaml
    /// </summary>
    public partial class EditView : Window
    {

        public EditJoueurViewModel ViewModel { get; set; }

        public EditView(Joueur j)
        {
            InitializeComponent();
            ViewModel = new EditJoueurViewModel(j);

            DataContext = ViewModel;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
