using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Business.Abstract;
using StokTakip.DataAccess.Abstract;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.Concrate
{
    public class YoneticiManager:IYoneticiService
    {
        private IYoneticiDal _yoneticiDal;
        public YoneticiManager(IYoneticiDal yoneticiDal)
        {
            _yoneticiDal = yoneticiDal;
        }
        public List<Yonetici> GetAll()
        {
            return _yoneticiDal.GetAll();
        }

        public void Add(Yonetici yonetici)
        {
            _yoneticiDal.Add(yonetici);
        }

        public void Update(Yonetici yonetici)
        {
            _yoneticiDal.Update(yonetici);
        }

        public Yonetici GirisYonetici(int yoneticiId, int yoneticiParola)
        {
            return _yoneticiDal.GirisYonetici(yoneticiId, yoneticiParola);
        }
    }
}
