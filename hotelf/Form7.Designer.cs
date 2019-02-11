namespace hotelf
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbksisayisi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chsmdi = new System.Windows.Forms.CheckBox();
            this.chsonra = new System.Windows.Forms.CheckBox();
            this.btntamamla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "utel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "otelno";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbksisayisi
            // 
            this.tbksisayisi.Location = new System.Drawing.Point(289, 130);
            this.tbksisayisi.Name = "tbksisayisi";
            this.tbksisayisi.Size = new System.Drawing.Size(100, 20);
            this.tbksisayisi.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(218, 193);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // chsmdi
            // 
            this.chsmdi.AutoSize = true;
            this.chsmdi.Location = new System.Drawing.Point(228, 232);
            this.chsmdi.Name = "chsmdi";
            this.chsmdi.Size = new System.Drawing.Size(47, 17);
            this.chsmdi.TabIndex = 5;
            this.chsmdi.Text = "smdi";
            this.chsmdi.UseVisualStyleBackColor = true;
            // 
            // chsonra
            // 
            this.chsonra.AutoSize = true;
            this.chsonra.Location = new System.Drawing.Point(338, 232);
            this.chsonra.Name = "chsonra";
            this.chsonra.Size = new System.Drawing.Size(52, 17);
            this.chsonra.TabIndex = 6;
            this.chsonra.Text = "sonra";
            this.chsonra.UseVisualStyleBackColor = true;
            // 
            // btntamamla
            // 
            this.btntamamla.Location = new System.Drawing.Point(289, 276);
            this.btntamamla.Name = "btntamamla";
            this.btntamamla.Size = new System.Drawing.Size(75, 23);
            this.btntamamla.TabIndex = 7;
            this.btntamamla.Text = "tamamla";
            this.btntamamla.UseVisualStyleBackColor = true;
            this.btntamamla.Click += new System.EventHandler(this.btntamamla_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntamamla);
            this.Controls.Add(this.chsonra);
            this.Controls.Add(this.chsmdi);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbksisayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbksisayisi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox chsmdi;
        private System.Windows.Forms.CheckBox chsonra;
        private System.Windows.Forms.Button btntamamla;
    }
}