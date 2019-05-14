using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Service;

namespace ServiceAutoGUI.Forms
{
    public partial class MaterialForm : Form
    {
        private readonly IAutoService _serviceApi;
        private readonly IList<Material> _listaMaterialsPerComanda = new List<Material>();
        private IList<DetaliuComanda> _listaDetaliuComandas = new List<DetaliuComanda>();
        private IList<Material> _listaAvailabelMaterials = new List<Material>();
        private IList<Material> _listaAllMaterials = new List<Material>();

        public MaterialForm(ref IAutoService serviceApi)
        {
            _serviceApi = serviceApi;
            InitializeComponent();
            BuildDetaliiForm();
            BuildMaterialForm();
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

        private void BuildMaterialForm()
        {
            materialeListView.Items.Clear();
            allterialsListBox.Items.Clear();
            materialePerComandaList.Items.Clear();

            _listaAvailabelMaterials = _serviceApi.GetAvailabelMaterials();
            _listaAllMaterials = _serviceApi.GetAllMaterials();

            foreach (var material in _listaAvailabelMaterials)
            {
                materialeListView.Items.Add($"{material.Denumire} : {material.Cantitate}");
            }

            foreach (var material in _listaAllMaterials)
            {
                allterialsListBox.Items.Add($"{material.Denumire} : {material.Cantitate} : {material.Pret}");
            }
        }

        private void addMaterialToComendaButton_Click(object sender, EventArgs e)
        {
            if (cantitateMaterialAddText.Text.Length == 0)
            {
                cantitateMaterialAddText.BackColor = Color.Crimson;
                return;
            }

            var selectedComanda = _listaDetaliuComandas[comenziiListBox.FocusedItem.Index];
            var selectedMaterial = _listaAvailabelMaterials[materialeListView.SelectedIndex];

            var userResponse = DialogResult.No;

            do
            {
                var tempMaterial = selectedMaterial;
                tempMaterial.Cantitate -= int.Parse(cantitateMaterialAddText.Text);

                var responseMaterial = _serviceApi.UpdateMaterial(tempMaterial);

                if (responseMaterial)
                {
                    tempMaterial.Cantitate = int.Parse(cantitateMaterialAddText.Text);
                    selectedComanda.Materials.Add(tempMaterial);
                    
                    var responseComanda = _serviceApi.UpdateDetaliuComanda(selectedComanda);

                    if (responseComanda)
                    {
                        materialePerComandaList.Items.Add($"{selectedMaterial.Denumire} : {selectedMaterial.Cantitate}");
                        materialeListView.Items.RemoveAt(materialeListView.SelectedIndex);
                        materialeListView.Items.Add($"{selectedMaterial.Denumire} : {selectedMaterial.Cantitate}");
                        _listaMaterialsPerComanda.Add(selectedMaterial);

                        MessageBox.Show($"Material {selectedMaterial.Denumire} : {selectedMaterial.Cantitate} added to comanda with numar Auto: {selectedComanda.Comanda.Auto.NumarAuto}", @"Succcesful",
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

        private void comenziiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedComanda = _listaDetaliuComandas[comenziiListBox.FocusedItem.Index];
            var listaAllMaterials = _serviceApi.GetAllMaterials();

            materialePerComandaList.Items.Clear();

            foreach (var material in listaAllMaterials)
            {
                if (selectedComanda.Materials.Contains(material))
                {
                    _listaMaterialsPerComanda.Add(material);
                    materialePerComandaList.Items.Add($"{material.Denumire} : {material.Cantitate}");
                }
            }
        }

        private void deleteMaterialButton_Click(object sender, EventArgs e)
        {
            var selectedMaterial = _listaAllMaterials[allterialsListBox.SelectedIndex];

            var userResponse = DialogResult.No;

            do
            {
                var response = _serviceApi.DeleteMaterial(selectedMaterial);

                if (response)
                {
                    BuildMaterialForm();
                    MessageBox.Show($"Material {selectedMaterial.Denumire} : {selectedMaterial.Cantitate} remove from database.", @"Succcesful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }

                userResponse = 
                    MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (userResponse == DialogResult.No) return;

            } while (userResponse == DialogResult.Yes);
        }

        private void removeMaterialButton_Click(object sender, EventArgs e)
        {
            var selectedMaterialIndex = materialePerComandaList.SelectedIndex;
            var selectedComanda = _listaDetaliuComandas[comenziiListBox.FocusedItem.Index];
            var selectedMaterial = _listaMaterialsPerComanda[selectedMaterialIndex];

            selectedComanda.Materials.Remove(selectedMaterial);

            var userResponse = DialogResult.No;

            do
            {
                var responseMaterial = _serviceApi.DeleteMaterial(selectedMaterial);

                if (responseMaterial)
                {
                    selectedComanda.Materials.Remove(selectedMaterial);
                    var responseDetaliuComanda = _serviceApi.UpdateDetaliuComanda(selectedComanda);

                    if (responseDetaliuComanda)
                    {
                        materialeListView.Items.RemoveAt(selectedMaterialIndex);
                        _listaMaterialsPerComanda.RemoveAt(selectedMaterialIndex);

                        MessageBox.Show($"Material {selectedMaterial.Denumire} remove from database.", @"Succcesful",
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

        private void addMaterialButton_Click(object sender, EventArgs e)
        {
            var tempMaterial = new Material()
            {
                Denumire = denumireMaterialText.Text,
                Pret = int.Parse(pretMaterialText.Text),
                Cantitate =  int.Parse(cantitateMaterialText.Text),
                DataAprovizionare = aprovizionareMaterialPicker.Value
            };

            var response = _serviceApi.CreateMaterial(tempMaterial);

            if (!response) return;

            materialeListView.Items.Add($"{tempMaterial.Denumire} : {tempMaterial.Cantitate}");
            allterialsListBox.Items.Add($"{tempMaterial.Denumire} : {tempMaterial.Cantitate} : {tempMaterial.Pret}");
            _listaAvailabelMaterials.Add(tempMaterial);
            _listaAllMaterials.Add(tempMaterial);
            materialeListView.Refresh();
        }

        private void TextBoxFocused(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            textBox.BackColor = Color.White;
        }
    }
}
