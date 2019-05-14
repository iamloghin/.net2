using System.Windows.Forms;

namespace ServiceAutoGUI.Forms
{
    partial class NewOperatieForm
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
            this.groupOperatie = new System.Windows.Forms.GroupBox();
            this.timpExecutieTextBox = new System.Windows.Forms.TextBox();
            this.timpExecutieLabel = new System.Windows.Forms.Label();
            this.addOperatieButton = new System.Windows.Forms.Button();
            this.addOperatieLabel = new System.Windows.Forms.Label();
            this.addOperatieTextBox = new System.Windows.Forms.TextBox();
            this.groupOperatii = new System.Windows.Forms.GroupBox();
            this.operatiiListView = new System.Windows.Forms.ListBox();
            this.mecanicListBox = new System.Windows.Forms.CheckedListBox();
            this.groupAvailableMecanic = new System.Windows.Forms.GroupBox();
            this.addComandaButton = new System.Windows.Forms.Button();
            this.groupOperatie.SuspendLayout();
            this.groupOperatii.SuspendLayout();
            this.groupAvailableMecanic.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupOperatie
            // 
            this.groupOperatie.Controls.Add(this.timpExecutieTextBox);
            this.groupOperatie.Controls.Add(this.timpExecutieLabel);
            this.groupOperatie.Controls.Add(this.addOperatieButton);
            this.groupOperatie.Controls.Add(this.addOperatieLabel);
            this.groupOperatie.Controls.Add(this.addOperatieTextBox);
            this.groupOperatie.Location = new System.Drawing.Point(12, 12);
            this.groupOperatie.Name = "groupOperatie";
            this.groupOperatie.Size = new System.Drawing.Size(238, 166);
            this.groupOperatie.TabIndex = 0;
            this.groupOperatie.TabStop = false;
            this.groupOperatie.Text = "Add operatie";
            // 
            // timpExecutieTextBox
            // 
            this.timpExecutieTextBox.Location = new System.Drawing.Point(83, 93);
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
            // addOperatieButton
            // 
            this.addOperatieButton.Location = new System.Drawing.Point(6, 131);
            this.addOperatieButton.Name = "addOperatieButton";
            this.addOperatieButton.Size = new System.Drawing.Size(227, 23);
            this.addOperatieButton.TabIndex = 2;
            this.addOperatieButton.Text = "Add Operatie";
            this.addOperatieButton.UseVisualStyleBackColor = true;
            this.addOperatieButton.Click += new System.EventHandler(this.addOperatieButton_Click);
            // 
            // addOperatieLabel
            // 
            this.addOperatieLabel.AutoSize = true;
            this.addOperatieLabel.Location = new System.Drawing.Point(71, 30);
            this.addOperatieLabel.Name = "addOperatieLabel";
            this.addOperatieLabel.Size = new System.Drawing.Size(95, 13);
            this.addOperatieLabel.TabIndex = 1;
            this.addOperatieLabel.Text = "Descriere Operatie";
            // 
            // addOperatieTextBox
            // 
            this.addOperatieTextBox.Location = new System.Drawing.Point(6, 57);
            this.addOperatieTextBox.Name = "addOperatieTextBox";
            this.addOperatieTextBox.Size = new System.Drawing.Size(227, 20);
            this.addOperatieTextBox.TabIndex = 0;
            // 
            // groupOperatii
            // 
            this.groupOperatii.Controls.Add(this.operatiiListView);
            this.groupOperatii.Location = new System.Drawing.Point(12, 184);
            this.groupOperatii.Name = "groupOperatii";
            this.groupOperatii.Size = new System.Drawing.Size(456, 230);
            this.groupOperatii.TabIndex = 1;
            this.groupOperatii.TabStop = false;
            this.groupOperatii.Text = "Operatii";
            // 
            // operatiiListView
            // 
            this.operatiiListView.FormattingEnabled = true;
            this.operatiiListView.Location = new System.Drawing.Point(9, 19);
            this.operatiiListView.Name = "operatiiListView";
            this.operatiiListView.Size = new System.Drawing.Size(441, 199);
            this.operatiiListView.TabIndex = 0;
            // 
            // mecanicListBox
            // 
            this.mecanicListBox.FormattingEnabled = true;
            this.mecanicListBox.Location = new System.Drawing.Point(6, 29);
            this.mecanicListBox.Name = "mecanicListBox";
            this.mecanicListBox.Size = new System.Drawing.Size(205, 124);
            this.mecanicListBox.TabIndex = 2;
            // 
            // groupAvailableMecanic
            // 
            this.groupAvailableMecanic.Controls.Add(this.mecanicListBox);
            this.groupAvailableMecanic.Location = new System.Drawing.Point(251, 12);
            this.groupAvailableMecanic.Name = "groupAvailableMecanic";
            this.groupAvailableMecanic.Size = new System.Drawing.Size(217, 166);
            this.groupAvailableMecanic.TabIndex = 3;
            this.groupAvailableMecanic.TabStop = false;
            this.groupAvailableMecanic.Text = "Selectati mecanici disponibili";
            // 
            // addComandaButton
            // 
            this.addComandaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addComandaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addComandaButton.Location = new System.Drawing.Point(15, 421);
            this.addComandaButton.Name = "addComandaButton";
            this.addComandaButton.Size = new System.Drawing.Size(450, 23);
            this.addComandaButton.TabIndex = 5;
            this.addComandaButton.Text = "Complete the new order";
            this.addComandaButton.UseVisualStyleBackColor = false;
            this.addComandaButton.Click += new System.EventHandler(this.addComandaButton_Click);
            // 
            // NewOperatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 456);
            this.Controls.Add(this.addComandaButton);
            this.Controls.Add(this.groupAvailableMecanic);
            this.Controls.Add(this.groupOperatii);
            this.Controls.Add(this.groupOperatie);
            this.Name = "NewOperatieForm";
            this.Text = "ServiceAuto - New Operatie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhenFormClosing);
            this.groupOperatie.ResumeLayout(false);
            this.groupOperatie.PerformLayout();
            this.groupOperatii.ResumeLayout(false);
            this.groupAvailableMecanic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOperatie;
        private System.Windows.Forms.Button addOperatieButton;
        private System.Windows.Forms.Label addOperatieLabel;
        private System.Windows.Forms.TextBox addOperatieTextBox;
        private System.Windows.Forms.GroupBox groupOperatii;
        private System.Windows.Forms.CheckedListBox mecanicListBox;
        private System.Windows.Forms.GroupBox groupAvailableMecanic;
        private System.Windows.Forms.Button addComandaButton;
        private TextBox timpExecutieTextBox;
        private Label timpExecutieLabel;
        private ListBox operatiiListView;
    }
}