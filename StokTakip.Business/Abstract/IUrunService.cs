using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.Abstract
{
    public interface IUrunService
    {
        void Add(Urun urun);
        void Delete(Urun urun);
        void Update(Urun urun);
        List<Urun> GetAll();
        List<Urun> GetUrunAdedById(int urunId);
        List<Urun> GetUrunByStokDurum(int stokDurum);
        Urun GetUrunAdedByUrunId(int urunId);
    }
}
