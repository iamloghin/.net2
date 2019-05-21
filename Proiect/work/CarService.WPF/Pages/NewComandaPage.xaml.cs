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
    using System.IO;
    using System.Windows.Forms;

    using CarService.WPF.Common;

    using MessageBox = System.Windows.MessageBox;
    using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

    /// <summary>
    /// Interaction logic for NewComandaPage.xaml
    /// </summary>
    public partial class NewComandaPage : Page
    {
        private readonly Auto _auto;
        private DetaliuComanda _detaliuComanda;
        private OpenFileDialog _openedFileDialog;
        private IList<ImageDto> _imaginesList = new List<ImageDto>();

        public NewComandaPage()
        {
            InitializeComponent();
        }

        public NewComandaPage(Auto auto)
        {
            _auto = auto;
            InitializeComponent();
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            CommonItem.GetFrame().NavigationService.Navigate(CommonItem.PageInstent.OfType<NewAutoPage>().First());
            CommonItem.GetTextBox().Text = "ADD NEW AUTO";
        }

        private void AddOperationButtonClick(object sender, RoutedEventArgs e)
        {
            BuildComanda();

            using (var autoApi = new AutoServiceClient())
            {
                try
                {
                    var response = autoApi.CreateDetaliuComanda(_detaliuComanda);

                    if (!response) return;

                    if (!CommonItem.PageInstent.OfType<NewOperatiePage>().Any())
                    {
                        CommonItem.PageInstent.Add(new NewOperatiePage(_detaliuComanda));
                    }

                    CommonItem.GetFrame().NavigationService
                        .Navigate(CommonItem.PageInstent.OfType<NewOperatiePage>().First());
                    CommonItem.GetTextBox().Text = "ADD OPERATIONS";
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something is wrong...");
                }
            }
        }

        private void AddCommandButtonClick(object sender, RoutedEventArgs e)
        {
            BuildComanda();
            using (var autoApi = new AutoServiceClient())
            {
                try
                {
                    var response = autoApi.CreateDetaliuComanda(_detaliuComanda);

                    if (!response) return;
                    CommonItem.PageInstent.Clear();
                    CommonItem.GetFrame().NavigationService.Navigate(new Dashboard());
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something is wrong...");
                }
            }
        }

        internal class ImageDto
        {
            public string Extension { get; set; }
            public string Path { get; set; }
            public string Titlu { get; set; }
            public string Descriere { get; set; }
        }

        private void BuildComanda()
        {
            try
            {
                var imageCounter = 0;
                var kmBoard = 0;
                var imagesList = new List<Imagine>();

                if (_serviceAutoCheckBox.IsChecked ?? false)
                {
                    kmBoard = int.Parse(_kmBoardTextBox.Text);
                }

                var comanda = new Comanda()
                                  {
                                      Auto = _auto,
                                      Client = _auto.Client,
                                      DataProgramare = _programDatePicker.DisplayDate.Date,
                                      DataSystem = DateTime.Now,
                                      Descriere = _commandDescBox.Text,
                                      StareComanda = StareComanda.InAsteptare,
                                      KmBoard = kmBoard
                                  };


                foreach (var image in _imaginesList)
                {
                    var img = new BitmapImage(new Uri(image.Path));
                    var memStream = new MemoryStream();
                    var encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(img));
                    encoder.Save(memStream);

                    var item = new Imagine()
                                   {
                                       Id = Guid.NewGuid(),
                                       Data = DateTime.Now,
                                       Descriere = image.Descriere,
                                       Foto = memStream.ToArray(),
                                       Titlu = image.Titlu,
                                   };

                    imagesList.Add(item);

                    imageCounter++;
                }

                _detaliuComanda = new DetaliuComanda()
                                      {
                                          Id = Guid.NewGuid(),
                                          Comanda = comanda,
                                          Imagines = imagesList
                                      };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void SelectImageButtonClick(object sender, RoutedEventArgs e)
        {
            _openedFileDialog = new OpenFileDialog
            {
                Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"
            };

            if ((bool)_openedFileDialog.ShowDialog())
            {
                var fileInfo = new FileInfo(_openedFileDialog.FileName);
                _imageTitleBox.Text = fileInfo.Name.Split('.').First();
                return;
            }

            MessageBox.Show(@"Ups.. change could not be done.  Try again ?", @"Something went wrong");
        }

        private void UploadImageButtonClick(object sender, RoutedEventArgs e)
        {
            var fileInfo = new FileInfo(_openedFileDialog.FileName);

            _imaginesList.Add(new ImageDto()
                                  {
                                      Descriere = _imageDescBox.Text,
                                      Titlu = _imageTitleBox.Text,
                                      Path = _openedFileDialog.FileName,
                                      Extension = fileInfo.Extension
                                  });

            _addImageList.Items.Add($"{_imaginesList.Last().Titlu}{_imaginesList.Last().Extension}");

            _imageDescBox.Clear();
            _imageTitleBox.Clear();
        }

        private void AddImageListSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _zoomBorder.Reset();
            _pictureBox.Source = new BitmapImage(new Uri(_imaginesList[_addImageList.SelectedIndex].Path));
        }
    }
}
