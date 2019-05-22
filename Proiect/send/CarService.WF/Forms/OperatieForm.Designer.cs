namespace CarService.WF.Forms
{
    partial class OperatieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comenziiGroup = new System.Windows.Forms.GroupBox();
            this.removeOperatieButton = new System.Windows.Forms.Button();
            this.addOperatieToComendaButton = new System.Windows.Forms.Button();
            this.comenziiListBox = new System.Windows.Forms.ListView();
            this.telefonClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numarAuto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriereComanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupOperatii = new System.Windows.Forms.GroupBox();
            this.operatiiListView = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.groupOperatie = new System.Windows.Forms.GroupBox();
            this.timpExecutieTextBox = new System.Windows.Forms.TextBox();
            this.timpExecutieLabel = new System.Windows.Forms.Label();
            this.addOperatieLabel = new System.Windows.Forms.Label();
            this.addOperatieTextBox = new System.Windows.Forms.TextBox();
            this.comenziiGroup.SuspendLayout();
            this.groupOperatii.SuspendLayout();
            this.groupOperatie.SuspendLayout();
            this.SuspendLayout();
            // 
            // comenziiGroup
            // 
            this.comenziiGroup.Controls.Add(this.removeOperatieButton);
            this.comenziiGroup.Controls.Add(this.addOperatieToComendaButton);
            this.comenziiGroup.Controls.Add(this.comenziiListBox);
            this.comenziiGroup.Location = new System.Drawing.Point(284, 40);
            this.comenziiGroup.Name = "comenziiGroup";
            this.comenziiGroup.Size = new System.Drawing.Size(459, 344);
            this.comenziiGroup.TabIndex = 7;
            this.comenziiGroup.TabStop = false;
            this.comenziiGroup.Text = "Comenzii";
            // 
            // removeOperatieButton
            // 
            this.removeOperatieButton.Location = new System.Drawing.Point(327, 314);
            this.removeOperatieButton.Name = "removeOperatieButton";
            this.removeOperatieButton.Size = new System.Drawing.Size(126, 23);
            this.removeOperatieButton.TabIndex = 4;
            this.removeOperatieButton.Text = "Remove Operatie";
            this.removeOperatieButton.UseVisualStyleBackColor = true;
            this.removeOperatieButton.Click += new System.EventHandler(this.removeOperatieButton_Click);
            // 
            // addOperatieToComendaButton
            // 
            this.addOperatieToComendaButton.Location = new System.Drawing.Point(6, 314);
            this.addOperatieToComendaButton.Name = "addOperatieToComendaButton";
            this.addOperatieToComendaButton.Size = new System.Drawing.Size(315, 23);
            this.addOperatieToComendaButton.TabIndex = 1;
            this.addOperatieToComendaButton.Text = "Add Operatie to Selected Comanda";
            this.addOperatieToComendaButton.UseVisualStyleBackColor = true;
            this.addOperatieToComendaButton.Click += new System.EventHandler(this.addOperatieToComendaButton_Click);
            // 
            // comenziiListBox
            // 
            this.comenziiListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.telefonClient,
            this.numarAuto,
            this.descriereComanda});
            this.comenziiListBox.Location = new System.Drawing.Point(6, 16);
            this.comenziiListBox.Name = "comenziiListBox";
            this.comenziiListBox.Size = new System.Drawing.Size(447, 292);
            this.comenziiListBox.TabIndex = 0;
            this.comenziiListBox.UseCompatibleStateImageBehavior = false;
            this.comenziiListBox.View = System.Windows.Forms.View.Details;
            this.comenziiListBox.SelectedIndexChanged += new System.EventHandler(this.operatiiListBox_SelectedIndexChanged);
            // 
            // telefonClient
            // 
            this.telefonClient.Text = "Telefon Client";
            this.telefonClient.Width = 132;
            // 
            // numarAuto
            // 
            this.numarAuto.Text = "Numar Auto";
            this.numarAuto.Width = 148;
            // 
            // descriereComanda
            // 
            this.descriereComanda.Text = "Descriere Comanda";
            this.descriereComanda.Width = 161;
            // 
            // groupOperatii
            // 
            this.groupOperatii.Controls.Add(this.operatiiListView);
            this.groupOperatii.Location = new System.Drawing.Point(11, 176);
            this.groupOperatii.Name = "groupOperatii";
            this.groupOperatii.Size = new System.Drawing.Size(267, 208);
            this.groupOperatii.TabIndex = 6;
            this.groupOperatii.TabStop = false;
            this.groupOperatii.Text = "Operatii";
            // 
            // operatiiListView
            // 
            this.operatiiListView.FormattingEnabled = true;
            this.operatiiListView.Location = new System.Drawing.Point(9, 16);
            this.operatiiListView.Name = "operatiiListView";
            this.operatiiListView.Size = new System.Drawing.Size(248, 186);
            this.operatiiListView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(11, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupOperatie
            // 
            this.groupOperatie.Controls.Add(this.timpExecutieTextBox);
            this.groupOperatie.Controls.Add(this.timpExecutieLabel);
            this.groupOperatie.Controls.Add(this.addOperatieLabel);
            this.groupOperatie.Controls.Add(this.addOperatieTextBox);
            this.groupOperatie.Location = new System.Drawing.Point(11, 40);
            this.groupOperatie.Name = "groupOperatie";
            this.groupOperatie.Size = new System.Drawing.Size(267, 130);
            this.groupOperatie.TabIndex = 19;
            this.groupOperatie.TabStop = false;
            this.groupOperatie.Text = "Add operatie";
            // 
            // timpExecutieTextBox
            // 
            this.timpExecutieTextBox.Location = new System.Drawing.Point(111, 94);
            this.timpExecutieTextBox.Name = "timpExecutieTextBox";
            this.timpExecutieTextBox.Size = new System.Drawing.Size(150, 20);
            this.timpExecutieTextBox.TabIndex = 4;
            // 
            // timpExecutieLabel
            // 
            this.timpExecutieLabel.AutoSize = true;
            this.timpExecutieLabel.Location = new System.Drawing.Point(6, 97);
            this.timpExecutieLabel.Name = "timpExecutieLabel";
            this.timpExecutieLabel.Size = new System.Drawing.Size(71, 13);
            this.timpExecutieLabel.TabIndex = 3;
            this.timpExecutieLabel.Text = "TimpExecutie";
            // 
            // addOperatieLabel
            // 
            this.addOperatieLabel.AutoSize = true;
            this.addOperatieLabel.Location = new System.Drawing.Point(87, 30);
            this.addOperatieLabel.Name = "addOperatieLabel";
            this.addOperatieLabel.Size = new System.Drawing.Size(95, 13);
            this.addOperatieLabel.TabIndex = 1;
            this.addOperatieLabel.Text = "Descriere Operatie";
            // 
            // addOperatieTextBox
            // 
            this.addOperatieTextBox.Location = new System.Drawing.Point(6, 57);
            this.addOperatieTextBox.Name = "addOperatieTextBox";
            this.addOperatieTextBox.Size = new System.Drawing.Size(255, 20);
            this.addOperatieTextBox.TabIndex = 0;
            // 
            // OperatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 393);
            this.Controls.Add(this.groupOperatie);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.comenziiGroup);
            this.Controls.Add(this.groupOperatii);
            this.Name = "OperatieForm";
            this.Text = "OperatieForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhenFormClosing);
            this.comenziiGroup.ResumeLayout(false);
            this.groupOperatii.ResumeLayout(false);
            this.groupOperatie.ResumeLayout(false);
            this.groupOperatie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox comenziiGroup;
        private System.Windows.Forms.Button removeOperatieButton;
        private System.Windows.Forms.Button addOperatieToComendaButton;
        private System.Windows.Forms.ListView comenziiListBox;
        private System.Windows.Forms.ColumnHeader telefonClient;
        private System.Windows.Forms.ColumnHeader numarAuto;
        private System.Windows.Forms.ColumnHeader descriereComanda;
        private System.Windows.Forms.GroupBox groupOperatii;
        private System.Windows.Forms.ListBox operatiiListView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupOperatie;
        private System.Windows.Forms.TextBox timpExecutieTextBox;
        private System.Windows.Forms.Label timpExecutieLabel;
        private System.Windows.Forms.Label addOperatieLabel;
        private System.Windows.Forms.TextBox addOperatieTextBox;
    }
}