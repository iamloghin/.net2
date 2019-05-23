using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;

namespace CarService.WPF.Pages
{
    using System;
    using System.Windows;

    using CarService.WPF.Common;

    /// <summary>
    /// Interaction logic for DashboardPage.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        private AutoServiceClient _autoApi;

        public Dashboard()
        {
            InitializeComponent();
            DashBoardInit();
        }

        public void DashBoardInit()
        {
            this.FontFamily = new FontFamily("Champagne &amp; Limousines");
            if (!CommonItem.DemoApp)
            {
                using (_autoApi = new AutoServiceClient())
                {
                    this._dashboardMecanicAvail.Text = _autoApi.GetAvailabelMecanics().Count().ToString();
                    this._dashboardMecanicInfo.Text =
                        $"Total of {_autoApi.GetAllMecanics().Count().ToString()} mechanics";

                    this._dashboardComenzi.Text = _autoApi.GetAllOrders().Count().ToString();
                    this._dashboardComenziInfo.Text =
                        $"{_autoApi.GetAllDoneOrders().Count().ToString()} orders completed";

                    this._dashboardOperatii.Text = _autoApi.GetAllOperations().Count().ToString();
                    this._dashboardOperatiiInfo.Text =
                        $"Total executing time is {_autoApi.GetOperationsTotalTime().ToString()}";
                }
            }
        }
    }
}
