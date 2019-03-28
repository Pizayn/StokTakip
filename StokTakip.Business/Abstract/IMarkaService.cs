using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.Abstract
{
    public interface IMarkaService
    {
        void Delete(Marka marka);
        void Update(Marka marka);
        void Add(Marka marka);
        List<Marka> GetAll();
        Marka GetByMarkaId(int markaId);
    }
}
