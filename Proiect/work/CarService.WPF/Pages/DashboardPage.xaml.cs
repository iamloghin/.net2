﻿using System;
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
    using CarService.WPF.Common;

    /// <summary>
    /// Interaction logic for DashboardPage.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
            //DashBoardInit();
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
            CommonItem.GetTextBox().Text = "DASHBOARD";
        }
    }
}