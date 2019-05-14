namespace ServiceAutoGUI.Forms
{
    partial class MecanicForm
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
            this.allMecanicsGroup = new System.Windows.Forms.GroupBox();
            this.deleteMecanicButton = new System.Windows.Forms.Button();
            this.allMecanicsListBox = new System.Windows.Forms.ListBox();
            this.comenziiGroup = new System.Windows.Forms.GroupBox();
            this.removeMecanicButton = new System.Windows.Forms.Button();
            this.mecaniciPerComandaLGroup = new System.Windows.Forms.GroupBox();
            this.mecaniciPerComandaList = new System.Windows.Forms.ListBox();
            this.addMecanicToComendaButton = new System.Windows.Forms.Button();
            this.comenziiListBox = new System.Windows.Forms.ListView();
            this.telefonClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numarAuto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriereComanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupOperatii = new System.Windows.Forms.GroupBox();
            this.mecaniciiListView = new System.Windows.Forms.ListBox();
            this.addMecanicGroup = new System.Windows.Forms.GroupBox();
            this.mecanicPrenumeLabel = new System.Windows.Forms.Label();
            this.MecanicNameLabel = new System.Windows.Forms.Label();
            this.mecanicNumeText = new System.Windows.Forms.TextBox();
            this.mecanicPrenumeText = new System.Windows.Forms.TextBox();
            this.editMecanicButton = new System.Windows.Forms.Button();
            this.addMecanicButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.allMecanicsGroup.SuspendLayout();
            this.comenziiGroup.SuspendLayout();
            this.mecaniciPerComandaLGroup.SuspendLayout();
            this.groupOperatii.SuspendLayout();
            this.addMecanicGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // allMecanicsGroup
            // 
            this.allMecanicsGroup.Controls.Add(this.deleteMecanicButton);
            this.allMecanicsGroup.Controls.Add(this.allMecanicsListBox);
            this.allMecanicsGroup.Location = new System.Drawing.Point(749, 40);
            this.allMecanicsGroup.Name = "allMecanicsGroup";
            this.allMecanicsGroup.Size = new System.Drawing.Size(227, 344);
            this.allMecanicsGroup.TabIndex = 8;
            this.allMecanicsGroup.TabStop = false;
            this.allMecanicsGroup.Text = "Toti Mecanicii";
            // 
            // deleteMecanicButton
            // 
            this.deleteMecanicButton.Location = new System.Drawing.Point(9, 315);
            this.deleteMecanicButton.Name = "deleteMecanicButton";
            this.deleteMecanicButton.Size = new System.Drawing.Size(212, 23);
            this.deleteMecanicButton.TabIndex = 5;
            this.deleteMecanicButton.Text = "Delete Mecanic";
            this.deleteMecanicButton.UseVisualStyleBackColor = true;
            this.deleteMecanicButton.Click += new System.EventHandler(this.deleteMecanicButton_Click);
            // 
            // allMecanicsListBox
            // 
            this.allMecanicsListBox.FormattingEnabled = true;
            this.allMecanicsListBox.Location = new System.Drawing.Point(9, 19);
            this.allMecanicsListBox.Name = "allMecanicsListBox";
            this.allMecanicsListBox.Size = new System.Drawing.Size(212, 290);
            this.allMecanicsListBox.TabIndex = 0;
            // 
            // comenziiGroup
            // 
            this.comenziiGroup.Controls.Add(this.removeMecanicButton);
            this.comenziiGroup.Controls.Add(this.mecaniciPerComandaLGroup);
            this.comenziiGroup.Controls.Add(this.addMecanicToComendaButton);
            this.comenziiGroup.Controls.Add(this.comenziiListBox);
            this.comenziiGroup.Location = new System.Drawing.Point(284, 40);
            this.comenziiGroup.Name = "comenziiGroup";
            this.comenziiGroup.Size = new System.Drawing.Size(459, 344);
            this.comenziiGroup.TabIndex = 7;
            this.comenziiGroup.TabStop = false;
            this.comenziiGroup.Text = "Comenzii";
            // 
            // removeMecanicButton
            // 
            this.removeMecanicButton.Location = new System.Drawing.Point(327, 314);
            this.removeMecanicButton.Name = "removeMecanicButton";
            this.removeMecanicButton.Size = new System.Drawing.Size(126, 23);
            this.removeMecanicButton.TabIndex = 4;
            this.removeMecanicButton.Text = "Remove Mecanic";
            this.removeMecanicButton.UseVisualStyleBackColor = true;
            this.removeMecanicButton.Click += new System.EventHandler(this.removeMecanicButton_Click);
            // 
            // mecaniciPerComandaLGroup
            // 
            this.mecaniciPerComandaLGroup.Controls.Add(this.mecaniciPerComandaList);
            this.mecaniciPerComandaLGroup.Location = new System.Drawing.Point(6, 180);
            this.mecaniciPerComandaLGroup.Name = "mecaniciPerComandaLGroup";
            this.mecaniciPerComandaLGroup.Size = new System.Drawing.Size(447, 128);
            this.mecaniciPerComandaLGroup.TabIndex = 3;
            this.mecaniciPerComandaLGroup.TabStop = false;
            this.mecaniciPerComandaLGroup.Text = "Mecanicii Per Comanda Selectata";
            // 
            // mecaniciPerComandaList
            // 
            this.mecaniciPerComandaList.FormattingEnabled = true;
            this.mecaniciPerComandaList.Location = new System.Drawing.Point(9, 19);
            this.mecaniciPerComandaList.Name = "mecaniciPerComandaList";
            this.mecaniciPerComandaList.Size = new System.Drawing.Size(432, 95);
            this.mecaniciPerComandaList.TabIndex = 0;
            // 
            // addMecanicToComendaButton
            // 
            this.addMecanicToComendaButton.Location = new System.Drawing.Point(6, 314);
            this.addMecanicToComendaButton.Name = "addMecanicToComendaButton";
            this.addMecanicToComendaButton.Size = new System.Drawing.Size(315, 23);
            this.addMecanicToComendaButton.TabIndex = 1;
            this.addMecanicToComendaButton.Text = "Add Mecanic to Selected Comanda";
            this.addMecanicToComendaButton.UseVisualStyleBackColor = true;
            this.addMecanicToComendaButton.Click += new System.EventHandler(this.addMecanicToComendaButton_Click);
            // 
            // comenziiListBox
            // 
            this.comenziiListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.telefonClient,
            this.numarAuto,
            this.descriereComanda});
            this.comenziiListBox.Location = new System.Drawing.Point(6, 16);
            this.comenziiListBox.Name = "comenziiListBox";
            this.comenziiListBox.Size = new System.Drawing.Size(447, 158);
            this.comenziiListBox.TabIndex = 0;
            this.comenziiListBox.UseCompatibleStateImageBehavior = false;
            this.comenziiListBox.View = System.Windows.Forms.View.Details;
            this.comenziiListBox.SelectedIndexChanged += new System.EventHandler(this.comenziiListBox_SelectedIndexChanged);
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
            this.groupOperatii.Controls.Add(this.mecaniciiListView);
            this.groupOperatii.Location = new System.Drawing.Point(11, 159);
            this.groupOperatii.Name = "groupOperatii";
            this.groupOperatii.Size = new System.Drawing.Size(267, 225);
            this.groupOperatii.TabIndex = 6;
            this.groupOperatii.TabStop = false;
            this.groupOperatii.Text = "Mecanicii Disponibilii";
            // 
            // mecaniciiListView
            // 
            this.mecaniciiListView.FormattingEnabled = true;
            this.mecaniciiListView.Location = new System.Drawing.Point(9, 19);
            this.mecaniciiListView.Name = "mecaniciiListView";
            this.mecaniciiListView.Size = new System.Drawing.Size(248, 199);
            this.mecaniciiListView.TabIndex = 0;
            // 
            // addMecanicGroup
            // 
            this.addMecanicGroup.Controls.Add(this.mecanicPrenumeLabel);
            this.addMecanicGroup.Controls.Add(this.MecanicNameLabel);
            this.addMecanicGroup.Controls.Add(this.mecanicNumeText);
            this.addMecanicGroup.Controls.Add(this.mecanicPrenumeText);
            this.addMecanicGroup.Controls.Add(this.editMecanicButton);
            this.addMecanicGroup.Controls.Add(this.addMecanicButton);
            this.addMecanicGroup.Location = new System.Drawing.Point(11, 40);
            this.addMecanicGroup.Name = "addMecanicGroup";
            this.addMecanicGroup.Size = new System.Drawing.Size(267, 113);
            this.addMecanicGroup.TabIndex = 5;
            this.addMecanicGroup.TabStop = false;
            this.addMecanicGroup.Text = "Add Mecanic";
            // 
            // mecanicPrenumeLabel
            // 
            this.mecanicPrenumeLabel.AutoSize = true;
            this.mecanicPrenumeLabel.Location = new System.Drawing.Point(6, 51);
            this.mecanicPrenumeLabel.Name = "mecanicPrenumeLabel";
            this.mecanicPrenumeLabel.Size = new System.Drawing.Size(49, 13);
            this.mecanicPrenumeLabel.TabIndex = 3;
            this.mecanicPrenumeLabel.Text = "Prenume";
            // 
            // MecanicNameLabel
            // 
            this.MecanicNameLabel.AutoSize = true;
            this.MecanicNameLabel.Location = new System.Drawing.Point(6, 25);
            this.MecanicNameLabel.Name = "MecanicNameLabel";
            this.MecanicNameLabel.Size = new System.Drawing.Size(35, 13);
            this.MecanicNameLabel.TabIndex = 1;
            this.MecanicNameLabel.Text = "Nume";
            // 
            // mecanicNumeText
            // 
            this.mecanicNumeText.Location = new System.Drawing.Point(94, 22);
            this.mecanicNumeText.MaxLength = 15;
            this.mecanicNumeText.Name = "mecanicNumeText";
            this.mecanicNumeText.Size = new System.Drawing.Size(163, 20);
            this.mecanicNumeText.TabIndex = 2;
            // 
            // mecanicPrenumeText
            // 
            this.mecanicPrenumeText.Location = new System.Drawing.Point(94, 48);
            this.mecanicPrenumeText.MaxLength = 15;
            this.mecanicPrenumeText.Name = "mecanicPrenumeText";
            this.mecanicPrenumeText.Size = new System.Drawing.Size(163, 20);
            this.mecanicPrenumeText.TabIndex = 4;
            // 
            // editMecanicButton
            // 
            this.editMecanicButton.Location = new System.Drawing.Point(6, 81);
            this.editMecanicButton.Name = "editMecanicButton";
            this.editMecanicButton.Size = new System.Drawing.Size(75, 23);
            this.editMecanicButton.TabIndex = 6;
            this.editMecanicButton.Text = "Edit";
            this.editMecanicButton.UseVisualStyleBackColor = true;
            // 
            // addMecanicButton
            // 
            this.addMecanicButton.Location = new System.Drawing.Point(94, 81);
            this.addMecanicButton.Name = "addMecanicButton";
            this.addMecanicButton.Size = new System.Drawing.Size(163, 23);
            this.addMecanicButton.TabIndex = 5;
            this.addMecanicButton.Text = "Add To List";
            this.addMecanicButton.UseVisualStyleBackColor = true;
            this.addMecanicButton.Click += new System.EventHandler(this.addMecanicButton_Click);
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
            // MecanicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 393);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.allMecanicsGroup);
            this.Controls.Add(this.comenziiGroup);
            this.Controls.Add(this.groupOperatii);
            this.Controls.Add(this.addMecanicGroup);
            this.Name = "MecanicForm";
            this.Text = "MecanicForm";
            this.allMecanicsGroup.ResumeLayout(false);
            this.comenziiGroup.ResumeLayout(false);
            this.mecaniciPerComandaLGroup.ResumeLayout(false);
            this.groupOperatii.ResumeLayout(false);
            this.addMecanicGroup.ResumeLayout(false);
            this.addMecanicGroup.PerformLayout();
            this.ResumeLayout(false);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhenFormClosing);
        }

        #endregion

        private System.Windows.Forms.GroupBox allMecanicsGroup;
        private System.Windows.Forms.Button deleteMecanicButton;
        private System.Windows.Forms.ListBox allMecanicsListBox;
        private System.Windows.Forms.GroupBox comenziiGroup;
        private System.Windows.Forms.Button removeMecanicButton;
        private System.Windows.Forms.GroupBox mecaniciPerComandaLGroup;
        private System.Windows.Forms.ListBox mecaniciPerComandaList;
        private System.Windows.Forms.Button addMecanicToComendaButton;
        private System.Windows.Forms.ListView comenziiListBox;
        private System.Windows.Forms.ColumnHeader telefonClient;
        private System.Windows.Forms.ColumnHeader numarAuto;
        private System.Windows.Forms.ColumnHeader descriereComanda;
        private System.Windows.Forms.GroupBox groupOperatii;
        private System.Windows.Forms.ListBox mecaniciiListView;
        private System.Windows.Forms.GroupBox addMecanicGroup;
        private System.Windows.Forms.Label mecanicPrenumeLabel;
        private System.Windows.Forms.Label MecanicNameLabel;
        private System.Windows.Forms.TextBox mecanicNumeText;
        private System.Windows.Forms.TextBox mecanicPrenumeText;
        private System.Windows.Forms.Button editMecanicButton;
        private System.Windows.Forms.Button addMecanicButton;
        private System.Windows.Forms.Button backButton;
    }
}