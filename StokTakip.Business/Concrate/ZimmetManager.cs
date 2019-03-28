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
    public class ZimmetManager:IZimmetService
    {
        ZimmetValidation _zimmetValidation=new ZimmetValidation();
        public ZimmetManager(IZimmetDal zimmetDal)
        {
            _zimmetDal = zimmetDal;
        }

        private IZimmetDal _zimmetDal;
        public List<Zimmet> GetAll()
        {
            return _zimmetDal.GetAll();
        }

        public void Add(Zimmet zimmet)
        {
            _zimmetValidation.Validate(zimmet);
            _zimmetDal.Add(zimmet);
        }

        public void Update(Zimmet zimmet)
        {
            _zimmetDal.Update(zimmet);
        }

        public void Delete(Zimmet zimmet)
        {
           _zimmetDal.Delete(zimmet);
        }

        public int ZimmetIdUret()
        {
            
            Random random=new Random();
            var zimmetId = random.Next(10000, 99999);
            return zimmetId;
        }

        public Zimmet UrunSearch(int urunId, int personalId)
        {
            return _zimmetDal.SearchUrun(urunId,personalId);
        }
    }
}
