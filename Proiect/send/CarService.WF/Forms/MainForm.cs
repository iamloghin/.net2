using System;
using System.Drawing;
using System.Windows.Forms;
using CarService.Service;

namespace CarService.WF.Forms
{
    public partial class MainForm : Form
    {
        private static bool _searchClientFieldEvent = true;
        private static IAutoService _serviceApi = new AutoService();

        public MainForm()
        {
            InitializeComponent();
            SetComponentMarginAuto();
        }

        private void SetComponentMarginAuto()
        {
            const int fieldsDistant = 25;
            GroupWelcome.Left = (Width - GroupWelcome.Width) / 2;
            addClientButton.Left = (Width - addClientButton.Width) / 2;
            managerButton.Left = (Width - managerButton.Width) / 2;
            seachClientTextBox.Left = (Width - seachClientTextBox.Width) / 2;
            seachClientButton.Left = (Width - seachClientButton.Width) / 2;

            seachClientTextBox.Top = GroupWelcome.Bottom + fieldsDistant * 4;
            seachClientButton.Top = seachClientTextBox.Bottom + fieldsDistant;
            addClientButton.Top = seachClientButton.Bottom + fieldsDistant;
            managerButton.Top = addClientButton.Bottom + fieldsDistant;
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            var newClientForm = new NewClientForm(ref _serviceApi);
            Hide();
            newClientForm.ShowDialog();
            if (this.IsDisposed) return;
            Show();
        }

        private void FirstClickEvent(object sender, EventArgs e)
        {
            if (!_searchClientFieldEvent) return;
            _searchClientFieldEvent = false;
            seachClientTextBox.Text = "";
        }

        private void seachClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                var responseClient = _serviceApi.GetClient(seachClientTextBox.Text);

                if (responseClient == null)
                {
                    seachClientTextBox.BackColor = Color.Crimson;
                    return;
                }

                var newClientForm = new ClientForm(ref _serviceApi, responseClient);
                Hide();
                newClientForm.ShowDialog();
                if (this.IsDisposed) return;
                Show();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void TextBoxFocused(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            textBox.BackColor = Color.White;
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            var managerForm = new ManagerForm(ref _serviceApi);
            Hide();
            managerForm.ShowDialog();
            if (this.IsDisposed) return;
            Show();
        }
    }
}
