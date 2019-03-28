using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.Abstract
{
    public interface IPersonalService
    {
        List<Personal> GetAll();
        void Add(Personal personal);
        int PersonalIdUret();
        int PersonalSifreUret();
        List<Personal> GetPersonalById(int personalId);
        Personal GetPersonalByPersonalId(int personalId);
        void Update(Personal personal);
        void Delete(Personal personal);
        Personal GirisPersonal(int personalId, int personalParola);
    }
}
