using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.DataAccess.Abstract
{
    public interface IPersonalDal:IEntityRepository<Personal>
    {
        Personal GirisPersonal(int personalId, int personalParola);
    }
}
