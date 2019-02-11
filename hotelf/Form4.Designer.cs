namespace hotelf
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnsfre = new System.Windows.Forms.Button();
            this.btnkyt = new System.Windows.Forms.Button();
            this.btngrs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(240, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(240, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "benihtrla";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnsfre
            // 
            this.btnsfre.Location = new System.Drawing.Point(240, 215);
            this.btnsfre.Name = "btnsfre";
            this.btnsfre.Size = new System.Drawing.Size(75, 23);
            this.btnsfre.TabIndex = 4;
            this.btnsfre.Text = "sifre";
            this.btnsfre.UseVisualStyleBackColor = true;
            this.btnsfre.Click += new System.EventHandler(this.btnsfre_Click);
            // 
            // btnkyt
            // 
            this.btnkyt.Location = new System.Drawing.Point(240, 244);
            this.btnkyt.Name = "btnkyt";
            this.btnkyt.Size = new System.Drawing.Size(75, 23);
            this.btnkyt.TabIndex = 5;
            this.btnkyt.Text = "kayit";
            this.btnkyt.UseVisualStyleBackColor = true;
            this.btnkyt.Click += new System.EventHandler(this.btnkyt_Click);
            // 
            // btngrs
            // 
            this.btngrs.Location = new System.Drawing.Point(355, 191);
            this.btngrs.Name = "btngrs";
            this.btngrs.Size = new System.Drawing.Size(75, 23);
            this.btngrs.TabIndex = 6;
            this.btngrs.Text = "btngrs";
            this.btngrs.UseVisualStyleBackColor = true;
            this.btngrs.Click += new System.EventHandler(this.btngrs_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngrs);
            this.Controls.Add(this.btnkyt);
            this.Controls.Add(this.btnsfre);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnsfre;
        private System.Windows.Forms.Button btnkyt;
        private System.Windows.Forms.Button btngrs;
    }
}