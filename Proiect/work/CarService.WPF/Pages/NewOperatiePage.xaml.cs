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
    /// Interaction logic for NewOperatiePage.xaml
    /// </summary>
    public partial class NewOperatiePage : Page
    {
        private DetaliuComanda _detaliuComanda;

        public NewOperatiePage()
        {
            InitializeComponent();
        }

        public NewOperatiePage(DetaliuComanda detaliuComanda)
        {
            InitializeComponent();
            _detaliuComanda = detaliuComanda;
        }
    }
}
