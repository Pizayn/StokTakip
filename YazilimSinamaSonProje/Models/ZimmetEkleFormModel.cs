using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.EfModel;

namespace YazilimSinamaSonProje.Models
{
    public class ZimmetEkleFormModel
    {
        public Zimmet Zimmet { get; set; }
        public Urun Urun { get; set; }
        public Personal Personal { get; set; }
        public Marka Marka { get; set; }
    }
}
