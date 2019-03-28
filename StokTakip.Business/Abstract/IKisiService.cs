using StokTakip.DataAccess.EfModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Business.Abstract
{
    public interface IKisiService
    {
        List<Kisi> GetAll();
        void Add(Kisi kisi);
        void Update(Kisi kisi);
        void Delete(Kisi kisi);
        Kisi GetKisiById(long kisiId);

    }
}
