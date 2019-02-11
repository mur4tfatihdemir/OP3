using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
    public class ozellik : DbObject
    {
        public ozellik(string özellikadi, string özellikid)
        {
            this.özellikadi = özellikadi;
            this.özellikid = özellikid;
        }
        [Required]
        public string özellikadi { get; set; }

        public string özellikid { get; set; }
    }
}
