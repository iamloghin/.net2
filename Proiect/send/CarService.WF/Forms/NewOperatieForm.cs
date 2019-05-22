using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService;
using CarService.Service;

namespace CarService.WF.Forms
{
    public partial class NewOperatieForm : Form
    {
        private readonly IAutoService _serviceApi;
        private readonly DetaliuComanda _detaliuComanda;
        private IList<Mecanic> _clientMecanics = new List<Mecanic>();

        public NewOperatieForm(ref IAutoService serviceApi, DetaliuComanda detaliuComanda)
        {
            _serviceApi = serviceApi;
            _detaliuComanda = detaliuComanda;
            InitializeComponent();
            BuildMecanicForm();
        }

        private void WhenFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void BuildMecanicForm()
        {
            _clientMecanics = _serviceApi.GetAvailabelMecanics();

            foreach (var mecanic in _clientMecanics)
            {
                mecanicListBox.Items.Add($"{mecanic.Nume} {mecanic.Prenume}");
            }
        }

        private void addOperatieButton_Click(object sender, EventArgs e)
        {
            var response = BuildOperatie();

            if (!response) return;

            operatiiListView.Refresh();
        }

        private bool BuildOperatie()
        {
            var operatie = new Operatie()
            {
                Denumire = addOperatieTextBox.Text,
                TimpExecutie = decimal.Parse(timpExecutieTextBox.Text)
            };

            DialogResult userResponse;

            do
            {
                var response = _serviceApi.AddOperatie(operatie, _detaliuComanda);

                if (response) break;

                userResponse = 
                    MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (userResponse == DialogResult.No) break;

            } while (userResponse == DialogResult.Yes);


            operatiiListView.Items.Add($"{operatie.Denumire}");

            return true;
        }

        private void addComandaButton_Click(object sender, EventArgs e)
        {
            if (operatiiListView.Items.Count == 0)
            {
                MessageBox.Show(@"Scuze, dar ca sa poti finaliza comanda este necesar macar o operatie.", @"Comanda need some operations",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedMecanics = new List<Mecanic>();

            for (var i = 0; i < mecanicListBox.Items.Count; i++)
                if (mecanicListBox.GetItemChecked(i))
                {
                    selectedMecanics.Add(_clientMecanics[i]);
                }

            DialogResult userResponse;

            do
            {
                var response = _serviceApi.AddMecanics(selectedMecanics, _detaliuComanda);

                if (response) break;

                userResponse = 
                    MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (userResponse == DialogResult.No) break;

            } while (userResponse == DialogResult.Yes);

            Application.Restart();
        }

        private void groupAvailableMecanic_Enter(object sender, EventArgs e)
        {

        }
    }
}
