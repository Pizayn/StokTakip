using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.Abstract;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.DataAccess.Concrate
{
    public class ZimmetDal:EntityRepositoryBase<Zimmet,StokTakipContext>,IZimmetDal
    {
        public Zimmet SearchUrun(int urunId, int personalId)
        {
            using (StokTakipContext context=new StokTakipContext())
            {
                Zimmet zimmet = context.Zimmet.Where(z => z.UrunId == urunId && z.PersonalId == personalId)
                    .SingleOrDefault();
                return zimmet;

            }

        }
    }
}
