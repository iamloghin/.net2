namespace ServiceAutoGUI.Forms
{
    partial class MaterialForm
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
            this.allMaterialsGroup = new System.Windows.Forms.GroupBox();
            this.deleteMaterialButton = new System.Windows.Forms.Button();
            this.allterialsListBox = new System.Windows.Forms.ListBox();
            this.comenziiGroup = new System.Windows.Forms.GroupBox();
            this.removeMaterialButton = new System.Windows.Forms.Button();
            this.materialePerComandaGroup = new System.Windows.Forms.GroupBox();
            this.materialePerComandaList = new System.Windows.Forms.ListBox();
            this.addMaterialToComendaButton = new System.Windows.Forms.Button();
            this.comenziiListBox = new System.Windows.Forms.ListView();
            this.telefonClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numarAuto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriereComanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupMaterial = new System.Windows.Forms.GroupBox();
            this.cantitateMaterialAddText = new System.Windows.Forms.TextBox();
            this.cantitateMaterialAddLabel = new System.Windows.Forms.Label();
            this.materialeListView = new System.Windows.Forms.ListBox();
            this.addMaterialGroup = new System.Windows.Forms.GroupBox();
            this.aprovizionareMaterialPicker = new System.Windows.Forms.DateTimePicker();
            this.ApprovizionareLabel = new System.Windows.Forms.Label();
            this.pretMaterialText = new System.Windows.Forms.TextBox();
            this.pretMaterialLabel = new System.Windows.Forms.Label();
            this.cantitateMaterialText = new System.Windows.Forms.TextBox();
            this.cantitateMaterialLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.denumireMaterialText = new System.Windows.Forms.TextBox();
            this.editMaterialButton = new System.Windows.Forms.Button();
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.allMaterialsGroup.SuspendLayout();
            this.comenziiGroup.SuspendLayout();
            this.materialePerComandaGroup.SuspendLayout();
            this.groupMaterial.SuspendLayout();
            this.addMaterialGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // allMaterialsGroup
            // 
            this.allMaterialsGroup.Controls.Add(this.deleteMaterialButton);
            this.allMaterialsGroup.Controls.Add(this.allterialsListBox);
            this.allMaterialsGroup.Location = new System.Drawing.Point(749, 40);
            this.allMaterialsGroup.Name = "allMaterialsGroup";
            this.allMaterialsGroup.Size = new System.Drawing.Size(227, 344);
            this.allMaterialsGroup.TabIndex = 8;
            this.allMaterialsGroup.TabStop = false;
            this.allMaterialsGroup.Text = "Toate Materialele";
            // 
            // deleteMaterialButton
            // 
            this.deleteMaterialButton.Location = new System.Drawing.Point(9, 315);
            this.deleteMaterialButton.Name = "deleteMaterialButton";
            this.deleteMaterialButton.Size = new System.Drawing.Size(212, 23);
            this.deleteMaterialButton.TabIndex = 5;
            this.deleteMaterialButton.Text = "Delete Material";
            this.deleteMaterialButton.UseVisualStyleBackColor = true;
            this.deleteMaterialButton.Click += new System.EventHandler(this.deleteMaterialButton_Click);
            // 
            // allterialsListBox
            // 
            this.allterialsListBox.FormattingEnabled = true;
            this.allterialsListBox.Location = new System.Drawing.Point(9, 19);
            this.allterialsListBox.Name = "allterialsListBox";
            this.allterialsListBox.Size = new System.Drawing.Size(212, 290);
            this.allterialsListBox.TabIndex = 0;
            // 
            // comenziiGroup
            // 
            this.comenziiGroup.Controls.Add(this.removeMaterialButton);
            this.comenziiGroup.Controls.Add(this.materialePerComandaGroup);
            this.comenziiGroup.Controls.Add(this.addMaterialToComendaButton);
            this.comenziiGroup.Controls.Add(this.comenziiListBox);
            this.comenziiGroup.Location = new System.Drawing.Point(284, 40);
            this.comenziiGroup.Name = "comenziiGroup";
            this.comenziiGroup.Size = new System.Drawing.Size(459, 344);
            this.comenziiGroup.TabIndex = 7;
            this.comenziiGroup.TabStop = false;
            this.comenziiGroup.Text = "Comenzii";
            // 
            // removeMaterialButton
            // 
            this.removeMaterialButton.Location = new System.Drawing.Point(327, 314);
            this.removeMaterialButton.Name = "removeMaterialButton";
            this.removeMaterialButton.Size = new System.Drawing.Size(126, 23);
            this.removeMaterialButton.TabIndex = 4;
            this.removeMaterialButton.Text = "Remove Material";
            this.removeMaterialButton.UseVisualStyleBackColor = true;
            this.removeMaterialButton.Click += new System.EventHandler(this.removeMaterialButton_Click);
            // 
            // materialePerComandaGroup
            // 
            this.materialePerComandaGroup.Controls.Add(this.materialePerComandaList);
            this.materialePerComandaGroup.Location = new System.Drawing.Point(6, 180);
            this.materialePerComandaGroup.Name = "materialePerComandaGroup";
            this.materialePerComandaGroup.Size = new System.Drawing.Size(447, 128);
            this.materialePerComandaGroup.TabIndex = 3;
            this.materialePerComandaGroup.TabStop = false;
            this.materialePerComandaGroup.Text = "Materiale Per Comanda Selectata";
            // 
            // materialePerComandaList
            // 
            this.materialePerComandaList.FormattingEnabled = true;
            this.materialePerComandaList.Location = new System.Drawing.Point(9, 19);
            this.materialePerComandaList.Name = "materialePerComandaList";
            this.materialePerComandaList.Size = new System.Drawing.Size(432, 95);
            this.materialePerComandaList.TabIndex = 0;
            // 
            // addMaterialToComendaButton
            // 
            this.addMaterialToComendaButton.Location = new System.Drawing.Point(6, 314);
            this.addMaterialToComendaButton.Name = "addMaterialToComendaButton";
            this.addMaterialToComendaButton.Size = new System.Drawing.Size(315, 23);
            this.addMaterialToComendaButton.TabIndex = 1;
            this.addMaterialToComendaButton.Text = "Add Material to Selected Comanda";
            this.addMaterialToComendaButton.UseVisualStyleBackColor = true;
            this.addMaterialToComendaButton.Click += new System.EventHandler(this.addMaterialToComendaButton_Click);
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
            // groupMaterial
            // 
            this.groupMaterial.Controls.Add(this.cantitateMaterialAddText);
            this.groupMaterial.Controls.Add(this.cantitateMaterialAddLabel);
            this.groupMaterial.Controls.Add(this.materialeListView);
            this.groupMaterial.Location = new System.Drawing.Point(11, 267);
            this.groupMaterial.Name = "groupMaterial";
            this.groupMaterial.Size = new System.Drawing.Size(267, 117);
            this.groupMaterial.TabIndex = 6;
            this.groupMaterial.TabStop = false;
            this.groupMaterial.Text = "Materiale Disponibile";
            // 
            // cantitateMaterialAddText
            // 
            this.cantitateMaterialAddText.Location = new System.Drawing.Point(111, 87);
            this.cantitateMaterialAddText.Name = "cantitateMaterialAddText";
            this.cantitateMaterialAddText.Size = new System.Drawing.Size(146, 20);
            this.cantitateMaterialAddText.TabIndex = 14;
            this.cantitateMaterialAddText.GotFocus += new System.EventHandler(this.TextBoxFocused);
            // 
            // cantitateMaterialAddLabel
            // 
            this.cantitateMaterialAddLabel.AutoSize = true;
            this.cantitateMaterialAddLabel.Location = new System.Drawing.Point(11, 90);
            this.cantitateMaterialAddLabel.Name = "cantitateMaterialAddLabel";
            this.cantitateMaterialAddLabel.Size = new System.Drawing.Size(49, 13);
            this.cantitateMaterialAddLabel.TabIndex = 13;
            this.cantitateMaterialAddLabel.Text = "Cantitate";
            // 
            // materialeListView
            // 
            this.materialeListView.FormattingEnabled = true;
            this.materialeListView.Location = new System.Drawing.Point(9, 16);
            this.materialeListView.Name = "materialeListView";
            this.materialeListView.Size = new System.Drawing.Size(248, 56);
            this.materialeListView.TabIndex = 0;
            // 
            // addMaterialGroup
            // 
            this.addMaterialGroup.Controls.Add(this.aprovizionareMaterialPicker);
            this.addMaterialGroup.Controls.Add(this.ApprovizionareLabel);
            this.addMaterialGroup.Controls.Add(this.pretMaterialText);
            this.addMaterialGroup.Controls.Add(this.pretMaterialLabel);
            this.addMaterialGroup.Controls.Add(this.cantitateMaterialText);
            this.addMaterialGroup.Controls.Add(this.cantitateMaterialLabel);
            this.addMaterialGroup.Controls.Add(this.label2);
            this.addMaterialGroup.Controls.Add(this.denumireMaterialText);
            this.addMaterialGroup.Controls.Add(this.editMaterialButton);
            this.addMaterialGroup.Controls.Add(this.addMaterialButton);
            this.addMaterialGroup.Location = new System.Drawing.Point(11, 40);
            this.addMaterialGroup.Name = "addMaterialGroup";
            this.addMaterialGroup.Size = new System.Drawing.Size(267, 221);
            this.addMaterialGroup.TabIndex = 5;
            this.addMaterialGroup.TabStop = false;
            this.addMaterialGroup.Text = "Add Material";
            // 
            // aprovizionareMaterialPicker
            // 
            this.aprovizionareMaterialPicker.Location = new System.Drawing.Point(30, 149);
            this.aprovizionareMaterialPicker.Name = "aprovizionareMaterialPicker";
            this.aprovizionareMaterialPicker.Size = new System.Drawing.Size(200, 20);
            this.aprovizionareMaterialPicker.TabIndex = 16;
            // 
            // ApprovizionareLabel
            // 
            this.ApprovizionareLabel.AutoSize = true;
            this.ApprovizionareLabel.Location = new System.Drawing.Point(87, 124);
            this.ApprovizionareLabel.Name = "ApprovizionareLabel";
            this.ApprovizionareLabel.Size = new System.Drawing.Size(71, 13);
            this.ApprovizionareLabel.TabIndex = 15;
            this.ApprovizionareLabel.Text = "Aprovizionare";
            // 
            // pretMaterialText
            // 
            this.pretMaterialText.Location = new System.Drawing.Point(111, 91);
            this.pretMaterialText.Name = "pretMaterialText";
            this.pretMaterialText.Size = new System.Drawing.Size(150, 20);
            this.pretMaterialText.TabIndex = 14;
            // 
            // pretMaterialLabel
            // 
            this.pretMaterialLabel.AutoSize = true;
            this.pretMaterialLabel.Location = new System.Drawing.Point(6, 94);
            this.pretMaterialLabel.Name = "pretMaterialLabel";
            this.pretMaterialLabel.Size = new System.Drawing.Size(26, 13);
            this.pretMaterialLabel.TabIndex = 13;
            this.pretMaterialLabel.Text = "Pret";
            // 
            // cantitateMaterialText
            // 
            this.cantitateMaterialText.Location = new System.Drawing.Point(111, 65);
            this.cantitateMaterialText.Name = "cantitateMaterialText";
            this.cantitateMaterialText.Size = new System.Drawing.Size(150, 20);
            this.cantitateMaterialText.TabIndex = 12;
            // 
            // cantitateMaterialLabel
            // 
            this.cantitateMaterialLabel.AutoSize = true;
            this.cantitateMaterialLabel.Location = new System.Drawing.Point(6, 68);
            this.cantitateMaterialLabel.Name = "cantitateMaterialLabel";
            this.cantitateMaterialLabel.Size = new System.Drawing.Size(49, 13);
            this.cantitateMaterialLabel.TabIndex = 11;
            this.cantitateMaterialLabel.Text = "Cantitate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Denumire Material";
            // 
            // denumireMaterialText
            // 
            this.denumireMaterialText.Location = new System.Drawing.Point(6, 39);
            this.denumireMaterialText.MaxLength = 50;
            this.denumireMaterialText.Name = "denumireMaterialText";
            this.denumireMaterialText.Size = new System.Drawing.Size(255, 20);
            this.denumireMaterialText.TabIndex = 9;
            // 
            // editMaterialButton
            // 
            this.editMaterialButton.Location = new System.Drawing.Point(6, 190);
            this.editMaterialButton.Name = "editMaterialButton";
            this.editMaterialButton.Size = new System.Drawing.Size(75, 24);
            this.editMaterialButton.TabIndex = 6;
            this.editMaterialButton.Text = "Edit";
            this.editMaterialButton.UseVisualStyleBackColor = true;
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.Location = new System.Drawing.Point(94, 190);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(163, 24);
            this.addMaterialButton.TabIndex = 5;
            this.addMaterialButton.Text = "Add To List";
            this.addMaterialButton.UseVisualStyleBackColor = true;
            this.addMaterialButton.Click += new System.EventHandler(this.addMaterialButton_Click);
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
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 393);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.allMaterialsGroup);
            this.Controls.Add(this.comenziiGroup);
            this.Controls.Add(this.groupMaterial);
            this.Controls.Add(this.addMaterialGroup);
            this.Name = "MaterialForm";
            this.Text = "MaterialeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhenFormClosing);
            this.allMaterialsGroup.ResumeLayout(false);
            this.comenziiGroup.ResumeLayout(false);
            this.materialePerComandaGroup.ResumeLayout(false);
            this.groupMaterial.ResumeLayout(false);
            this.groupMaterial.PerformLayout();
            this.addMaterialGroup.ResumeLayout(false);
            this.addMaterialGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox allMaterialsGroup;
        private System.Windows.Forms.Button deleteMaterialButton;
        private System.Windows.Forms.ListBox allterialsListBox;
        private System.Windows.Forms.GroupBox comenziiGroup;
        private System.Windows.Forms.Button removeMaterialButton;
        private System.Windows.Forms.GroupBox materialePerComandaGroup;
        private System.Windows.Forms.ListBox materialePerComandaList;
        private System.Windows.Forms.Button addMaterialToComendaButton;
        private System.Windows.Forms.ListView comenziiListBox;
        private System.Windows.Forms.ColumnHeader telefonClient;
        private System.Windows.Forms.ColumnHeader numarAuto;
        private System.Windows.Forms.ColumnHeader descriereComanda;
        private System.Windows.Forms.GroupBox groupMaterial;
        private System.Windows.Forms.ListBox materialeListView;
        private System.Windows.Forms.GroupBox addMaterialGroup;
        private System.Windows.Forms.Button editMaterialButton;
        private System.Windows.Forms.Button addMaterialButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DateTimePicker aprovizionareMaterialPicker;
        private System.Windows.Forms.Label ApprovizionareLabel;
        private System.Windows.Forms.TextBox pretMaterialText;
        private System.Windows.Forms.Label pretMaterialLabel;
        private System.Windows.Forms.TextBox cantitateMaterialText;
        private System.Windows.Forms.Label cantitateMaterialLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox denumireMaterialText;
        private System.Windows.Forms.TextBox cantitateMaterialAddText;
        private System.Windows.Forms.Label cantitateMaterialAddLabel;
    }
}