using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.Abstract
{
    public interface IZimmetService
    {
        List<Zimmet> GetAll();
        void Add(Zimmet zimmet);
        void Update(Zimmet zimmet);
        void Delete(Zimmet zimmet);
        int ZimmetIdUret();
        Zimmet UrunSearch(int urunId, int personalId);
    }
}
