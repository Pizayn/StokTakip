using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.Abstract;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.DataAccess.Concrate
{
    public class YoneticiDal:EntityRepositoryBase<Yonetici,StokTakipContext>,IYoneticiDal
    {
        public Yonetici GirisYonetici(int yoneticiId, int yoneticiParola)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                Yonetici yonetici = context.Yonetici.Where(z => z.YoneticiId == yoneticiId && z.Sifre == yoneticiParola)
                    .SingleOrDefault();
                return yonetici;

            }

        }
    }
}
