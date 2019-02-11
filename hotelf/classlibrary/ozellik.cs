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
        private string _ozellikadi;

        [Required]
        public string ozellikadi { get => _ozellikadi; set => _ozellikadi = value; }

        public string ozellikid { get; set; }
    }
}
