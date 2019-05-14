using System;
using System.Windows.Forms;
using CarService.Service;

namespace CarService.WF.Forms
{
    public partial class ManagerForm : Form
    {
        private IAutoService _serviceApi;

        public ManagerForm(ref IAutoService serviceApi)
        {
            _serviceApi = serviceApi;
            InitializeComponent();
            SetComponentMarginAuto();
        }
        
        private void SetComponentMarginAuto()
        {
            const int fieldsDistant = 25;
            backButton.Left = (Width - backButton.Width) / 2;
            label2.Left = (Width - label2.Width) / 2;
            label1.Left = (Width - label1.Width) / 2;
            openMaterialViewButton.Left = (Width - openMaterialViewButton.Width) / 2;
            openOperatiiViewButton.Left = (Width - openOperatiiViewButton.Width) / 2;
            openMecanicViewButton.Left = (Width - openMecanicViewButton.Width) / 2;

            label2.Top = label2.Bottom + fieldsDistant;
            openMecanicViewButton.Top = label2.Bottom + fieldsDistant * 4;
            openOperatiiViewButton.Top = openMecanicViewButton.Bottom + fieldsDistant;
            openMaterialViewButton.Top = openOperatiiViewButton.Bottom + fieldsDistant;
            backButton.Top = openMaterialViewButton.Bottom + fieldsDistant;
        }

        private void openMecanicViewButton_Click(object sender, EventArgs e)
        {
            var mecanicForm = new MecanicForm(ref _serviceApi);
            Hide();
            mecanicForm.ShowDialog();
            if (this.IsDisposed) return;
            Show();
        }

        private void backButton_Click_1(object sender, EventArgs e)
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

        private void openOperatiiViewButton_Click(object sender, EventArgs e)
        {
            var operatieForm = new OperatieForm(ref _serviceApi);
            Hide();
            operatieForm.ShowDialog();
            if (this.IsDisposed) return;
            Show();
        }

        private void openMaterialViewButton_Click(object sender, EventArgs e)
        {
            var materialForm = new MaterialForm(ref _serviceApi);
            Hide();
            materialForm.ShowDialog();
            if (this.IsDisposed) return;
            Show();
        }
    }
}
