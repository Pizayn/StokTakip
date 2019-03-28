using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Business.Abstract;
using StokTakip.Business.Utilities;
using StokTakip.Business.ValidationRule;
using StokTakip.DataAccess.Abstract;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.Concrate
{
    public class PersonalManager : IPersonalService
    {
        PersonalValidator _personalValidator=new PersonalValidator();
        private IPersonalDal _personalDal;
        public PersonalManager(IPersonalDal personalDal)
        {
            _personalDal = personalDal;
        }
        public void Add(Personal personal)
        {
            _personalValidator.Validate( personal);
            _personalDal.Add(personal);
        }

        public List<Personal> GetAll()
        {
            return _personalDal.GetAll();
        }

        public int PersonalIdUret()
        {
            var personalId = 0;
           Random r=new Random();
          personalId= r.Next(10000, 99999);
            return personalId;


        }

        public int PersonalSifreUret()
        {
            var personalSıfreId = 0;
            Random r=new Random();
            personalSıfreId = r.Next(1000, 9999);
            return personalSıfreId;
        }

        public List<Personal> GetPersonalById(int personalId)
        {
            return _personalDal.GetAll(c => c.PersonalId == personalId);
        }

        public Personal GetPersonalByPersonalId(int personalId)
        {
            return _personalDal.Get(p => p.PersonalId == personalId);
        }


        public void Update(Personal personal)
        {
            _personalValidator.Validate(personal);
            _personalDal.Update(personal);
        }

        public void Delete(Personal personal)
        {
            _personalDal.Delete(personal);
        }

        public Personal GirisPersonal(int personalId, int personalParola)
        {
            return _personalDal.GirisPersonal(personalId, personalParola);
        }
    }
}
