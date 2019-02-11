using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
  public   class yorum : DbObject
    {
        public yorum(string musteriid, string yorumbas, string yorumicer, string yildiz)
        {
            this.musteriid = musteriid;
            this.yorumbas = yorumbas;
            this.yorumicer = yorumicer;
            this.yildiz = yildiz;
        }

        public string musteriid { get; set; }
        public string yorumbas { get; set; }
        public string yorumicer { get; set; }
        public string yildiz { get; set; }
    }
}
