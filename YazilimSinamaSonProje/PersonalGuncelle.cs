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
    public partial class PersonalGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public PersonalGuncelle()
        {
            InitializeComponent();
            _yoneticiService = new YoneticiManager(new YoneticiDal());
            _kisiService = new KisiManager(new KisiDal());
            _personalService = new PersonalManager(new PersonalDal());
        }
        public int personalId { get; set; }
        StokTakipContext context = new StokTakipContext();
        private IYoneticiService _yoneticiService;
        private IKisiService _kisiService;
        private IPersonalService _personalService;

        private void barBtnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                _kisiService.Update(new Kisi()
                {
                    KisiId = Convert.ToInt64(txtTcNo.Text),
                    Isim = txtIsim.Text,
                    SoyIsim = txtSoyIsim.Text

                });
                MessageBox.Show(txtIsim.Text + " " + txtSoyIsim.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
              

            
           

            try
            {
                _personalService.Update(new Personal()
                {
                    KisiId = context.Kisi.Where(c => c.Isim == txtIsim.Text ).Select(c => c.KisiId).First(),
                    Adi = txtIsim.Text,
                    Soyadi = txtSoyIsim.Text,
                    BolumId = context.Bolum.Where(c => c.BolumAdi == "Calisan").Select(c => c.BolumId).First(),
                    Mail = myEmailTextEdit1.Text,
                    PersonalId = Convert.ToInt32(txtPersonalId.Text),
                    Sifre = Convert.ToInt32(txtSifre.Text)
                });
                MessageBox.Show("Güncellendi");
                this.Hide();
                
            }
            catch
            {
                MessageBox.Show("Önce Kişi Olarak Ekleyin");
            }
        }

        private void PersonalGuncelle_Load(object sender, EventArgs e)
        {
            PersonelGuncelleFormModel model = new PersonelGuncelleFormModel();
            model.Personal = _personalService.GetPersonalByPersonalId(personalId);
            model.Kisi = _kisiService.GetKisiById(model.Personal.KisiId);
            
           
            try
            {
               
                txtPersonalId.Text = model.Personal.PersonalId.ToString();
                txtIsim.Text = model.Personal.Adi;
                txtSoyIsim.Text = model.Personal.Soyadi;
                txtTcNo.Text = model.Personal.KisiId.ToString();
                txtBolumId.Text = model.Personal.BolumId.ToString();
                txtSifre.Text = model.Personal.Sifre.ToString();
                myEmailTextEdit1.Text = model.Personal.Mail;




            }
            catch 
            {
               
            }
            


        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            StokTakip stokTakip=new StokTakip();
            stokTakip.Show();
        }
    }
}