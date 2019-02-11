namespace hotelf
{
    partial class Form9
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txyorumbaslik = new System.Windows.Forms.TextBox();
            this.richyorim = new System.Windows.Forms.RichTextBox();
            this.btnyrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(258, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txyorumbaslik
            // 
            this.txyorumbaslik.Location = new System.Drawing.Point(273, 205);
            this.txyorumbaslik.Name = "txyorumbaslik";
            this.txyorumbaslik.Size = new System.Drawing.Size(100, 20);
            this.txyorumbaslik.TabIndex = 1;
            // 
            // richyorim
            // 
            this.richyorim.Location = new System.Drawing.Point(273, 231);
            this.richyorim.Name = "richyorim";
            this.richyorim.Size = new System.Drawing.Size(100, 60);
            this.richyorim.TabIndex = 2;
            this.richyorim.Text = "";
            // 
            // btnyrm
            // 
            this.btnyrm.Location = new System.Drawing.Point(273, 297);
            this.btnyrm.Name = "btnyrm";
            this.btnyrm.Size = new System.Drawing.Size(75, 23);
            this.btnyrm.TabIndex = 3;
            this.btnyrm.Text = "yorumbuton";
            this.btnyrm.UseVisualStyleBackColor = true;
            this.btnyrm.Click += new System.EventHandler(this.btnyrm_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnyrm);
            this.Controls.Add(this.richyorim);
            this.Controls.Add(this.txyorumbaslik);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txyorumbaslik;
        private System.Windows.Forms.RichTextBox richyorim;
        private System.Windows.Forms.Button btnyrm;
    }
}