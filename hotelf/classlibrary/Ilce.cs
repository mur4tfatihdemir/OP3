using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
    public class Ilce : DbObject
    {
        public Ilce(string ılceAdi, List<mahalleid> mahalleidler)
        {
            IlceAdi = ılceAdi;
            this.mahalleidler = mahalleidler;
        }

        public string IlceAdi { get; set; }
        public List<mahalleid> mahalleidler { get; set; }
        public override string ToString()
        {
           return IlceAdi; 
       
        }
        public Ilce() { }
    }
}