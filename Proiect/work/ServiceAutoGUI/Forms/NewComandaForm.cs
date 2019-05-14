using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CarService.Service;
using CarService;
using static System.Drawing.Image;

namespace ServiceAutoGUI.Forms
{
    public partial class NewComandaForm : Form
    {
        private IAutoService _serviceApi;
        private readonly Auto _auto;
        private DetaliuComanda _detaliuComanda;
        private OpenFileDialog _openedFileDialog;
        private IList<ImageDto> _imaginesList = new List<ImageDto>();

        public NewComandaForm(ref IAutoService serviceApi, Auto auto)
        {
            _serviceApi = serviceApi;
            _auto = auto;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void newComandaButton_Click(object sender, EventArgs e)
        {
            BuildComanda();

            var response = _serviceApi.CreateDetaliuComanda(_detaliuComanda);

            if (!response) return;

            Application.Restart();
        }

        private bool BuildComanda()
        {
            try
            {
                var imageCounter = 0;
                var kmBoard = 0;
                var imagesList = new List<Imagine>();

                if (serviceAutoCheckBox.Checked)
                {
                    kmBoard = int.Parse(kmBoardTextBox.Text);
                }

                var comanda = new Comanda()
                {
                    Auto = _auto,
                    Client = _auto.Client,
                    DataProgramare = dataProgramareDatePicker.Value,
                    DataSystem = DateTime.Now,
                    Descriere = descriereComandaBox.Text,
                    StareComanda = StareComanda.InAsteptare,
                    KmBoard = kmBoard
                };

                
                foreach (var image in _imaginesList)
                {
                    var img = FromFile(image.Path);
                    var imageStream = new MemoryStream();
                    img.Save(imageStream, img.RawFormat);

                    imagesList.Add(new Imagine()
                    {
                        Data = DateTime.Now,
                        Descriere = image.Descriere,
                        Foto = imageStream.ToArray(),
                        Titlu = image.Titlu
                    });

                    imageCounter++;
                }
                

                _detaliuComanda = new DetaliuComanda()
                {
                    Comanda = comanda,
                    Imagines = imagesList
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

        private void addOperatiiButton_Click(object sender, EventArgs e)
        {
            BuildComanda();

            var response = _serviceApi.CreateDetaliuComanda(_detaliuComanda);

            if (!response) return;

            var newOperationForm = new NewOperatieForm(ref _serviceApi, _detaliuComanda);
            Hide();
            newOperationForm.ShowDialog();
            if (this.IsDisposed) return;
            Show();
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            _openedFileDialog = new OpenFileDialog
            {
                Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"
            };

            if (_openedFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addImageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.Image = new Bitmap(_imaginesList[addImageList.SelectedIndex].Path);
        }

        internal class ImageDto
        {
            public string Extension { get; set; }
            public string Path { get; set; }
            public string Titlu { get; set; }
            public string Descriere { get; set; }
        }

        private void uploadImageButton_Click_1(object sender, EventArgs e)
        {
            var fileInfo = new FileInfo(_openedFileDialog.FileName);

            _imaginesList.Add(new ImageDto()
            {
                Descriere = descriereImagineRichBox.Text,
                Titlu = titluImagineTextBox.Text,
                Path = _openedFileDialog.FileName,
                Extension = fileInfo.Extension
            });

            addImageList.Items.Add($"{_imaginesList.Last().Titlu}{_imaginesList.Last().Extension}");
            addImageList.Refresh();

            descriereImagineRichBox.Clear();
            titluImagineTextBox.Clear();
            _openedFileDialog.Dispose();
        }
    }
}
