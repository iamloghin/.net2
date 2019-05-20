using System;
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
    /// <summary>
    /// Interaction logic for NewComandaPage.xaml
    /// </summary>
    public partial class NewComandaPage : Page
    {
        private Auto _auto;

        public NewComandaPage()
        {
            InitializeComponent();
        }

        public NewComandaPage(Auto auto)
        {
            _auto = auto;
            InitializeComponent();
        }
    }
}
