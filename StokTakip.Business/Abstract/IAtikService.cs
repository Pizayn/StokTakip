using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.EfModel;

namespace StokTakip.Business.Abstract
{
    public interface IAtikService
    {
        List<Atik> GetAll();
        void Add(Atik atik);
        void Update(Atik atik);
        void Delete(Atik atik);
        int AtikIdUret();
    }
}
