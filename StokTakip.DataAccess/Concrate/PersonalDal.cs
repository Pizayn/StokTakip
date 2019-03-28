using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.Abstract;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.DataAccess.Concrate
{
    public class PersonalDal:EntityRepositoryBase<Personal,StokTakipContext>,IPersonalDal
    {
        public Personal GirisPersonal(int personalId, int personalParola)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                Personal personal = context.Personal.Where(z => z.PersonalId == personalId && z.Sifre == personalParola)
                    .SingleOrDefault();
                return personal;

            }
        }
    }
}
