namespace CarService.WPF
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Windows.Media;

    using CarService.WPF.Pages;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShutdownButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DashBoardButton_OnClick(object sender, RoutedEventArgs e)
        {
            _mainPanelFrame.Source = new Uri($"/Pages/DashboardPage.xaml", UriKind.Relative);
            _pageName.Text = "DASHBOARD";
        }

        private void NewClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            _mainPanelFrame.Source = new Uri($"/Pages/NewClientPage.xaml", UriKind.Relative);
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
