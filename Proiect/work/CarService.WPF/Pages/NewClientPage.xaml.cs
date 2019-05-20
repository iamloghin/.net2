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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarService.WPF.Pages
{
    using CarService.WPF.Common;

    /// <summary>
    /// Interaction logic for NewClientPage.xaml
    /// </summary>
    public partial class NewClientPage : Page
    {
        public NewClientPage()
        {
            InitializeComponent();
        }

        private void AddClientButtonClick(object sender, RoutedEventArgs e)
        {
            var newClient = new Client()
            {
                Adresa = _nameFirstTextBox.Text,
                Email = _nameFirstTextBox.Text,
                Judet = _countryBox.Text,
                Localitate = _localityBox.Text,
                Nume = _nameFirstTextBox.Text,
                Prenume = _nameLastTextBox.Text,
                Telefon = _phoneBox.Text
            };

            Page newAutoPage = new NewAutoPage(newClient);
            CommonItem.GetFrame().NavigationService.Navigate(newAutoPage);
            CommonItem.GetTextBox().Text = "ADD NEW CLIENT";
        }
    }
}
