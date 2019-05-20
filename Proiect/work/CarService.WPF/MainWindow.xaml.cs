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
                this._dashboardMecanicAvail.Text = autoApi.GetAvailabelMecanics().Count().ToString();
                this._dashboardMecanicInfo.Text = $"Total of {autoApi.GetAllMecanics().Count().ToString()} mechanics";

                this._dashboardComenzi.Text = autoApi.GetAllOrders().Count().ToString();
                this._dashboardComenziInfo.Text = $"{autoApi.GetAllDoneOrders().Count().ToString()} orders completed";

                this._dashboardOperatii.Text = autoApi.GetAllOperations().Count().ToString();
                this._dashboardOperatiiInfo.Text = $"Total executing time is {autoApi.GetOperationsTotalTime().ToString()}";
            }
        }

        private void ShutdownButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
