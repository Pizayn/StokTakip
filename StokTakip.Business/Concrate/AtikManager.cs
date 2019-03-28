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
   public class AtikManager:IAtikService
    {
        AtikValidation _atikValidation=new AtikValidation();
        public AtikManager(IAtikDal atikDal)
        {
            _atikDal = atikDal;
        }

        private IAtikDal _atikDal;
        public List<Atik> GetAll()
        {

            return _atikDal.GetAll();
        }

        public void Add(Atik atik)
        {
            _atikValidation.Validate(atik);
            _atikDal.Add(atik);
        }

        public void Update(Atik atik)
        {
            _atikValidation.Validate(atik);
            _atikDal.Update(atik);
        }

        public void Delete(Atik atik)
        {
           _atikDal.Delete(atik);
        }

        public int AtikIdUret()
        {
            Random r=new Random();
            var atikId = r.Next(10000, 99999);
            return atikId;
        }
    }
}
