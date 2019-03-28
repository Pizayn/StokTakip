using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.Abstract;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.DataAccess.Concrate
{
    public class UrunDal:EntityRepositoryBase<Urun,StokTakipContext>,IUrunDal
    {
    }
}
