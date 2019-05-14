using System.Windows.Forms;

namespace ServiceAutoGUI.Forms
{
    partial class ClientForm
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
            this.addAutoButton = new System.Windows.Forms.Button();
            this.groupAuto = new System.Windows.Forms.GroupBox();
            this.newAutoButton = new System.Windows.Forms.Button();
            this.autoListBox = new System.Windows.Forms.ListBox();
            this.editClientButton = new System.Windows.Forms.Button();
            this.saveChangeButton = new System.Windows.Forms.Button();
            this.groupClientInfo.SuspendLayout();
            this.groupAuto.SuspendLayout();
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
            this.groupClientInfo.Location = new System.Drawing.Point(12, 38);
            this.groupClientInfo.Name = "groupClientInfo";
            this.groupClientInfo.Size = new System.Drawing.Size(269, 245);
            this.groupClientInfo.TabIndex = 0;
            this.groupClientInfo.TabStop = false;
            this.groupClientInfo.Text = "Client Info";
            // 
            // clientAdresaRichBox
            // 
            this.clientAdresaRichBox.Enabled = false;
            this.clientAdresaRichBox.Location = new System.Drawing.Point(113, 81);
            this.clientAdresaRichBox.Name = "clientAdresaRichBox";
            this.clientAdresaRichBox.Size = new System.Drawing.Size(144, 45);
            this.clientAdresaRichBox.TabIndex = 12;
            this.clientAdresaRichBox.Text = "";
            // 
            // clientEmailLabel
            // 
            this.clientEmailLabel.AutoSize = true;
            this.clientEmailLabel.Location = new System.Drawing.Point(6, 213);
            this.clientEmailLabel.Name = "clientEmailLabel";
            this.clientEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.clientEmailLabel.TabIndex = 11;
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
            this.clientEmailTextBox.Enabled = false;
            this.clientEmailTextBox.Location = new System.Drawing.Point(113, 210);
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.Size = new System.Drawing.Size(144, 20);
            this.clientEmailTextBox.TabIndex = 10;
            // 
            // clientTelefonTextBox
            // 
            this.clientTelefonTextBox.Enabled = false;
            this.clientTelefonTextBox.Location = new System.Drawing.Point(113, 184);
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
            this.clientJudetTextBox.Enabled = false;
            this.clientJudetTextBox.Location = new System.Drawing.Point(113, 158);
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
            this.clientLocalitateTextBox.Enabled = false;
            this.clientLocalitateTextBox.Location = new System.Drawing.Point(113, 132);
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
            this.clientPrenumeTextBox.Enabled = false;
            this.clientPrenumeTextBox.Location = new System.Drawing.Point(113, 54);
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
            this.clientNameTextBox.Enabled = false;
            this.clientNameTextBox.Location = new System.Drawing.Point(113, 28);
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
            this.backButton.Size = new System.Drawing.Size(116, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addAutoButton
            // 
            this.addAutoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAutoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAutoButton.Location = new System.Drawing.Point(134, 289);
            this.addAutoButton.Name = "addAutoButton";
            this.addAutoButton.Size = new System.Drawing.Size(389, 23);
            this.addAutoButton.TabIndex = 2;
            this.addAutoButton.Text = "Next Step";
            this.addAutoButton.UseVisualStyleBackColor = false;
            this.addAutoButton.Click += new System.EventHandler(this.addAutoButton_Click);
            // 
            // groupAuto
            // 
            this.groupAuto.Controls.Add(this.newAutoButton);
            this.groupAuto.Controls.Add(this.autoListBox);
            this.groupAuto.Location = new System.Drawing.Point(287, 12);
            this.groupAuto.Name = "groupAuto";
            this.groupAuto.Size = new System.Drawing.Size(243, 271);
            this.groupAuto.TabIndex = 3;
            this.groupAuto.TabStop = false;
            this.groupAuto.Text = "Auto";
            // 
            // newAutoButton
            // 
            this.newAutoButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.newAutoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAutoButton.Location = new System.Drawing.Point(7, 234);
            this.newAutoButton.Name = "newAutoButton";
            this.newAutoButton.Size = new System.Drawing.Size(230, 23);
            this.newAutoButton.TabIndex = 3;
            this.newAutoButton.Text = "Add new auto";
            this.newAutoButton.UseVisualStyleBackColor = false;
            this.newAutoButton.Click += new System.EventHandler(this.newAutoButton_Click);
            // 
            // autoListBox
            // 
            this.autoListBox.FormattingEnabled = true;
            this.autoListBox.Location = new System.Drawing.Point(6, 28);
            this.autoListBox.Name = "autoListBox";
            this.autoListBox.Size = new System.Drawing.Size(230, 199);
            this.autoListBox.TabIndex = 0;
            // 
            // editClientButton
            // 
            this.editClientButton.BackColor = System.Drawing.SystemColors.Control;
            this.editClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editClientButton.Location = new System.Drawing.Point(12, 12);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(156, 23);
            this.editClientButton.TabIndex = 4;
            this.editClientButton.Text = "Edit Client";
            this.editClientButton.UseVisualStyleBackColor = false;
            this.editClientButton.Click += new System.EventHandler(this.editClientButton_Click);
            // 
            // saveChangeButton
            // 
            this.saveChangeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveChangeButton.Enabled = false;
            this.saveChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangeButton.Location = new System.Drawing.Point(174, 12);
            this.saveChangeButton.Name = "saveChangeButton";
            this.saveChangeButton.Size = new System.Drawing.Size(107, 23);
            this.saveChangeButton.TabIndex = 5;
            this.saveChangeButton.Text = "Save Change";
            this.saveChangeButton.UseVisualStyleBackColor = false;
            this.saveChangeButton.Click += new System.EventHandler(this.saveChangeButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 327);
            this.Controls.Add(this.saveChangeButton);
            this.Controls.Add(this.editClientButton);
            this.Controls.Add(this.groupAuto);
            this.Controls.Add(this.addAutoButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupClientInfo);
            this.Name = "ClientForm";
            this.Text = "ServiceAuto - Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhenFormClosing);
            this.groupClientInfo.ResumeLayout(false);
            this.groupClientInfo.PerformLayout();
            this.groupAuto.ResumeLayout(false);
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
        private System.Windows.Forms.Button addAutoButton;
        private System.Windows.Forms.GroupBox groupAuto;
        private System.Windows.Forms.Button newAutoButton;
        private System.Windows.Forms.ListBox autoListBox;
        private Button editClientButton;
        private Button saveChangeButton;
    }
}