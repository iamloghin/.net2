using System;
using System.Windows.Forms;
using CarService;
using CarService.Service;

namespace ServiceAutoGUI.Forms
{
    public partial class NewAutoForm : Form
    {
        private IAutoService _serviceApi;
        private readonly Client _client;
        private Auto _auto;

        public NewAutoForm(ref IAutoService serviceApi, Client client)
        {
            _serviceApi = serviceApi;
            _client = client;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addAutoButton_Click(object sender, EventArgs e)
        {
            BuildAutoComanda();

            var newOperationForm = new NewComandaForm(ref _serviceApi, _auto);
            Hide();
            newOperationForm.ShowDialog();
            if (this.IsDisposed) return;
            Show();
        }

        private bool BuildAutoComanda()
        {
            try
            {
                var newSasiu = new Sasiu()
                {
                    CodSasiu = codSasiuTextBox.Text,
                    Denumire = denumireSasiuTextBox.Text
                };

                var serieSasiu =
                    $"{serieSasiuTextLeft.Text}{serieSasiuTextMiddle.Text}{serieSasiuTextRight.Text}";

                _auto = new Auto()
                {
                    Client = _client,
                    NumarAuto = numarAutoTextBox.Text,
                    Sasiu = newSasiu,
                    SerieSasiu = serieSasiu
                };

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private void WhenFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void CodSasiuTextBox_TextChanged(object sender, EventArgs e)
        {
            serieSasiuTextMiddle.Text = codSasiuTextBox.Text;
        }
    }
}
