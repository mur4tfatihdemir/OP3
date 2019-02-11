using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{ [Table ("Illerb") ]
    public class IL :DbObject

    {
        [Required]
        public string IlAdi { get; set; }
        public List<Ilce> Ilceler { get; set; }
        public IL (string ilAdi)
        {
            IlAdi = ilAdi;
            Ilceler = new List<Ilce>();
        }
        public override string ToString()
        {
            return IlAdi;
        }
        public IL() { }

    }   
}
