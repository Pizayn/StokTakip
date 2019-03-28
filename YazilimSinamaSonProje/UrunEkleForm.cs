using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokTakip.Business.Abstract;
using StokTakip.Business.Concrate;
using StokTakip.DataAccess.Concrate;
using StokTakip.DataAccess.EfModel;
using YazilimSinamaSonProje.Models;

namespace YazilimSinamaSonProje
{
    public partial class UrunEkleForm : DevExpress.XtraEditors.XtraForm
    {
        public UrunEkleForm()
        {
            InitializeComponent();
            _urunService=new UrunManager(new UrunDal());
            _markaService=new MarkaManager(new MarkaDal());
        }

        private IUrunService _urunService;
        private IMarkaService _markaService;
        private void barBtnUrunEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UrunEkleFormModel model=new UrunEkleFormModel()
            {
                Urun = new Urun(),
                Marka = new Marka(),
            };
            try
            {
                model.Marka.MarkaAdi = txtMarkaAdi.Text;
                model.Marka.MarkaId = Convert.ToInt16(txtMarkaId.Text);

               _markaService.Add(model.Marka);
                MessageBox.Show("Marka Adi " +txtMarkaAdi.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            try
            {
                model.Urun.UrunAdi = txtUrunIsmi.Text;
                model.Urun.MarkaId = model.Marka.MarkaId;
                model.Urun.StokDurum = 1;
                model.Urun.UrunAded = Convert.ToInt32(txtUrunAdedi.Text);
                model.Urun.UrunId = Convert.ToInt32(txtUrunId.Text);
                _urunService.Add(model.Urun);
                MessageBox.Show("Ürün Eklendi");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void UrunEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            StokTakip stokTakip = new StokTakip();
            stokTakip.Show();
        }
    }
}