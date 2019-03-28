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

namespace YazilimSinamaSonProje
{
    public partial class PersonalLogin : DevExpress.XtraEditors.XtraForm
    {
        public PersonalLogin()
        {
            InitializeComponent();
            _personalService=new PersonalManager(new PersonalDal());
        }

        private int _personalId;
        private IPersonalService _personalService;
        StokTakipContext context=new StokTakipContext();
        private void btnGirisYap_Click(object sender, EventArgs e)

        {
            _personalId = Convert.ToInt32(tbxPersonalId.Text);
            if (_personalService.GirisPersonal(Convert.ToInt32(tbxPersonalId.Text), Convert.ToInt32(tbxPersonalSifre.Text))!=null)
            {
                MessageBox.Show("Giris Basarili");
                var sorgu = from z in context.Zimmet
                    join u in context.Urun on z.UrunId equals u.UrunId
                    where (z.PersonalId == _personalId)
                    select new
                    {
                        z.ZimmetAded,
                        u.UrunAdi,
                       


                    };
                dgwPersonalZimmet.DataSource = sorgu.ToList();
                dgwPersonalZimmet.Visible = true;
                try
                {
                    if (Convert.ToInt32(dgwPersonalZimmet.CurrentRow.Cells[0].Value) > 0)
                    {
                        MessageBox.Show("Zimmetli ürünleriniz bulunmaktadır");



                    }
                }
                catch 
                {
                    MessageBox.Show("Zimmetli ürünleriniz bulunmamaktadır");
               
                   
                }
                
            }
            else
            {
                MessageBox.Show("Giris basarisiz");
            }
        }

        private void PersonalLogin_Load(object sender, EventArgs e)
        {
          
        }
    }
}