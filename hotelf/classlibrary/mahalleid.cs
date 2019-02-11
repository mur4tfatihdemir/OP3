using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
    public class mahalleid : DbObject
    {public string MahalleAdi { get; set; }
        public override string ToString()
        {
            return MahalleAdi;
        }
    }
}
