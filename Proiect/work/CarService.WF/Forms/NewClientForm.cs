namespace CarService.WF.Forms
{
    using System;
    using System.Windows.Forms;
    using CarService;
    using CarService.Service;

    public partial class NewClientForm : Form
    {
        private IAutoService _serviceApi;

        public NewClientForm(ref IAutoService serviceApi)
        {
            _serviceApi = serviceApi;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            var newClient = new Client()
            {
                Adresa = clientAdresaRichBox.Text,
                Email = clientEmailTextBox.Text,
                Judet = clientJudetTextBox.Text,
                Localitate = clientLocalitateTextBox.Text,
                Nume = clientNameTextBox.Text,
                Prenume = clientPrenumeTextBox.Text,
                Telefon = clientTelefonTextBox.Text
            };

            var newAutoForm = new NewAutoForm(ref _serviceApi, newClient);
            Hide();
            newAutoForm.ShowDialog();

            if (this.IsDisposed) return;
            
            Show();
        }

        private void WhenFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
