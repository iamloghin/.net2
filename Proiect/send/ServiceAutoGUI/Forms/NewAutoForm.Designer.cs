using System;
using System.Windows.Forms;

namespace ServiceAutoGUI.Forms
{
    partial class NewAutoForm
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
            this.serieSasiuTextRight = new System.Windows.Forms.TextBox();
            this.serieSasiuTextMiddle = new System.Windows.Forms.TextBox();
            this.serieSasiuLabel = new System.Windows.Forms.Label();
            this.serieSasiuTextLeft = new System.Windows.Forms.TextBox();
            this.groupSasiu = new System.Windows.Forms.GroupBox();
            this.denumireSasiuTextBox = new System.Windows.Forms.TextBox();
            this.denumireSasiuLabel = new System.Windows.Forms.Label();
            this.codSasiuTextBox = new System.Windows.Forms.TextBox();
            this.codSasiuLabel = new System.Windows.Forms.Label();
            this.numarAutoLabel = new System.Windows.Forms.Label();
            this.numarAutoTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.addAutoButton = new System.Windows.Forms.Button();
            this.groupClientInfo.SuspendLayout();
            this.groupSasiu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupClientInfo
            // 
            this.groupClientInfo.Controls.Add(this.serieSasiuTextRight);
            this.groupClientInfo.Controls.Add(this.serieSasiuTextMiddle);
            this.groupClientInfo.Controls.Add(this.serieSasiuLabel);
            this.groupClientInfo.Controls.Add(this.serieSasiuTextLeft);
            this.groupClientInfo.Controls.Add(this.groupSasiu);
            this.groupClientInfo.Controls.Add(this.numarAutoLabel);
            this.groupClientInfo.Controls.Add(this.numarAutoTextBox);
            this.groupClientInfo.Location = new System.Drawing.Point(12, 12);
            this.groupClientInfo.Name = "groupClientInfo";
            this.groupClientInfo.Size = new System.Drawing.Size(341, 179);
            this.groupClientInfo.TabIndex = 0;
            this.groupClientInfo.TabStop = false;
            this.groupClientInfo.Text = "Client Info";
            // 
            // serieSasiuTextRight
            // 
            this.serieSasiuTextRight.Location = new System.Drawing.Point(212, 145);
            this.serieSasiuTextRight.MaxLength = 17;
            this.serieSasiuTextRight.Name = "serieSasiuTextRight";
            this.serieSasiuTextRight.Size = new System.Drawing.Size(117, 20);
            this.serieSasiuTextRight.TabIndex = 10;
            this.serieSasiuTextRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serieSasiuTextMiddle
            // 
            this.serieSasiuTextMiddle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.serieSasiuTextMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serieSasiuTextMiddle.Cursor = System.Windows.Forms.Cursors.Default;
            this.serieSasiuTextMiddle.Enabled = false;
            this.serieSasiuTextMiddle.Location = new System.Drawing.Point(172, 145);
            this.serieSasiuTextMiddle.MaxLength = 2;
            this.serieSasiuTextMiddle.Name = "serieSasiuTextMiddle";
            this.serieSasiuTextMiddle.Size = new System.Drawing.Size(34, 20);
            this.serieSasiuTextMiddle.TabIndex = 0;
            this.serieSasiuTextMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serieSasiuLabel
            // 
            this.serieSasiuLabel.AutoSize = true;
            this.serieSasiuLabel.Location = new System.Drawing.Point(6, 148);
            this.serieSasiuLabel.Name = "serieSasiuLabel";
            this.serieSasiuLabel.Size = new System.Drawing.Size(31, 13);
            this.serieSasiuLabel.TabIndex = 8;
            this.serieSasiuLabel.Text = "Serie";
            // 
            // serieSasiuTextLeft
            // 
            this.serieSasiuTextLeft.Location = new System.Drawing.Point(113, 145);
            this.serieSasiuTextLeft.MaxLength = 6;
            this.serieSasiuTextLeft.Name = "serieSasiuTextLeft";
            this.serieSasiuTextLeft.Size = new System.Drawing.Size(53, 20);
            this.serieSasiuTextLeft.TabIndex = 9;
            this.serieSasiuTextLeft.Text = "\r\n";
            this.serieSasiuTextLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupSasiu
            // 
            this.groupSasiu.Controls.Add(this.denumireSasiuTextBox);
            this.groupSasiu.Controls.Add(this.denumireSasiuLabel);
            this.groupSasiu.Controls.Add(this.codSasiuTextBox);
            this.groupSasiu.Controls.Add(this.codSasiuLabel);
            this.groupSasiu.Location = new System.Drawing.Point(9, 54);
            this.groupSasiu.Name = "groupSasiu";
            this.groupSasiu.Size = new System.Drawing.Size(326, 85);
            this.groupSasiu.TabIndex = 3;
            this.groupSasiu.TabStop = false;
            this.groupSasiu.Text = "Sasiu";
            // 
            // denumireSasiuTextBox
            // 
            this.denumireSasiuTextBox.Location = new System.Drawing.Point(104, 50);
            this.denumireSasiuTextBox.MaxLength = 25;
            this.denumireSasiuTextBox.Name = "denumireSasiuTextBox";
            this.denumireSasiuTextBox.Size = new System.Drawing.Size(216, 20);
            this.denumireSasiuTextBox.TabIndex = 7;
            // 
            // denumireSasiuLabel
            // 
            this.denumireSasiuLabel.AutoSize = true;
            this.denumireSasiuLabel.Location = new System.Drawing.Point(6, 52);
            this.denumireSasiuLabel.Name = "denumireSasiuLabel";
            this.denumireSasiuLabel.Size = new System.Drawing.Size(52, 13);
            this.denumireSasiuLabel.TabIndex = 6;
            this.denumireSasiuLabel.Text = "Denumire";
            // 
            // codSasiuTextBox
            // 
            this.codSasiuTextBox.Location = new System.Drawing.Point(104, 24);
            this.codSasiuTextBox.MaxLength = 2;
            this.codSasiuTextBox.Name = "codSasiuTextBox";
            this.codSasiuTextBox.Size = new System.Drawing.Size(45, 20);
            this.codSasiuTextBox.TabIndex = 5;
            this.codSasiuTextBox.TextChanged += new System.EventHandler(this.CodSasiuTextBox_TextChanged);
            // 
            // codSasiuLabel
            // 
            this.codSasiuLabel.AutoSize = true;
            this.codSasiuLabel.Location = new System.Drawing.Point(6, 26);
            this.codSasiuLabel.Name = "codSasiuLabel";
            this.codSasiuLabel.Size = new System.Drawing.Size(26, 13);
            this.codSasiuLabel.TabIndex = 4;
            this.codSasiuLabel.Text = "Cod";
            // 
            // numarAutoLabel
            // 
            this.numarAutoLabel.AutoSize = true;
            this.numarAutoLabel.Location = new System.Drawing.Point(6, 31);
            this.numarAutoLabel.Name = "numarAutoLabel";
            this.numarAutoLabel.Size = new System.Drawing.Size(63, 13);
            this.numarAutoLabel.TabIndex = 1;
            this.numarAutoLabel.Text = "Numar Auto";
            // 
            // numarAutoTextBox
            // 
            this.numarAutoTextBox.Location = new System.Drawing.Point(113, 28);
            this.numarAutoTextBox.MaxLength = 10;
            this.numarAutoTextBox.Name = "numarAutoTextBox";
            this.numarAutoTextBox.Size = new System.Drawing.Size(144, 20);
            this.numarAutoTextBox.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(12, 221);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addAutoButton
            // 
            this.addAutoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAutoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAutoButton.Location = new System.Drawing.Point(93, 221);
            this.addAutoButton.Name = "addAutoButton";
            this.addAutoButton.Size = new System.Drawing.Size(260, 23);
            this.addAutoButton.TabIndex = 11;
            this.addAutoButton.Text = "Next Step";
            this.addAutoButton.UseVisualStyleBackColor = false;
            this.addAutoButton.Click += new System.EventHandler(this.addAutoButton_Click);
            // 
            // NewAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 256);
            this.Controls.Add(this.addAutoButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupClientInfo);
            this.Name = "NewAutoForm";
            this.Text = "ServiceAuto - New Auto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhenFormClosing);
            this.groupClientInfo.ResumeLayout(false);
            this.groupClientInfo.PerformLayout();
            this.groupSasiu.ResumeLayout(false);
            this.groupSasiu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupClientInfo;
        private System.Windows.Forms.TextBox numarAutoTextBox;
        private System.Windows.Forms.Label numarAutoLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addAutoButton;
        private System.Windows.Forms.GroupBox groupSasiu;
        private System.Windows.Forms.TextBox denumireSasiuTextBox;
        private System.Windows.Forms.Label denumireSasiuLabel;
        private System.Windows.Forms.TextBox codSasiuTextBox;
        private System.Windows.Forms.Label codSasiuLabel;
        private System.Windows.Forms.Label serieSasiuLabel;
        private System.Windows.Forms.TextBox serieSasiuTextLeft;
        private System.Windows.Forms.TextBox serieSasiuTextMiddle;
        private System.Windows.Forms.TextBox serieSasiuTextRight;
    }
}