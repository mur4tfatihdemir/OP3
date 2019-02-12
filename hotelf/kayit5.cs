using hotelf.classlibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelf
{
    public partial class kayit5 : Form
    {
        public kayit5()
        {
            InitializeComponent();
        }

        private void kayit5_Load(object sender, EventArgs e)
        {

        }

        private void txkytol_Click(object sender, EventArgs e)
        {
            musteri musteri  = new musteri();
            musteri.adi = txad.Text;
            musteri.soyadi = txsoyad.Text;
            musteri.kullaniciid = txkullaniciadi.Text;
            musteri.sifre = txsfre.Text;
            musteri.tel = txtel.Text;
            musteri.tc = Convert.ToInt32(txtc.Text);
            var musteriVarMi = Dfactory1.MusteriCrud.Records.Any(x => x.adi == txkullaniciadi.Text);
            if (musteriVarMi == true)
            {
                MessageBox.Show("Başka kullanıcı adı giriniz.");
            }
            else
            {
                bool musteriEklendiMi = Dfactory1.MusteriCrud.Insert(musteri);
                if (musteriEklendiMi == true)
                {
                    MessageBox.Show("Yeni Kayıt Oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("Tekrar deneyin");
                }
            }

            Form4 frmGiris = new Form4();
            frmGiris.Show();
            this.Hide();
        }
    }
}
