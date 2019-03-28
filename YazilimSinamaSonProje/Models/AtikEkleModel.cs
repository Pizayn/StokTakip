using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.EfModel;

namespace YazilimSinamaSonProje.Models
{
   public class AtikEkleModel
    {
        public Marka Marka { get; set; }
        public Atik Atik { get; set; }
        public Urun Urun { get; set; }
    }
}
