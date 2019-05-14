using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarService;
using CarService.Service;

namespace CarService.WF.Forms
{
    public partial class MecanicForm : Form
    {
        private readonly IAutoService _serviceApi;
        private readonly IList<Mecanic> _listaMecanicsPerComanda = new List<Mecanic>();
        private IList<DetaliuComanda> _listaDetaliuComandas = new List<DetaliuComanda>();
        private IList<Mecanic> _listaAvailabelMecanics = new List<Mecanic>();
        private IList<Mecanic> _listaAllMecanics = new List<Mecanic>();

        public MecanicForm(ref IAutoService serviceApi)
        {
            _serviceApi = serviceApi;
            InitializeComponent();
            BuildDetaliiForm();
            BuildMecanicForm();
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

        private void BuildMecanicForm()
        {
            mecaniciiListView.Items.Clear();
            allMecanicsListBox.Items.Clear();
            mecaniciPerComandaList.Items.Clear();;

            _listaAvailabelMecanics = _serviceApi.GetAvailabelMecanics();
            _listaAllMecanics = _serviceApi.GetAllMecanics();

            foreach (var mecanic in _listaAvailabelMecanics)
            {
                mecaniciiListView.Items.Add($"{mecanic.Nume} {mecanic.Prenume}");
            }

            foreach (var mecanic in _listaAllMecanics)
            {
                allMecanicsListBox.Items.Add($"{mecanic.Nume} {mecanic.Prenume}");
            }
        }

        private void addMecanicToComendaButton_Click(object sender, EventArgs e)
        {
            var selectedComanda = _listaDetaliuComandas[comenziiListBox.FocusedItem.Index];
            var selectedMecanic = _listaAvailabelMecanics[mecaniciiListView.SelectedIndex];

            selectedComanda.Mecanici.Add(selectedMecanic);

            var userResponse = DialogResult.No;

            do
            {
                var response = _serviceApi.UpdateDetaliuComanda(selectedComanda);

                if (response)
                {
                    mecaniciPerComandaList.Items.Add($"{selectedMecanic.Nume} {selectedMecanic.Prenume}");
                    mecaniciiListView.Items.RemoveAt(mecaniciiListView.SelectedIndex);
                    _listaMecanicsPerComanda.Add(selectedMecanic);

                    MessageBox.Show($"Mecanic {selectedMecanic.Nume} {selectedMecanic.Prenume} added to comanda with numar Auto: {selectedComanda.Comanda.Auto.NumarAuto}", @"Succcesful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }

                userResponse = 
                    MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (userResponse == DialogResult.No) return;

            } while (userResponse == DialogResult.Yes);
        }

        private void comenziiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedComanda = _listaDetaliuComandas[comenziiListBox.FocusedItem.Index];
            var listaAllMecanics = _serviceApi.GetAllMecanics();

            mecaniciPerComandaList.Items.Clear();

            foreach (var mecanic in listaAllMecanics)
            {
                if (selectedComanda.Mecanici.Contains(mecanic))
                {
                    _listaMecanicsPerComanda.Add(mecanic);
                    mecaniciPerComandaList.Items.Add($"{mecanic.Nume} {mecanic.Prenume}");
                }
            }
        }

        private void deleteMecanicButton_Click(object sender, EventArgs e)
        {
            var selectedMecanic = _listaAllMecanics[allMecanicsListBox.SelectedIndex];

            var userResponse = DialogResult.No;

            do
            {
                var response = _serviceApi.DeleteMecanic(selectedMecanic);

                if (response)
                {
                    BuildMecanicForm();
                    MessageBox.Show($"Mecanic {selectedMecanic.Nume} {selectedMecanic.Prenume} remove from database.", @"Succcesful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }

                userResponse = 
                    MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (userResponse == DialogResult.No) return;

            } while (userResponse == DialogResult.Yes);
        }

        private void removeMecanicButton_Click(object sender, EventArgs e)
        {
            var selectedMecanicIndex = mecaniciPerComandaList.SelectedIndex;
            var selectedComanda = _listaDetaliuComandas[comenziiListBox.FocusedItem.Index];
            var selectedMecanic = _listaMecanicsPerComanda[selectedMecanicIndex];

            selectedComanda.Mecanici.Remove(selectedMecanic);

            var userResponse = DialogResult.No;

            do
            {
                var response = _serviceApi.UpdateDetaliuComanda(selectedComanda);

                if (response)
                {
                    mecaniciPerComandaList.Items.RemoveAt(selectedMecanicIndex);
                    _listaMecanicsPerComanda.RemoveAt(selectedMecanicIndex);
                    mecaniciiListView.Items.Add($"{selectedMecanic.Nume} {selectedMecanic.Prenume}");
                    _listaAvailabelMecanics.Add(selectedMecanic);

                    MessageBox.Show($"Mecanic {selectedMecanic.Nume} {selectedMecanic.Prenume} remove from comanda with numar Auto: {selectedComanda.Comanda.Auto.NumarAuto}", @"Succcesful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }

                userResponse = 
                    MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (userResponse == DialogResult.No) return;

            } while (userResponse == DialogResult.Yes);
        }

        private void addMecanicButton_Click(object sender, EventArgs e)
        {
            var tempMecanic = new Mecanic()
            {
                Nume = mecanicNumeText.Text,
                Prenume = mecanicPrenumeText.Text
            };

            var response = _serviceApi.CreateMecanic(tempMecanic);

            if (!response) return;

            mecaniciiListView.Items.Add($"{tempMecanic.Nume} {tempMecanic.Prenume}");
            allMecanicsListBox.Items.Add($"{tempMecanic.Nume} {tempMecanic.Prenume}");
            _listaAvailabelMecanics.Add(tempMecanic);
            _listaAllMecanics.Add(tempMecanic);
            mecaniciiListView.Refresh();
        }
    }
}
