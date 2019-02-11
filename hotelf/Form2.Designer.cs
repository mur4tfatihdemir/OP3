namespace hotelf
{
    partial class Form2
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbroomtype = new System.Windows.Forms.ComboBox();
            this.txAra2 = new System.Windows.Forms.TextBox();
            this.btfind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btgrs = new System.Windows.Forms.Button();
            this.btkaydol = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(348, 137);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // cmbroomtype
            // 
            this.cmbroomtype.FormattingEnabled = true;
            this.cmbroomtype.Location = new System.Drawing.Point(590, 135);
            this.cmbroomtype.Name = "cmbroomtype";
            this.cmbroomtype.Size = new System.Drawing.Size(121, 21);
            this.cmbroomtype.TabIndex = 2;
            // 
            // txAra2
            // 
            this.txAra2.Location = new System.Drawing.Point(227, 77);
            this.txAra2.Name = "txAra2";
            this.txAra2.Size = new System.Drawing.Size(181, 20);
            this.txAra2.TabIndex = 3;
            // 
            // btfind
            // 
            this.btfind.Location = new System.Drawing.Point(457, 73);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(75, 23);
            this.btfind.TabIndex = 4;
            this.btfind.Text = "ara";
            this.btfind.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 132);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btgrs
            // 
            this.btgrs.Location = new System.Drawing.Point(590, 26);
            this.btgrs.Name = "btgrs";
            this.btgrs.Size = new System.Drawing.Size(75, 23);
            this.btgrs.TabIndex = 6;
            this.btgrs.Text = "giris";
            this.btgrs.UseVisualStyleBackColor = true;
            this.btgrs.Click += new System.EventHandler(this.btgrs_Click);
            // 
            // btkaydol
            // 
            this.btkaydol.Location = new System.Drawing.Point(671, 26);
            this.btkaydol.Name = "btkaydol";
            this.btkaydol.Size = new System.Drawing.Size(75, 23);
            this.btkaydol.TabIndex = 7;
            this.btkaydol.Text = "kaydet";
            this.btkaydol.UseVisualStyleBackColor = true;
            this.btkaydol.Click += new System.EventHandler(this.btkaydol_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(260, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btkaydol);
            this.Controls.Add(this.btgrs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btfind);
            this.Controls.Add(this.txAra2);
            this.Controls.Add(this.cmbroomtype);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmbroomtype;
        private System.Windows.Forms.TextBox txAra2;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btgrs;
        private System.Windows.Forms.Button btkaydol;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}