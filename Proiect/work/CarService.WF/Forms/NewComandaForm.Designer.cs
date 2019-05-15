using System.Windows.Forms;

namespace CarService.WF.Forms
{
    partial class NewComandaForm
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
            this.groupComandaInfo = new System.Windows.Forms.GroupBox();
            this.kmBoardTextBox = new System.Windows.Forms.TextBox();
            this.kmBoardLabel = new System.Windows.Forms.Label();
            this.serviceAutoCheckBox = new System.Windows.Forms.CheckBox();
            this.descriereComandaBox = new System.Windows.Forms.RichTextBox();
            this.dataProgramareDatePicker = new System.Windows.Forms.DateTimePicker();
            this.descriereLabel = new System.Windows.Forms.Label();
            this.groupDetaliuComanda = new System.Windows.Forms.GroupBox();
            this.uploadImageButton = new System.Windows.Forms.Button();
            this.descriereImagineLabel = new System.Windows.Forms.Label();
            this.titluImagineLabel = new System.Windows.Forms.Label();
            this.descriereImagineRichBox = new System.Windows.Forms.RichTextBox();
            this.titluImagineTextBox = new System.Windows.Forms.TextBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.dataProgramareLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.addImageList = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.newComandaButton = new System.Windows.Forms.Button();
            this.addOperatiiButton = new System.Windows.Forms.Button();
            this.groupComandaInfo.SuspendLayout();
            this.groupDetaliuComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupComandaInfo
            // 
            this.groupComandaInfo.Controls.Add(this.kmBoardTextBox);
            this.groupComandaInfo.Controls.Add(this.kmBoardLabel);
            this.groupComandaInfo.Controls.Add(this.serviceAutoCheckBox);
            this.groupComandaInfo.Controls.Add(this.descriereComandaBox);
            this.groupComandaInfo.Controls.Add(this.dataProgramareDatePicker);
            this.groupComandaInfo.Controls.Add(this.descriereLabel);
            this.groupComandaInfo.Controls.Add(this.groupDetaliuComanda);
            this.groupComandaInfo.Controls.Add(this.dataProgramareLabel);
            this.groupComandaInfo.Location = new System.Drawing.Point(6, 12);
            this.groupComandaInfo.Name = "groupComandaInfo";
            this.groupComandaInfo.Size = new System.Drawing.Size(341, 449);
            this.groupComandaInfo.TabIndex = 0;
            this.groupComandaInfo.TabStop = false;
            this.groupComandaInfo.Text = "Comanda Info";
            // 
            // kmBoardTextBox
            // 
            this.kmBoardTextBox.Location = new System.Drawing.Point(206, 415);
            this.kmBoardTextBox.Name = "kmBoardTextBox";
            this.kmBoardTextBox.Size = new System.Drawing.Size(117, 20);
            this.kmBoardTextBox.TabIndex = 9;
            // 
            // kmBoardLabel
            // 
            this.kmBoardLabel.AutoSize = true;
            this.kmBoardLabel.Location = new System.Drawing.Point(150, 418);
            this.kmBoardLabel.Name = "kmBoardLabel";
            this.kmBoardLabel.Size = new System.Drawing.Size(50, 13);
            this.kmBoardLabel.TabIndex = 8;
            this.kmBoardLabel.Text = "KmBoard";
            // 
            // serviceAutoCheckBox
            // 
            this.serviceAutoCheckBox.AutoSize = true;
            this.serviceAutoCheckBox.Location = new System.Drawing.Point(15, 415);
            this.serviceAutoCheckBox.Name = "serviceAutoCheckBox";
            this.serviceAutoCheckBox.Size = new System.Drawing.Size(95, 17);
            this.serviceAutoCheckBox.TabIndex = 7;
            this.serviceAutoCheckBox.Text = "Stay in service";
            this.serviceAutoCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriereComandaBox
            // 
            this.descriereComandaBox.Location = new System.Drawing.Point(81, 248);
            this.descriereComandaBox.Name = "descriereComandaBox";
            this.descriereComandaBox.Size = new System.Drawing.Size(242, 156);
            this.descriereComandaBox.TabIndex = 6;
            this.descriereComandaBox.Text = "";
            // 
            // dataProgramareDatePicker
            // 
            this.dataProgramareDatePicker.Location = new System.Drawing.Point(123, 28);
            this.dataProgramareDatePicker.Name = "dataProgramareDatePicker";
            this.dataProgramareDatePicker.Size = new System.Drawing.Size(200, 20);
            this.dataProgramareDatePicker.TabIndex = 5;
            // 
            // descriereLabel
            // 
            this.descriereLabel.AutoSize = true;
            this.descriereLabel.Location = new System.Drawing.Point(12, 251);
            this.descriereLabel.Name = "descriereLabel";
            this.descriereLabel.Size = new System.Drawing.Size(52, 13);
            this.descriereLabel.TabIndex = 4;
            this.descriereLabel.Text = "Descriere";
            // 
            // groupDetaliuComanda
            // 
            this.groupDetaliuComanda.Controls.Add(this.uploadImageButton);
            this.groupDetaliuComanda.Controls.Add(this.descriereImagineLabel);
            this.groupDetaliuComanda.Controls.Add(this.titluImagineLabel);
            this.groupDetaliuComanda.Controls.Add(this.descriereImagineRichBox);
            this.groupDetaliuComanda.Controls.Add(this.titluImagineTextBox);
            this.groupDetaliuComanda.Controls.Add(this.selectImageButton);
            this.groupDetaliuComanda.Location = new System.Drawing.Point(9, 54);
            this.groupDetaliuComanda.Name = "groupDetaliuComanda";
            this.groupDetaliuComanda.Size = new System.Drawing.Size(314, 188);
            this.groupDetaliuComanda.TabIndex = 2;
            this.groupDetaliuComanda.TabStop = false;
            this.groupDetaliuComanda.Text = "Detaliu";
            // 
            // uploadImageButton
            // 
            this.uploadImageButton.Location = new System.Drawing.Point(6, 159);
            this.uploadImageButton.Name = "uploadImageButton";
            this.uploadImageButton.Size = new System.Drawing.Size(302, 21);
            this.uploadImageButton.TabIndex = 14;
            this.uploadImageButton.Text = "Upload Image";
            this.uploadImageButton.UseVisualStyleBackColor = true;
            this.uploadImageButton.Click += new System.EventHandler(this.uploadImageButton_Click_1);
            // 
            // descriereImagineLabel
            // 
            this.descriereImagineLabel.AutoSize = true;
            this.descriereImagineLabel.Location = new System.Drawing.Point(9, 101);
            this.descriereImagineLabel.Name = "descriereImagineLabel";
            this.descriereImagineLabel.Size = new System.Drawing.Size(52, 13);
            this.descriereImagineLabel.TabIndex = 13;
            this.descriereImagineLabel.Text = "Descriere";
            // 
            // titluImagineLabel
            // 
            this.titluImagineLabel.AutoSize = true;
            this.titluImagineLabel.Location = new System.Drawing.Point(9, 54);
            this.titluImagineLabel.Name = "titluImagineLabel";
            this.titluImagineLabel.Size = new System.Drawing.Size(27, 13);
            this.titluImagineLabel.TabIndex = 12;
            this.titluImagineLabel.Text = "Titlu";
            // 
            // descriereImagineRichBox
            // 
            this.descriereImagineRichBox.Location = new System.Drawing.Point(114, 73);
            this.descriereImagineRichBox.Name = "descriereImagineRichBox";
            this.descriereImagineRichBox.Size = new System.Drawing.Size(194, 80);
            this.descriereImagineRichBox.TabIndex = 11;
            this.descriereImagineRichBox.Text = "";
            // 
            // titluImagineTextBox
            // 
            this.titluImagineTextBox.Location = new System.Drawing.Point(114, 47);
            this.titluImagineTextBox.Name = "titluImagineTextBox";
            this.titluImagineTextBox.Size = new System.Drawing.Size(194, 20);
            this.titluImagineTextBox.TabIndex = 10;
            // 
            // selectImageButton
            // 
            this.selectImageButton.Location = new System.Drawing.Point(6, 19);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(302, 21);
            this.selectImageButton.TabIndex = 9;
            this.selectImageButton.Text = "Select Image";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.uploadImageButton_Click);
            // 
            // dataProgramareLabel
            // 
            this.dataProgramareLabel.AutoSize = true;
            this.dataProgramareLabel.Location = new System.Drawing.Point(6, 31);
            this.dataProgramareLabel.Name = "dataProgramareLabel";
            this.dataProgramareLabel.Size = new System.Drawing.Size(90, 13);
            this.dataProgramareLabel.TabIndex = 1;
            this.dataProgramareLabel.Text = "Data Programare ";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(353, 201);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(260, 260);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // addImageList
            // 
            this.addImageList.FormattingEnabled = true;
            this.addImageList.Location = new System.Drawing.Point(353, 9);
            this.addImageList.Name = "addImageList";
            this.addImageList.Size = new System.Drawing.Size(257, 186);
            this.addImageList.TabIndex = 10;
            this.addImageList.SelectedIndexChanged += new System.EventHandler(this.addImageList_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(6, 467);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // newComandaButton
            // 
            this.newComandaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newComandaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newComandaButton.Location = new System.Drawing.Point(203, 467);
            this.newComandaButton.Name = "newComandaButton";
            this.newComandaButton.Size = new System.Drawing.Size(144, 23);
            this.newComandaButton.TabIndex = 2;
            this.newComandaButton.Text = "Complete the new order";
            this.newComandaButton.UseVisualStyleBackColor = false;
            this.newComandaButton.Click += new System.EventHandler(this.newComandaButton_Click);
            // 
            // addOperatiiButton
            // 
            this.addOperatiiButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addOperatiiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOperatiiButton.Location = new System.Drawing.Point(87, 467);
            this.addOperatiiButton.Name = "addOperatiiButton";
            this.addOperatiiButton.Size = new System.Drawing.Size(110, 23);
            this.addOperatiiButton.TabIndex = 3;
            this.addOperatiiButton.Text = "Add Operatii";
            this.addOperatiiButton.UseVisualStyleBackColor = false;
            this.addOperatiiButton.Click += new System.EventHandler(this.addOperatiiButton_Click);
            // 
            // NewComandaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 499);
            this.Controls.Add(this.addImageList);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.addOperatiiButton);
            this.Controls.Add(this.newComandaButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupComandaInfo);
            this.Name = "NewComandaForm";
            this.Text = "ServiceAuto - New Comanda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhenFormClosing);
            this.groupComandaInfo.ResumeLayout(false);
            this.groupComandaInfo.PerformLayout();
            this.groupDetaliuComanda.ResumeLayout(false);
            this.groupDetaliuComanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupComandaInfo;
        private System.Windows.Forms.Label dataProgramareLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button newComandaButton;
        private System.Windows.Forms.GroupBox groupDetaliuComanda;
        private System.Windows.Forms.Label descriereLabel;
        private System.Windows.Forms.DateTimePicker dataProgramareDatePicker;
        private System.Windows.Forms.RichTextBox descriereComandaBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.TextBox kmBoardTextBox;
        private System.Windows.Forms.Label kmBoardLabel;
        private System.Windows.Forms.CheckBox serviceAutoCheckBox;
        private System.Windows.Forms.ListBox addImageList;
        private Button addOperatiiButton;
        private PictureBox pictureBox;
        private Button uploadImageButton;
        private Label descriereImagineLabel;
        private Label titluImagineLabel;
        private RichTextBox descriereImagineRichBox;
        private TextBox titluImagineTextBox;
    }
}