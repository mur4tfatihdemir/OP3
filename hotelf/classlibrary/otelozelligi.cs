using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
    public class otelozelligi : DbObject
    {
        public otelozelligi(string otelid, string özellikid)
        {
            this.otelid = otelid;
            this.özellikid = özellikid;
        }

        public string otelid { get; set; }
        public string özellikid { get; set; }
    }
}

