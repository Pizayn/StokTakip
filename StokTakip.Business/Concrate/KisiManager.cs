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
    public class KisiManager : IKisiService
    {
        KisiValidationRule kisiValidationRule=new KisiValidationRule();
        private IKisiDal _kisiDal;
        public KisiManager(IKisiDal kisiDal)
        {
            _kisiDal = kisiDal;
        }
        public void Add(Kisi kisi)
        {
            kisiValidationRule.Validate( kisi);
            _kisiDal.Add(kisi);
        }

        public void Update(Kisi kisi)
        {
            kisiValidationRule.Validate(kisi);
            _kisiDal.Update(kisi);
        }

        public void Delete(Kisi kisi)
        {
            _kisiDal.Delete(kisi);
        }

        public List<Kisi> GetAll()
        {
            return _kisiDal.GetAll();
        }

        public Kisi GetKisiById(long kisiId)
        {
            return _kisiDal.Get(k => k.KisiId == kisiId);
        }
        
    }
}
