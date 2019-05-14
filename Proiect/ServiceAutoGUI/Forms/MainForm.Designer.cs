using System;

namespace ServiceAutoGUI.Forms
{
    partial class MainForm
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
            this.MessageWelcome = new System.Windows.Forms.Label();
            this.MessageLogo = new System.Windows.Forms.Label();
            this.seachClientButton = new System.Windows.Forms.Button();
            this.seachClientTextBox = new System.Windows.Forms.TextBox();
            this.addClientButton = new System.Windows.Forms.Button();
            this.managerButton = new System.Windows.Forms.Button();
            this.GroupWelcome = new System.Windows.Forms.Panel();
            this.GroupWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageWelcome
            // 
            this.MessageWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessageWelcome.AutoSize = true;
            this.MessageWelcome.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageWelcome.Location = new System.Drawing.Point(4, 4);
            this.MessageWelcome.Name = "MessageWelcome";
            this.MessageWelcome.Size = new System.Drawing.Size(126, 33);
            this.MessageWelcome.TabIndex = 0;
            this.MessageWelcome.Text = "Welcome to";
            // 
            // MessageLogo
            // 
            this.MessageLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessageLogo.AutoSize = true;
            this.MessageLogo.Font = new System.Drawing.Font("Cambria", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLogo.Location = new System.Drawing.Point(57, 31);
            this.MessageLogo.Name = "MessageLogo";
            this.MessageLogo.Size = new System.Drawing.Size(233, 47);
            this.MessageLogo.TabIndex = 1;
            this.MessageLogo.Text = "ServiceAuto";
            // 
            // seachClientButton
            // 
            this.seachClientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seachClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seachClientButton.Location = new System.Drawing.Point(149, 293);
            this.seachClientButton.Name = "seachClientButton";
            this.seachClientButton.Size = new System.Drawing.Size(186, 33);
            this.seachClientButton.TabIndex = 2;
            this.seachClientButton.Text = "Search for an existing client";
            this.seachClientButton.UseVisualStyleBackColor = true;
            this.seachClientButton.Click += new System.EventHandler(this.seachClientButton_Click);
            // 
            // seachClientTextBox
            // 
            this.seachClientTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seachClientTextBox.BackColor = System.Drawing.Color.White;
            this.seachClientTextBox.Location = new System.Drawing.Point(102, 244);
            this.seachClientTextBox.Name = "seachClientTextBox";
            this.seachClientTextBox.Size = new System.Drawing.Size(294, 25);
            this.seachClientTextBox.TabIndex = 1;
            this.seachClientTextBox.Text = "Search by SerieSasiu, Telefon, Email";
            this.seachClientTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seachClientTextBox.Click += new System.EventHandler(this.FirstClickEvent);
            this.seachClientTextBox.GotFocus += new System.EventHandler(this.TextBoxFocused);
            // 
            // addClientButton
            // 
            this.addClientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addClientButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientButton.Location = new System.Drawing.Point(171, 347);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(133, 33);
            this.addClientButton.TabIndex = 3;
            this.addClientButton.Text = "Add a new client";
            this.addClientButton.UseVisualStyleBackColor = false;
            this.addClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // managerButton
            // 
            this.managerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.managerButton.Location = new System.Drawing.Point(184, 403);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(105, 33);
            this.managerButton.TabIndex = 4;
            this.managerButton.Text = "Manager View";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // GroupWelcome
            // 
            this.GroupWelcome.Controls.Add(this.MessageWelcome);
            this.GroupWelcome.Controls.Add(this.MessageLogo);
            this.GroupWelcome.Location = new System.Drawing.Point(102, 40);
            this.GroupWelcome.Name = "GroupWelcome";
            this.GroupWelcome.Size = new System.Drawing.Size(294, 87);
            this.GroupWelcome.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 460);
            this.Controls.Add(this.GroupWelcome);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.seachClientTextBox);
            this.Controls.Add(this.seachClientButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ServiceAuto";
            this.GroupWelcome.ResumeLayout(false);
            this.GroupWelcome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageWelcome;
        private System.Windows.Forms.Label MessageLogo;
        private System.Windows.Forms.Button seachClientButton;
        private System.Windows.Forms.TextBox seachClientTextBox;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button managerButton;
        private System.Windows.Forms.Panel GroupWelcome;
    }
}

