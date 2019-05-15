namespace CarService.WPF
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tare();
        }

        public void tare()
        {
            var pc = new AutoServiceClient();
            var x  = pc.GetAvailabelMecanics();
            var z = "debug";
        }
    }
}
