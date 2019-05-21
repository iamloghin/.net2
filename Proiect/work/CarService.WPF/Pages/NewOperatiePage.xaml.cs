namespace CarService.WPF.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Controls;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows;
    using System.Windows.Forms;

    using CarService.WPF.Common;
    using CarService.WPF.ViewModels;

    using Application = System.Windows.Forms.Application;
    using MessageBox = System.Windows.Forms.MessageBox;

    /// <summary>
    /// Interaction logic for NewOperatiePage.xaml
    /// </summary>
    public partial class NewOperatiePage : Page
    {
        private DetaliuComanda _detaliuComanda;
        private static ICollection<Mecanic> _clientMecanics = new List<Mecanic>();
        public ObservableCollection<SelectableViewModel<DisplayMecanic>> Mecanics { get; }
        public ObservableCollection<SelectableViewModel<Operatie>> Operations { get; }

        private NewOperatiePage()
        {
            InitializeComponent();
        }

        public NewOperatiePage(DetaliuComanda detaliuComanda)
        {
            InitializeComponent();
            _detaliuComanda = detaliuComanda;
            Mecanics = GetMecanicsData();
            Operations = new ObservableCollection<SelectableViewModel<Operatie>>();
            DataContext = this;
        }

        private static ObservableCollection<SelectableViewModel<DisplayMecanic>> GetMecanicsData()
        {
            var obsCollenctionTemp = new ObservableCollection<SelectableViewModel<DisplayMecanic>>();

            using (var autoApi = new AutoServiceClient())
            {
                _clientMecanics = autoApi.GetAvailabelMecanics();

                foreach (var mecanic in _clientMecanics)
                {
                    obsCollenctionTemp.Add(
                        new SelectableViewModel<DisplayMecanic>
                            {
                                IsChecked = false,
                                Item = new DisplayMecanic() { Id = mecanic.Id, FullName = $"{mecanic.Nume} {mecanic.Prenume}" }
                            });
                }
            }

            return obsCollenctionTemp;
        }

        private void AddOperationButtonClick(object sender, RoutedEventArgs e)
        {
            BuildOperatie();
        }

        private void BuildOperatie()
        {
            DialogResult userResponse;

            var operatie = new Operatie()
                               {
                                   Id = Guid.NewGuid(),
                                   Denumire = _addOperationTextBox.Text,
                                   TimpExecutie = decimal.Parse(_addTimeTextBox.Text)
                               };

            // remove comment
            do
            {
                using (var autoApi = new AutoServiceClient())
                {
                    var response = autoApi.AddOperatie(operatie, _detaliuComanda);
                    if (response) break;

                    userResponse =
                        MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (userResponse == DialogResult.No) break;
                }
            } while (userResponse == DialogResult.Yes);

            Operations.Add(
                new SelectableViewModel<Operatie>
                    {
                        Item = new Operatie() { Denumire = operatie.Denumire, TimpExecutie = operatie.TimpExecutie }
                    });
        }

        private void AddComandaButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult userResponse;

            if (Operations.Count == 0)
            {
                MessageBox.Show(@"Scuze, dar ca sa poti finaliza comanda este necesar macar o operatie.", @"Comanda need some operations",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedMecanics = new List<Mecanic>();

            foreach (var mecanic in Mecanics)
            {
                if (mecanic.IsChecked)
                {
                    selectedMecanics.Add(_clientMecanics.First(x => x.Id.Equals(mecanic.Item.Id)));
                }
            }

            // remove comment
            do
            {
                using (var autoApi = new AutoServiceClient())
                {
                    var response = autoApi.AddMecanics(selectedMecanics, _detaliuComanda);
                    if (response) break;

                    userResponse =
                        MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (userResponse == DialogResult.No) break;
                }
            } while (userResponse == DialogResult.Yes);

            CommonItem.PageInstent.Clear();
            CommonItem.GetFrame().NavigationService.Navigate(new Dashboard());
        }
    }
}
