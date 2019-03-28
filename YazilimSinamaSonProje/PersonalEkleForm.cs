using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using StokTakip.Business.Abstract;
using StokTakip.Business.Concrate;
using StokTakip.Business.Utilities;
using StokTakip.DataAccess.Concrate;
using StokTakip.DataAccess.EfModel;
using YazilimSinamaSonProje.Models;

namespace YazilimSinamaSonProje
{
    public partial class PersonalEkleForm : DevExpress.XtraEditors.XtraForm
    {
        public PersonalEkleForm()
        {
            InitializeComponent();
            _yoneticiService = new YoneticiManager(new YoneticiDal());
            _kisiService = new KisiManager(new KisiDal());
            _personalService = new PersonalManager(new PersonalDal());

        }
        
        private IYoneticiService _yoneticiService;
        private IKisiService _kisiService;
        private IPersonalService _personalService;

        private int _personalId;
        private void PersonalEkleForm_Load(object sender, EventArgs e)
        {
            txtPersonalId.Text = _personalService.PersonalIdUret().ToString();
            _personalId = Convert.ToInt32(txtPersonalId.Text);
            txtSifre.Text = _personalService.PersonalSifreUret().ToString();
            txtBolumId.Text = 2.ToString();
          




        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonalEkleFormModel model = new PersonalEkleFormModel();
          

           

           

            try
            {
                model.Kisi.KisiId = Convert.ToInt64(txtTcNo.Text);
                model.Kisi.Isim = txtIsim.Text;
                model.Kisi.SoyIsim = txtSoyIsim.Text;
                _kisiService.Add(model.Kisi);
                MessageBox.Show(txtIsim.Text+" "+txtSoyIsim.Text);
        
              
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            try
            {
                model.Personal.PersonalId = _personalId;
                model.Personal.KisiId = Convert.ToInt64(txtTcNo.Text);
                model.Personal.Adi = txtIsim.Text;
                model.Personal.Soyadi = txtSoyIsim.Text;
                model.Personal.BolumId = Convert.ToInt32(txtBolumId);
                model.Personal.Mail = myEmailTextEdit1.Text;
                model.Personal.Sifre = Convert.ToInt32(txtSifre.Text);
                _personalService.Add(model.Personal);
                MessageBox.Show("Personal Olarak Eklendi");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myTcKimlikNoEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barBtnCikis_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}