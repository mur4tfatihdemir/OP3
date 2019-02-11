using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
  public class otel : DbObject
    {
        public otel(string adi, string adresi, string vergino, string resmiadi, string aciklama, string yorum, string yildiz)
        {
            this.adi = adi;
            this.adresi = adresi;
            this.vergino = vergino;
            this.resmiadi = resmiadi;
            this.aciklama = aciklama;
            this.yorum = yorum;
            this.yildiz = yildiz;
        }

        public string adi { get; set; }
        public string adresi { get; set; }
        public string vergino { get; set; }
        public string resmiadi { get; set; }
        public string aciklama { get; set; }
        public string yorum { get; set; }
        public string yildiz { get; set; }

    }
}
