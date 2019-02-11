using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
    public class rezervasyon : DbObject
    {
        public rezervasyon(string musteriid, string odaid, string kisisayisi, DateTime checkindate, DateTime checkoutdate, DateTime odemezamanı)
        {
            this.musteriid = musteriid;
            this.odaid = odaid;
            this.kisisayisi = kisisayisi;
            this.checkindate = checkindate;
            this.checkoutdate = checkoutdate;
            this.odemezamanı = odemezamanı;
        }

        public string musteriid { get; set; }
        public string odaid { get; set; }
        public string kisisayisi { get; set; }
        public DateTime checkindate { get; set; }
        public DateTime checkoutdate { get; set; }
        public DateTime odemezamanı { get; set; }

    }
}
