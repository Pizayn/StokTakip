using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.Abstract
{
    public interface IYoneticiService
    {
        List<Yonetici> GetAll();
        void Add(Yonetici yonetici);
        void Update(Yonetici yonetici);
        Yonetici GirisYonetici(int yoneticiId, int yoneticiParola);
    }
}
