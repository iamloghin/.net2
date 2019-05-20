namespace CarService.WPF
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    using CarService.WPF.Common;
    using CarService.WPF.Pages;

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
            CommonItem.SetFrame(ref _mainPanelFrame);
            CommonItem.SetTextBox(ref _pageName);
        }

        private void ShutdownButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DashBoardButton_OnClick(object sender, RoutedEventArgs e)
        {
            Page dashboardPage = new Dashboard();
            _mainPanelFrame.NavigationService.Navigate(dashboardPage);
            _pageName.Text = "DASHBOARD";
        }

        private void NewClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            Page newClientPage = new NewClientPage();
            _mainPanelFrame.NavigationService.Navigate(newClientPage);
            _pageName.Text = "ADD NEW CLIENT";
        }
        private void ClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            _mainPanelFrame.Source = new Uri($"/Pages/ClientPage.xaml", UriKind.Relative);
            _pageName.Text = "CLIENT VIEW";
        }
        private void ManagerButton_OnClick(object sender, RoutedEventArgs e)
        {
            _mainPanelFrame.Source = new Uri($"/Pages/ManagerPage.xaml", UriKind.Relative);
            _pageName.Text = "MANAGER VIEW";
        }
    }
}
