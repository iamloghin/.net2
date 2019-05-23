namespace CarService.WPF
{
    using System;

    using CarService.WPF.Common;
    using CarService.WPF.Pages;

    using System.Windows;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CustomInitialization();
        }

        private void CustomInitialization()
        {
            try
            {
                using (var _autoApi = new AutoServiceClient())
                {
                    var checkConnection = _autoApi.GetAvailabelMecanics().Count;
                    CommonItem.SetFrame(ref _mainPanelFrame);
                    CommonItem.SetTextBox(ref _pageName);
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("no endpoint listening"))
                {
                    CommonItem.DemoApp = true;
                    CommonItem.SetFrame(ref _mainPanelFrame);
                    CommonItem.SetTextBox(ref _pageName);
                    MessageBox.Show("Serviciul Host WCF nu raspunde, aplicatia ruleaza in modul DEMO.");
                }
            }
        }

        private void ShutdownButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DashBoardButton_OnClick(object sender, RoutedEventArgs e)
        {
            CommonItem.PageInstent.Clear();
            _mainPanelFrame.NavigationService.Navigate(new Dashboard());
            CommonItem.GetTextBox().Text = "DASHBOARD";
        }

        private void NewClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            CommonItem.PageInstent.Clear();
            _mainPanelFrame.NavigationService.Navigate(new NewClientPage());
            _pageName.Text = "ADD NEW CLIENT";
        }
        private void ClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            CommonItem.PageInstent.Clear();
            _mainPanelFrame.NavigationService.Navigate(new ClientPage());
            _pageName.Text = "CLIENT VIEW";
        }
        private void ManagerButton_OnClick(object sender, RoutedEventArgs e)
        {
            CommonItem.PageInstent.Clear();
            _mainPanelFrame.NavigationService.Navigate(new ManagerPage());
            _pageName.Text = "MANAGER VIEW";
        }

        private void TopNavBarMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void MinimizeButtonClick(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }
    }
}
