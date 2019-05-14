using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CarService;
using CarService.Service;

namespace ServiceAutoGUI.Forms
{
    public partial class ClientForm : Form
    {
        private IAutoService _serviceApi;
        private readonly Client _client;
        private IList<Auto> _clientAutos = new List<Auto>();
        private bool _changePress = false;

        public ClientForm(ref IAutoService serviceApi, Client client)
        {
            _serviceApi = serviceApi;
            _client = client;
            InitializeComponent();
            BuildClientForm();
            BuildAutoForm();
        }

        private void BuildClientForm()
        {
            clientNameTextBox.Text = _client.Nume;
            clientPrenumeTextBox.Text = _client.Prenume;
            clientAdresaRichBox.Text = _client.Adresa;
            clientEmailTextBox.Text = _client.Email;
            clientJudetTextBox.Text = _client.Judet;
            clientLocalitateTextBox.Text = _client.Localitate;
            clientTelefonTextBox.Text = _client.Telefon;
        }

        private void BuildAutoForm()
        {
            _clientAutos = _serviceApi.GetClientAutos(_client.Id);

            foreach (var auto in _clientAutos)
            {
                autoListBox.Items.Add(auto.NumarAuto);
            }
        }

        private void WhenFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            if (!_changePress)
            {
                _changePress = true;
                saveChangeButton.Enabled = !saveChangeButton.Enabled;
            }

            clientNameTextBox.Enabled = !clientNameTextBox.Enabled;
            clientPrenumeTextBox.Enabled = !clientPrenumeTextBox.Enabled;
            clientAdresaRichBox.Enabled = !clientAdresaRichBox.Enabled;
            clientEmailTextBox.Enabled = !clientEmailTextBox.Enabled;
            clientJudetTextBox.Enabled = !clientJudetTextBox.Enabled;
            clientLocalitateTextBox.Enabled = !clientLocalitateTextBox.Enabled;
            clientTelefonTextBox.Enabled = !clientTelefonTextBox.Enabled;
        }

        private void newAutoButton_Click(object sender, EventArgs e)
        {
            var newAutoForm = new NewAutoForm(ref _serviceApi, _client);
            
            Hide();
            newAutoForm.ShowDialog();
            if (this.IsDisposed) return;
            Show();
        }

        private void addAutoButton_Click(object sender, EventArgs e)
        {
            var _auto = _clientAutos.FirstOrDefault(a => a.NumarAuto.Equals(autoListBox.SelectedItem.ToString()));

            var newOperationForm = new NewComandaForm(ref _serviceApi, _auto);
            
            Hide();
            newOperationForm.ShowDialog();
            if (this.IsDisposed) return;
            Show();
        }

        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            var updateClient = new Client(_client.Id)
            {
                Nume = clientNameTextBox.Text,
                Prenume = clientPrenumeTextBox.Text,
                Email = clientEmailTextBox.Text,
                Telefon = clientTelefonTextBox.Text,
                Adresa = clientAdresaRichBox.Text,
                Judet = clientJudetTextBox.Text,
                Localitate = clientLocalitateTextBox.Text
            };

            var userResponse = DialogResult.No;

            do
            {
                var response = _serviceApi.UpdateClient(updateClient);

                if (response) continue;

                userResponse = 
                    MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (userResponse == DialogResult.No) return;

            } while (userResponse == DialogResult.Yes);

            
            ResetClientForm();
        }


        private void ResetClientForm()
        {
            clientNameTextBox.Text = _client.Nume;
            clientPrenumeTextBox.Text =_client.Prenume;
            clientEmailTextBox.Text =_client.Email;
            clientTelefonTextBox.Text = _client.Telefon;
            clientAdresaRichBox.Text = _client.Adresa;
            clientJudetTextBox.Text = _client.Judet;
            clientLocalitateTextBox.Text = _client.Localitate;
        }
    }
}
