using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
    public class otelresimleri : DbObject
    {
        public otelresimleri(string otelid, byte resim)
        {
            this.otelid = otelid;
            this.resim = resim;
        }

        public string otelid { get; set; }
        public byte  resim { get; set; }
    }
}
