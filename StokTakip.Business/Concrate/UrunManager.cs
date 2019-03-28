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
   public class UrunManager:IUrunService
    {
        UrunlValidator urunlValidator = new UrunlValidator();
        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        private IUrunDal _urunDal;
        public void Add(Urun urun)
        {
            
            urunlValidator.Validate(urun);
            _urunDal.Add(urun);
        }

        public void Delete(Urun urun)
        {
           _urunDal.Delete(urun);
        }

        public void Update(Urun urun)
        {
            urunlValidator.Validate(urun);
            _urunDal.Update(urun);
        }

        public List<Urun> GetAll()
        {
            return _urunDal.GetAll();
        }

        public List<Urun> GetUrunAdedById(int urunId)
        {
            return _urunDal.GetAll(c => c.UrunId == urunId);
        }

        public List<Urun> GetUrunByStokDurum(int stokDurum)
        {
            return _urunDal.GetAll(c => c.StokDurum == 1);
        }

        public Urun GetUrunAdedByUrunId(int urunId)
        {
            return _urunDal.Get(c=>c.UrunId==urunId);
        }
    }
}
