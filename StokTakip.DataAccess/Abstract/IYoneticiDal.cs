using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.DataAccess.Abstract
{
    public interface IYoneticiDal:IEntityRepository<Yonetici>
    {
        Yonetici GirisYonetici(int yoneticiId, int yoneticiParola);
    }
}
