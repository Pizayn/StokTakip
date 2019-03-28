using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Business.Abstract;
using StokTakip.Business.Utilities;
using StokTakip.Business.ValidationRule;
using StokTakip.DataAccess.Concrate;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.Concrate
{
    public class MarkaManager : IMarkaService
    {
        public MarkaManager(MarkaDal markaDal)
        {
            _markaDal = markaDal;
        }

        private MarkaDal _markaDal;
        public void Add(Marka marka)
        {
         
            _markaDal.Add(marka);
        }

        public void Delete(Marka marka)
        {
            _markaDal.Delete(marka);
        }

        public List<Marka> GetAll()
        {
            return _markaDal.GetAll();
        }

        public Marka GetByMarkaId(int markaId)
        {
            return _markaDal.Get(m => m.MarkaId == markaId);
        }

        public void Update(Marka marka)
        {
           
            _markaDal.Update(marka);
        }
    }
}
