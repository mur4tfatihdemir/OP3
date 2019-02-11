using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
    public class yildiz : DbObject
    {
        public yildiz(int begenmesayisi, int begenmemesayisi)
        {
            this.begenmesayisi = begenmesayisi;
            this.begenmemesayisi = begenmemesayisi;
        }

        public int begenmesayisi { get; set; }
        public int begenmemesayisi { get; set; }
    }
}
