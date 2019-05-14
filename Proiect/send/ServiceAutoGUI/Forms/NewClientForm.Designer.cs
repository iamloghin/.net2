using System.Windows.Forms;

namespace ServiceAutoGUI.Forms
{
    partial class NewClientForm
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
            this.groupClientInfo = new System.Windows.Forms.GroupBox();
            this.clientAdresaRichBox = new System.Windows.Forms.RichTextBox();
            this.clientEmailLabel = new System.Windows.Forms.Label();
            this.clientTelefonLabel = new System.Windows.Forms.Label();
            this.clientEmailTextBox = new System.Windows.Forms.TextBox();
            this.clientTelefonTextBox = new System.Windows.Forms.TextBox();
            this.clientJudetLabel = new System.Windows.Forms.Label();
            this.clientJudetTextBox = new System.Windows.Forms.TextBox();
            this.clientLocalitateLabel = new System.Windows.Forms.Label();
            this.clientLocalitateTextBox = new System.Windows.Forms.TextBox();
            this.clientAdresaLabel = new System.Windows.Forms.Label();
            this.clientPrenumeLabel = new System.Windows.Forms.Label();
            this.clientPrenumeTextBox = new System.Windows.Forms.TextBox();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.groupClientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupClientInfo
            // 
            this.groupClientInfo.Controls.Add(this.clientAdresaRichBox);
            this.groupClientInfo.Controls.Add(this.clientEmailLabel);
            this.groupClientInfo.Controls.Add(this.clientTelefonLabel);
            this.groupClientInfo.Controls.Add(this.clientEmailTextBox);
            this.groupClientInfo.Controls.Add(this.clientTelefonTextBox);
            this.groupClientInfo.Controls.Add(this.clientJudetLabel);
            this.groupClientInfo.Controls.Add(this.clientJudetTextBox);
            this.groupClientInfo.Controls.Add(this.clientLocalitateLabel);
            this.groupClientInfo.Controls.Add(this.clientLocalitateTextBox);
            this.groupClientInfo.Controls.Add(this.clientAdresaLabel);
            this.groupClientInfo.Controls.Add(this.clientPrenumeLabel);
            this.groupClientInfo.Controls.Add(this.clientPrenumeTextBox);
            this.groupClientInfo.Controls.Add(this.clientNameLabel);
            this.groupClientInfo.Controls.Add(this.clientNameTextBox);
            this.groupClientInfo.Location = new System.Drawing.Point(12, 12);
            this.groupClientInfo.Name = "groupClientInfo";
            this.groupClientInfo.Size = new System.Drawing.Size(269, 245);
            this.groupClientInfo.TabIndex = 0;
            this.groupClientInfo.TabStop = false;
            this.groupClientInfo.Text = "Client Info";
            // 
            // clientAdresaRichBox
            // 
            this.clientAdresaRichBox.Location = new System.Drawing.Point(113, 81);
            this.clientAdresaRichBox.MaxLength = 50;
            this.clientAdresaRichBox.Name = "clientAdresaRichBox";
            this.clientAdresaRichBox.Size = new System.Drawing.Size(144, 45);
            this.clientAdresaRichBox.TabIndex = 4;
            this.clientAdresaRichBox.Text = "";
            // 
            // clientEmailLabel
            // 
            this.clientEmailLabel.AutoSize = true;
            this.clientEmailLabel.Location = new System.Drawing.Point(6, 213);
            this.clientEmailLabel.Name = "clientEmailLabel";
            this.clientEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.clientEmailLabel.TabIndex = 13;
            this.clientEmailLabel.Text = "Email";
            // 
            // clientTelefonLabel
            // 
            this.clientTelefonLabel.AutoSize = true;
            this.clientTelefonLabel.Location = new System.Drawing.Point(6, 187);
            this.clientTelefonLabel.Name = "clientTelefonLabel";
            this.clientTelefonLabel.Size = new System.Drawing.Size(43, 13);
            this.clientTelefonLabel.TabIndex = 11;
            this.clientTelefonLabel.Text = "Telefon";
            // 
            // clientEmailTextBox
            // 
            this.clientEmailTextBox.Location = new System.Drawing.Point(113, 210);
            this.clientEmailTextBox.MaxLength = 50;
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.Size = new System.Drawing.Size(144, 20);
            this.clientEmailTextBox.TabIndex = 12;
            // 
            // clientTelefonTextBox
            // 
            this.clientTelefonTextBox.Location = new System.Drawing.Point(113, 184);
            this.clientTelefonTextBox.MaxLength = 13;
            this.clientTelefonTextBox.Name = "clientTelefonTextBox";
            this.clientTelefonTextBox.Size = new System.Drawing.Size(144, 20);
            this.clientTelefonTextBox.TabIndex = 10;
            // 
            // clientJudetLabel
            // 
            this.clientJudetLabel.AutoSize = true;
            this.clientJudetLabel.Location = new System.Drawing.Point(6, 161);
            this.clientJudetLabel.Name = "clientJudetLabel";
            this.clientJudetLabel.Size = new System.Drawing.Size(33, 13);
            this.clientJudetLabel.TabIndex = 9;
            this.clientJudetLabel.Text = "Judet";
            // 
            // clientJudetTextBox
            // 
            this.clientJudetTextBox.Location = new System.Drawing.Point(113, 158);
            this.clientJudetTextBox.MaxLength = 10;
            this.clientJudetTextBox.Name = "clientJudetTextBox";
            this.clientJudetTextBox.Size = new System.Drawing.Size(144, 20);
            this.clientJudetTextBox.TabIndex = 8;
            // 
            // clientLocalitateLabel
            // 
            this.clientLocalitateLabel.AutoSize = true;
            this.clientLocalitateLabel.Location = new System.Drawing.Point(6, 135);
            this.clientLocalitateLabel.Name = "clientLocalitateLabel";
            this.clientLocalitateLabel.Size = new System.Drawing.Size(53, 13);
            this.clientLocalitateLabel.TabIndex = 7;
            this.clientLocalitateLabel.Text = "Localitate";
            // 
            // clientLocalitateTextBox
            // 
            this.clientLocalitateTextBox.Location = new System.Drawing.Point(113, 132);
            this.clientLocalitateTextBox.MaxLength = 20;
            this.clientLocalitateTextBox.Name = "clientLocalitateTextBox";
            this.clientLocalitateTextBox.Size = new System.Drawing.Size(144, 20);
            this.clientLocalitateTextBox.TabIndex = 6;
            // 
            // clientAdresaLabel
            // 
            this.clientAdresaLabel.AutoSize = true;
            this.clientAdresaLabel.Location = new System.Drawing.Point(6, 83);
            this.clientAdresaLabel.Name = "clientAdresaLabel";
            this.clientAdresaLabel.Size = new System.Drawing.Size(40, 13);
            this.clientAdresaLabel.TabIndex = 5;
            this.clientAdresaLabel.Text = "Adresa";
            // 
            // clientPrenumeLabel
            // 
            this.clientPrenumeLabel.AutoSize = true;
            this.clientPrenumeLabel.Location = new System.Drawing.Point(6, 57);
            this.clientPrenumeLabel.Name = "clientPrenumeLabel";
            this.clientPrenumeLabel.Size = new System.Drawing.Size(49, 13);
            this.clientPrenumeLabel.TabIndex = 3;
            this.clientPrenumeLabel.Text = "Prenume";
            // 
            // clientPrenumeTextBox
            // 
            this.clientPrenumeTextBox.Location = new System.Drawing.Point(113, 54);
            this.clientPrenumeTextBox.MaxLength = 15;
            this.clientPrenumeTextBox.Name = "clientPrenumeTextBox";
            this.clientPrenumeTextBox.Size = new System.Drawing.Size(144, 20);
            this.clientPrenumeTextBox.TabIndex = 2;
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(6, 31);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(35, 13);
            this.clientNameLabel.TabIndex = 1;
            this.clientNameLabel.Text = "Nume";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(113, 28);
            this.clientNameTextBox.MaxLength = 15;
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.clientNameTextBox.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(12, 289);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientButton.Location = new System.Drawing.Point(93, 289);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(188, 23);
            this.addClientButton.TabIndex = 14;
            this.addClientButton.Text = "Next Step";
            this.addClientButton.UseVisualStyleBackColor = false;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // NewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 332);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupClientInfo);
            this.Name = "NewClientForm";
            this.Text = "ServiceAuto - New Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhenFormClosing);
            this.groupClientInfo.ResumeLayout(false);
            this.groupClientInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupClientInfo;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.RichTextBox clientAdresaRichBox;
        private System.Windows.Forms.Label clientEmailLabel;
        private System.Windows.Forms.Label clientTelefonLabel;
        private System.Windows.Forms.TextBox clientEmailTextBox;
        private System.Windows.Forms.TextBox clientTelefonTextBox;
        private System.Windows.Forms.Label clientJudetLabel;
        private System.Windows.Forms.TextBox clientJudetTextBox;
        private System.Windows.Forms.Label clientLocalitateLabel;
        private System.Windows.Forms.TextBox clientLocalitateTextBox;
        private System.Windows.Forms.Label clientAdresaLabel;
        private System.Windows.Forms.Label clientPrenumeLabel;
        private System.Windows.Forms.TextBox clientPrenumeTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addClientButton;
    }
}