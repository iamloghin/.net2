namespace ClientPostComment
{
    partial class Form1
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
            this.dgp = new System.Windows.Forms.DataGridView();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.PostsLabel = new System.Windows.Forms.Label();
            this.dgc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgp
            // 
            this.dgp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgp.Location = new System.Drawing.Point(603, 54);
            this.dgp.Name = "dgp";
            this.dgp.Size = new System.Drawing.Size(310, 383);
            this.dgp.TabIndex = 0;
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Location = new System.Drawing.Point(600, 25);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(56, 13);
            this.CommentsLabel.TabIndex = 1;
            this.CommentsLabel.Text = "Comments";
            // 
            // PostsLabel
            // 
            this.PostsLabel.AutoSize = true;
            this.PostsLabel.Location = new System.Drawing.Point(12, 25);
            this.PostsLabel.Name = "PostsLabel";
            this.PostsLabel.Size = new System.Drawing.Size(33, 13);
            this.PostsLabel.TabIndex = 2;
            this.PostsLabel.Text = "Posts";
            // 
            // dgc
            // 
            this.dgc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgc.Location = new System.Drawing.Point(12, 55);
            this.dgc.Name = "dgc";
            this.dgc.Size = new System.Drawing.Size(528, 383);
            this.dgc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.dgc);
            this.Controls.Add(this.PostsLabel);
            this.Controls.Add(this.CommentsLabel);
            this.Controls.Add(this.dgp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgp;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.Label PostsLabel;
        private System.Windows.Forms.DataGridView dgc;
    }
}

