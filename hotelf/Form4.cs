using hotelf.classlibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelf
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnsfre_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void btnkyt_Click(object sender, EventArgs e)
        {
            kayit5 f55 = new kayit5();
            f55.Show();
            this.Hide();
        }

        private void btngrs_Click(object sender, EventArgs e)
        {
            var giris = Dfactory1.MusteriCrud.Records.FirstOrDefault(x => x.sifre == textBox1.Text && x.adi == textBox2.Text);
            if (giris == null) { MessageBox.Show("giris basarili");
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }
            else { MessageBox.Show("giris basarısız"); }

        }
    }
}
