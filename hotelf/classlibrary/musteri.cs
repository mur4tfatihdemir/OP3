using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
    public class musteri : DbObject
    {
        public musteri()
        {
        }

        public musteri(string adi, string soyadi, string sifre, string kullaniciid, string tel, string email, int tc)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.sifre = sifre;
            this.kullaniciid = kullaniciid;
            this.tel = tel;
            this.email = email;
            this.tc = tc;
        }

         public  string adi { get; set; }
        public string soyadi { get; set; }
        public string sifre { get; set; }
        public string kullaniciid { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public int tc { get; set; }

    }
}
