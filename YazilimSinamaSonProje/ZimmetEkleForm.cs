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
    public partial class ZimmetEkleForm : DevExpress.XtraEditors.XtraForm
    {
        public ZimmetEkleForm()
        {
            InitializeComponent();
            _urunService=new UrunManager(new UrunDal());
            _personalService=new PersonalManager(new PersonalDal());
            _markaService=new MarkaManager(new MarkaDal());
            _zimmetService=new ZimmetManager(new ZimmetDal());
        }

       
        private IUrunService _urunService;
        private IPersonalService _personalService;
        StokTakipContext context=new StokTakipContext();
        private IMarkaService _markaService;
        private IZimmetService _zimmetService;
      
        Urun urun=new Urun();
        private void ZimmetEkleForm_Load(object sender, EventArgs e)
        {
            cbxPersonal.DataSource = _personalService.GetAll();
            cbxPersonal.DisplayMember = "Adi";
            cbxPersonal.ValueMember = "PersonalId";
            txtZimmetId.Text = _zimmetService.ZimmetIdUret().ToString();
            cbxUrun.DataSource = _urunService.GetUrunByStokDurum(1);
            cbxUrun.DisplayMember = "UrunAdi";
            cbxUrun.ValueMember = "UrunId";
          
            
           

        }

        private void barBtnZimmetKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          ZimmetEkleFormModel model=new ZimmetEkleFormModel();
          model.Urun = _urunService.GetUrunAdedByUrunId(Convert.ToInt32(cbxUrun.SelectedValue));
          model.Personal = _personalService.GetPersonalByPersonalId(Convert.ToInt32(cbxPersonal.SelectedValue));
          model.Marka = _markaService.GetByMarkaId(model.Urun.MarkaId);
          model.Zimmet = new Zimmet();
            var kalanUrunAdet = model.Urun.UrunAded - Convert.ToInt32(spinEditZimmetAded.Value);


           


            if (kalanUrunAdet>=0)
            {
                
                MessageBox.Show("Kalan Aded " +kalanUrunAdet.ToString());
                if (kalanUrunAdet == 0)
                {
                    model.Urun.StokDurum = 0;
                }
                if (_zimmetService.UrunSearch(Convert.ToInt32(cbxUrun.SelectedValue), Convert.ToInt32(cbxPersonal.SelectedValue)) != null)
                {
                    MessageBox.Show("Seçtiğiniz personlin zaten bu üründen zimmetli.Lüten farklı ürün seçin");
                    
                }
                else
                {
                    try
                    {

                        model.Zimmet.ZimmetId = Convert.ToInt32(txtZimmetId.Text);
                        model.Zimmet.ZimmetAded = Convert.ToInt32(spinEditZimmetAded.Value);
                        model.Zimmet.ZimmetDurumu = 1;
                        model.Zimmet.MarkaId = model.Marka.MarkaId;
                        model.Zimmet.UrunId = model.Urun.UrunId;
                        model.Zimmet.PersonalId = model.Personal.PersonalId;

                       _zimmetService.Add(model.Zimmet);
                        MessageBox.Show(cbxUrun.Text + "Zimmetlendi ");
                        this.Hide();

                        model.Urun.UrunAded = kalanUrunAdet;
                        _urunService.Update(model.Urun);
                       

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
               
              

            }
            else
            {
                MessageBox.Show("En fazla"+model.Urun.UrunAded.ToString()+ " aded seçebilirsin");
            }

        }
    }
}