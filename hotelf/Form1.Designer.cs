namespace hotelf
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txAra = new System.Windows.Forms.TextBox();
            this.butAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(358, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txAra
            // 
            this.txAra.Location = new System.Drawing.Point(295, 159);
            this.txAra.Name = "txAra";
            this.txAra.Size = new System.Drawing.Size(100, 20);
            this.txAra.TabIndex = 1;
            // 
            // butAra
            // 
            this.butAra.Location = new System.Drawing.Point(472, 155);
            this.butAra.Name = "butAra";
            this.butAra.Size = new System.Drawing.Size(75, 23);
            this.butAra.TabIndex = 2;
            this.butAra.Text = "ara";
            this.butAra.UseVisualStyleBackColor = true;
            this.butAra.Click += new System.EventHandler(this.butAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 438);
            this.Controls.Add(this.butAra);
            this.Controls.Add(this.txAra);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txAra;
        private System.Windows.Forms.Button butAra;
    }
}

