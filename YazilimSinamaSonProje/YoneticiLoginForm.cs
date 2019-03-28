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

namespace YazilimSinamaSonProje
{
    public partial class YoneticiLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public YoneticiLoginForm()
        {
            InitializeComponent();
            _yoneticiService=new YoneticiManager(new YoneticiDal());
        }

        private IYoneticiService _yoneticiService;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (_yoneticiService.GirisYonetici(Convert.ToInt32(tbxYoneticiId.Text), Convert.ToInt32(tbxYoneticiSifre.Text)) != null)
                {
                    MessageBox.Show("Giriş Başarılı");
                    StokTakip stokTakip = new StokTakip();
                    stokTakip.Show();
                    this.Hide();
                }
            }
            catch 
            {
                MessageBox.Show("Giriş Başarısız");
            }
           
        }
    }
}