namespace hotelf
{
    partial class kayit5
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
            this.txad = new System.Windows.Forms.TextBox();
            this.txsoyad = new System.Windows.Forms.TextBox();
            this.txkullaniciadi = new System.Windows.Forms.TextBox();
            this.txsfre = new System.Windows.Forms.TextBox();
            this.txtel = new System.Windows.Forms.TextBox();
            this.txmail = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txkytol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txad
            // 
            this.txad.Location = new System.Drawing.Point(337, 49);
            this.txad.Name = "txad";
            this.txad.Size = new System.Drawing.Size(100, 20);
            this.txad.TabIndex = 0;
            // 
            // txsoyad
            // 
            this.txsoyad.Location = new System.Drawing.Point(337, 86);
            this.txsoyad.Name = "txsoyad";
            this.txsoyad.Size = new System.Drawing.Size(100, 20);
            this.txsoyad.TabIndex = 1;
            // 
            // txkullaniciadi
            // 
            this.txkullaniciadi.Location = new System.Drawing.Point(337, 122);
            this.txkullaniciadi.Name = "txkullaniciadi";
            this.txkullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txkullaniciadi.TabIndex = 2;
            // 
            // txsfre
            // 
            this.txsfre.Location = new System.Drawing.Point(337, 159);
            this.txsfre.Name = "txsfre";
            this.txsfre.Size = new System.Drawing.Size(100, 20);
            this.txsfre.TabIndex = 3;
            // 
            // txtel
            // 
            this.txtel.Location = new System.Drawing.Point(337, 195);
            this.txtel.Name = "txtel";
            this.txtel.Size = new System.Drawing.Size(100, 20);
            this.txtel.TabIndex = 4;
            // 
            // txmail
            // 
            this.txmail.Location = new System.Drawing.Point(337, 221);
            this.txmail.Name = "txmail";
            this.txmail.Size = new System.Drawing.Size(100, 20);
            this.txmail.TabIndex = 5;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(337, 247);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 6;
            // 
            // txkytol
            // 
            this.txkytol.Location = new System.Drawing.Point(350, 273);
            this.txkytol.Name = "txkytol";
            this.txkytol.Size = new System.Drawing.Size(75, 23);
            this.txkytol.TabIndex = 7;
            this.txkytol.Text = "kayıtol";
            this.txkytol.UseVisualStyleBackColor = true;
            this.txkytol.Click += new System.EventHandler(this.txkytol_Click);
            // 
            // kayit5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 320);
            this.Controls.Add(this.txkytol);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txmail);
            this.Controls.Add(this.txtel);
            this.Controls.Add(this.txsfre);
            this.Controls.Add(this.txkullaniciadi);
            this.Controls.Add(this.txsoyad);
            this.Controls.Add(this.txad);
            this.Name = "kayit5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.kayit5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txad;
        private System.Windows.Forms.TextBox txsoyad;
        private System.Windows.Forms.TextBox txkullaniciadi;
        private System.Windows.Forms.TextBox txsfre;
        private System.Windows.Forms.TextBox txtel;
        private System.Windows.Forms.TextBox txmail;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Button txkytol;
    }
}