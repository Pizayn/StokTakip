using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.EfModel;

namespace YazilimSinamaSonProje.Models
{
    public class PersonalEkleFormModel
    {
        public Kisi Kisi { get; set; }
        public Personal Personal { get; set; }
        public Bolum Bolum { get; set; }
    }
}
