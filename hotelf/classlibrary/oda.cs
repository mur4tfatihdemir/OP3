using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
 {
    [Table("Oda")]
    public class oda : DbObject
    {
        public oda(string otelid, string odatipi, bool bosmu, int ucret)
        {
            this.otelid = otelid;
            this.odatipi = odatipi;
            this.bosmu = bosmu;
            this.ucret = ucret;
        }
        
        public string otelid { get; set; }
        
        public string odatipi { get; set; }
        public bool bosmu { get; set; }
        [Required]
        public int ucret { get; set; }
    }
}
