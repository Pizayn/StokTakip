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
    public partial class UrunGunceleForm : DevExpress.XtraEditors.XtraForm
    {
        public UrunGunceleForm()
        {
            InitializeComponent();
            _urunService = new UrunManager(new UrunDal());
            _markaService=new MarkaManager(new MarkaDal());
            
        }

        public int markaId { get; set; }
        public int urunId { get; set; }

        private void barBtnUrunGüncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UrunGuncelleFormModel model=new UrunGuncelleFormModel()
            {
                Urun = new Urun(),
                Marka = new Marka(),
            };
            try
            {
                model.Marka.MarkaId = Convert.ToInt32(txtMarkaId.Text);
                model.Marka.MarkaAdi = txtMarkaAdi.Text;
               _markaService.Add(model.Marka);
                MessageBox.Show("Urun Guncelleniyor");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }





            try
            {
                model.Urun.MarkaId = model.Marka.MarkaId;
                model.Urun.UrunAdi = txtUrunIsmi.Text;
                model.Urun.UrunAded = Convert.ToInt32(txtUrunAdedi.Text);
                model.Urun.UrunId = Convert.ToInt32(txtUrunId.Text);
                model.Urun.StokDurum = toggleSwitchStokDurum.IsOn ? 1 : 0;
               _urunService.Add(model.Urun);
                MessageBox.Show("Güncellendi");
                

            }
            catch
            {
                MessageBox.Show("Test214");
            }
        }

        private IUrunService _urunService;
        private IMarkaService _markaService;
        StokTakipContext context=new StokTakipContext();
        
        private void UrunGunceleForm_Load(object sender, EventArgs e)
        {
            UrunGuncelleFormModel model = new UrunGuncelleFormModel()
            {
                Urun = _urunService.GetUrunAdedByUrunId(urunId),
                Marka = new Marka(),
            };
            model.Marka = _markaService.GetByMarkaId(model.Urun.MarkaId);


            try
            {
               
               
                txtMarkaId.Text = model.Urun.MarkaId.ToString();
                txtUrunId.Text = model.Urun.UrunId.ToString();
                txtMarkaAdi.Text = model.Marka.MarkaAdi.ToString();
                txtUrunIsmi.Text = model.Urun.UrunAdi.ToString();
                txtUrunAdedi.Text = model.Urun.UrunAded.ToString();
                
                if (model.Urun.StokDurum == 1)
                {
                    toggleSwitchStokDurum.IsOn = true;
                }
                else
                {
                    toggleSwitchStokDurum.IsOn = false;
                }

              

            }
            catch
            {
                
            }
            



        }

        private void dgwUrunGuncelle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}