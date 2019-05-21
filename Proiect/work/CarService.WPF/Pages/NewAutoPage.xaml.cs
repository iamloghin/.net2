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
    using CarService.Common.Logger;
    using CarService.Common.Logger.Enum;
    using CarService.WPF.Common;

    /// <summary>
    /// Interaction logic for NewAutoPage.xaml
    /// </summary>
    public partial class NewAutoPage : Page
    {
        private Client _client;
        private Auto _auto;

        public NewAutoPage()
        {
            InitializeComponent();
        }

        public NewAutoPage(Client client)
        {
            _client = client;
            InitializeComponent();
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            CommonItem.GetFrame().NavigationService.Navigate(CommonItem.PageInstent.OfType<NewClientPage>().First());
            CommonItem.GetTextBox().Text = "ADD NEW CLIENT";
        }

        private void AddAutoButtonClick(object sender, RoutedEventArgs e)
        {
            BuildAutoComanda();
            if (!CommonItem.PageInstent.OfType<NewComandaPage>().Any())
            {
                CommonItem.PageInstent.Add(new NewComandaPage(_auto));
            }
            CommonItem.GetFrame().NavigationService.Navigate(CommonItem.PageInstent.OfType<NewComandaPage>().First());
            CommonItem.GetTextBox().Text = "ADD NEW COMANDA";
        }

        private void BuildAutoComanda()
        {
            try
            {
                var newSasiu = new Sasiu()
                                   {
                                       Id = Guid.NewGuid(),
                                       CodSasiu = _codNumberTextBox.Text,
                                       Denumire = _nameNumberTextBox.Text
                                   };

                var serieSasiu =
                    $"{_serialNumberTextLeft.Text}{_serialNumberTextCenter.Text}{_serialNumberTextRight.Text}";

                _auto = new Auto()
                            {
                                Id = Guid.NewGuid(),
                                Client = _client,
                                NumarAuto = _autoNumberTextBox.Text,
                                Sasiu = newSasiu,
                                SerieSasiu = serieSasiu
                            };
            }
            catch (Exception e)
            {
                Logger.Log.Handle(LogLevel.Error, $"{e.Message} - {e.InnerException}");
            }
        }
    }
}
