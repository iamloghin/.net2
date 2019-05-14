namespace CarService.WF.Forms
{
    partial class ManagerForm
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
            this.openMecanicViewButton = new System.Windows.Forms.Button();
            this.openOperatiiViewButton = new System.Windows.Forms.Button();
            this.openMaterialViewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openMecanicViewButton
            // 
            this.openMecanicViewButton.Location = new System.Drawing.Point(124, 223);
            this.openMecanicViewButton.Name = "openMecanicViewButton";
            this.openMecanicViewButton.Size = new System.Drawing.Size(112, 23);
            this.openMecanicViewButton.TabIndex = 1;
            this.openMecanicViewButton.Text = "Mecanic View";
            this.openMecanicViewButton.UseVisualStyleBackColor = true;
            this.openMecanicViewButton.Click += new System.EventHandler(this.openMecanicViewButton_Click);
            // 
            // openOperatiiViewButton
            // 
            this.openOperatiiViewButton.Location = new System.Drawing.Point(124, 264);
            this.openOperatiiViewButton.Name = "openOperatiiViewButton";
            this.openOperatiiViewButton.Size = new System.Drawing.Size(112, 23);
            this.openOperatiiViewButton.TabIndex = 2;
            this.openOperatiiViewButton.Text = "Operatie View";
            this.openOperatiiViewButton.UseVisualStyleBackColor = true;
            this.openOperatiiViewButton.Click += new System.EventHandler(this.openOperatiiViewButton_Click);
            // 
            // openMaterialViewButton
            // 
            this.openMaterialViewButton.Location = new System.Drawing.Point(124, 303);
            this.openMaterialViewButton.Name = "openMaterialViewButton";
            this.openMaterialViewButton.Size = new System.Drawing.Size(112, 23);
            this.openMaterialViewButton.TabIndex = 3;
            this.openMaterialViewButton.Text = "Material View";
            this.openMaterialViewButton.UseVisualStyleBackColor = true;
            this.openMaterialViewButton.Click += new System.EventHandler(this.openMaterialViewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome, Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select View Mode:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(124, 347);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 23);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openMaterialViewButton);
            this.Controls.Add(this.openOperatiiViewButton);
            this.Controls.Add(this.openMecanicViewButton);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhenFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openMecanicViewButton;
        private System.Windows.Forms.Button openOperatiiViewButton;
        private System.Windows.Forms.Button openMaterialViewButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
    }
}