using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService;
using CarService.Service;

namespace ServiceAutoGUI.Forms
{
    public partial class OperatieForm : Form
    {
        private readonly IAutoService _serviceApi;
        private readonly IList<Operatie> _listaOperatiesPerComanda = new List<Operatie>();
        private IList<DetaliuComanda> _listaDetaliuComandas = new List<DetaliuComanda>();

        public OperatieForm(ref IAutoService serviceApi)
        {
            _serviceApi = serviceApi;
            InitializeComponent();
            BuildDetaliiForm();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void WhenFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void BuildDetaliiForm()
        {
            _listaDetaliuComandas = _serviceApi.GetAllDetaliuComandas();

            foreach (var comanda in _listaDetaliuComandas)
            {
                var item = new ListViewItem(new[] {comanda.Comanda.Client.Telefon, comanda.Comanda.Auto.NumarAuto, comanda.Comanda.Descriere});

                comenziiListBox.Items.Add((ListViewItem) item.Clone());
            }
        }

        private void addOperatieToComendaButton_Click(object sender, EventArgs e)
        {
            var response = BuildOperatie();

            if (!response) return;

            operatiiListView.Refresh();
        }

        private bool BuildOperatie()
        {
            var selectedComanda = _listaDetaliuComandas[comenziiListBox.FocusedItem.Index];

            var operatie = new Operatie()
            {
                Denumire = addOperatieTextBox.Text,
                TimpExecutie = decimal.Parse(timpExecutieTextBox.Text)
            };

            DialogResult userResponse;

            do
            {
                var response = _serviceApi.AddOperatie(operatie, selectedComanda);
                if (response)
                {
                    addOperatieTextBox.Text = "";
                    timpExecutieTextBox.Text = "";

                    MessageBox.Show($"Operatia \"{operatie.Denumire}\" adaugata comenzii cu numar auto: {selectedComanda.Comanda.Auto.NumarAuto}", @"Succcesful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                userResponse = 
                    MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (userResponse == DialogResult.No) break;
            } while (userResponse == DialogResult.Yes);

            operatiiListView.Items.Add($"{operatie.Denumire} : {operatie.TimpExecutie}");
            return true;
        }

        private void operatiiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedComanda = _listaDetaliuComandas[comenziiListBox.FocusedItem.Index];
            operatiiListView.Items.Clear();

            foreach (var operatie in selectedComanda.Operaties)
            {
                _listaOperatiesPerComanda.Add(operatie);
                operatiiListView.Items.Add($"{operatie.Denumire} : {operatie.TimpExecutie}");
            }
        }

        private void removeOperatieButton_Click(object sender, EventArgs e)
        {
            var selectedOperatieIndex = operatiiListView.SelectedIndex;
            var selectedComanda = _listaDetaliuComandas[comenziiListBox.FocusedItem.Index];
            var selectedOperatie = _listaOperatiesPerComanda[selectedOperatieIndex];

            var userResponse = DialogResult.No;

            do
            {
                var responseOperatie = _serviceApi.DeleteOperatie(selectedOperatie);

                if (responseOperatie)
                {
                    selectedComanda.Operaties.Remove(selectedOperatie);
                    var responseDetaliuComanda = _serviceApi.UpdateDetaliuComanda(selectedComanda);

                    if (responseDetaliuComanda)
                    {
                        operatiiListView.Items.RemoveAt(selectedOperatieIndex);
                        _listaOperatiesPerComanda.RemoveAt(selectedOperatieIndex);

                        MessageBox.Show($"Operatia {selectedOperatie.Denumire} remove from comanda with numar Auto: {selectedComanda.Comanda.Auto.NumarAuto}", @"Succcesful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        continue;
                    }
                }

                userResponse = 
                    MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (userResponse == DialogResult.No) return;

            } while (userResponse == DialogResult.Yes);
        }
    }
}
