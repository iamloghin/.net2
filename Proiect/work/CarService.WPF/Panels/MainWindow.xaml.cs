namespace CarService.WPF
{
    using CarService.WPF.Common;
    using CarService.WPF.Pages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Threading;

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
            CommonItem.PageInstent.Clear();
            _mainPanelFrame.NavigationService.Navigate(new Dashboard());
        }

        private void NewClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!CommonItem.PageInstent.OfType<NewClientPage>().Any())
            {
                CommonItem.PageInstent.Add(new NewClientPage());
            }
            _mainPanelFrame.NavigationService.Navigate(CommonItem.PageInstent.OfType<NewClientPage>().First());
            _pageName.Text = "ADD NEW CLIENT";
        }
        private void ClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!CommonItem.PageInstent.OfType<ClientPage>().Any())
            {
                CommonItem.PageInstent.Add(new ClientPage());
            }
            _mainPanelFrame.NavigationService.Navigate(CommonItem.PageInstent.OfType<ClientPage>().First());
            _pageName.Text = "CLIENT VIEW";
        }
        private void ManagerButton_OnClick(object sender, RoutedEventArgs e)
        {
            CommonItem.PageInstent.Add(new ManagerPage());
            _mainPanelFrame.NavigationService.Navigate(CommonItem.PageInstent.LastOrDefault());
            _pageName.Text = "MANAGER VIEW";
        }

        // protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        // {
        //     base.OnMouseLeftButtonDown(e);
        //     this.DragMove();
        // }
    }
}
