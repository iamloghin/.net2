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
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;

    using CarService.Common.Logger;
    using CarService.Common.Logger.Enum;
    using CarService.WPF.Annotations;
    using CarService.WPF.Common;

    /// <summary>
    /// Interaction logic for NewClientPage.xaml
    /// </summary>
    public partial class NewClientPage : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public NewClientPage()
        {
            InitializeComponent();
        }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void AddClientButtonClick(object sender, RoutedEventArgs e)
        {
            var newClient = new Client()
            {
                Id = Guid.NewGuid(),
                Adresa = _fullAddressBox.Text,
                Email = _emailBox.Text,
                Judet = _countryBox.Text,
                Localitate = _localityBox.Text,
                Nume = _nameFirstTextBox.Text,
                Prenume = _nameLastTextBox.Text,
                Telefon = _phoneBox.Text
            };

            if (!CommonItem.PageInstent.OfType<NewAutoPage>().Any())
            {
                CommonItem.PageInstent.Add(new NewAutoPage(newClient));
            }
            CommonItem.GetFrame().NavigationService.Navigate(CommonItem.PageInstent.OfType<NewAutoPage>().First());
            CommonItem.GetTextBox().Text = "ADD NEW AUTO";
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
