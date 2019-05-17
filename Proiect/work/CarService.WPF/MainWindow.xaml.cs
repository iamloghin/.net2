namespace CarService.WPF
{
    using System.Linq;
    using System.Windows;
    using System.Windows.Media;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DashBoardInit();
        }

        public void DashBoardInit()
        {
            this.FontFamily = new FontFamily("Champagne &amp; Limousines");
            using (var autoApi = new AutoServiceClient())
            {
                this._dashboardMecAvail.Text = autoApi.GetAvailabelMecanics().Count().ToString();
                this._dashboardMecTotal.Text = $"Total of {autoApi.GetAllMecanics().Count().ToString()} mechanics";
            }
        }

        private void ShutdownButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
