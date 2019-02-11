using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
   public  class DbObject
    {



        public string id { get; set; }
        
        public string olusturmatar { get; set; }
        [MaxLength(50)]
        public string olusturan { get; set; }
        public DateTime  olusturmatarihi { get; set; }
    
        public DateTime guncellenmetarihi {get; set; }
        [MaxLength(50)]
        public string guncelleyen { get; set; }
        public DbObject()
        {
            id = Guid.NewGuid().ToString();
            olusturmatarihi = DateTime.Now;
        }

    }
}
