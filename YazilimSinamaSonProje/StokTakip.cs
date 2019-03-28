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
using StokTakip.DataAccess.Abstract;
using StokTakip.Business.Abstract;
using StokTakip.Business.Concrate;
using StokTakip.DataAccess.Concrate;
using StokTakip.DataAccess.EfModel;
using YazilimSinamaSonProje.Models;

namespace YazilimSinamaSonProje
{
    public partial class StokTakip : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public StokTakip()
        {
            InitializeComponent();
            _yoneticiService=new YoneticiManager(new YoneticiDal());
            _kisiService=new KisiManager(new KisiDal());
            _personalService=new PersonalManager(new PersonalDal());
            _markaService=new MarkaManager(new MarkaDal());
            _urunService=new UrunManager(new UrunDal());
            _zimmetService=new ZimmetManager(new ZimmetDal());
            _atikService=new AtikManager(new AtikDal());
            
        }

        private int _personalId = 0;
        private int _markaId = 0;
        private int _urunId = 0;  
        StokTakipContext context=new StokTakipContext();
        private IYoneticiService _yoneticiService;
        private IKisiService _kisiService;
        private IPersonalService _personalService;
        private IUrunService _urunService;
        private IMarkaService _markaService;
        private IZimmetService _zimmetService;
        private IAtikService _atikService;
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PersonalEkleForm personalEkleForm=new PersonalEkleForm();
            personalEkleForm.Show();
          }

        private void StokTakip_Load(object sender, EventArgs e)
        {
           

         

        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            dgwTakip.DataSource = _personalService.GetAll();







        }

        private void barButtonGüncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Convert.ToInt32(dgwTakip.CurrentRow.Cells[4].Value) == 1)
            {
                PersonalGuncelle guncelle = new PersonalGuncelle();
                guncelle.personalId = _personalId;
                guncelle.Show();
            }
            if (Convert.ToInt32(dgwTakip.CurrentRow.Cells[5].Value) == 1 || Convert.ToInt32(dgwTakip.CurrentRow.Cells[5].Value) == 0)
            {
                UrunGunceleForm urunGunceleForm = new UrunGunceleForm();
                urunGunceleForm.urunId = _urunId;
                urunGunceleForm.Show();
            }


        }

        private void dgwTakip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgwTakip.CurrentRow.Cells[4].Value) == 1)
                {
                    _personalId = Convert.ToInt32(dgwTakip.CurrentRow.Cells[0].Value);
                }
            }
            catch 
            {
                
            }
            try
            {
                if (Convert.ToInt32(dgwTakip.CurrentRow.Cells[5].Value) == 1 || Convert.ToInt32(dgwTakip.CurrentRow.Cells[5].Value) == 0)
                {
                    _urunId = Convert.ToInt32(dgwTakip.CurrentRow.Cells[1].Value);
                }
            }
            catch
            {

            }



        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgwTakip.CurrentRow.Cells[4].Value) == 1)
                {
                    try
                    {
                        _personalService.Delete(new Personal()
                        {
                            PersonalId = Convert.ToInt32(dgwTakip.CurrentRow.Cells[0].Value)
                        });
                        MessageBox.Show("Personal siliniyor");



                    }
                    catch
                    {
                        MessageBox.Show("Silmek istediğin personelin üzerine tıkladığından emin ol");
                    }

                    try
                    {
                        _kisiService.Delete(new Kisi()
                        {
                            KisiId = Convert.ToInt64(dgwTakip.CurrentRow.Cells[3].Value)
                        });
                        MessageBox.Show("Personal silindi");
                    }
                    catch
                    {
                        MessageBox.Show("Zimmetli Eşyası olan personeli silemezsin");
                    }
                }

                if (Convert.ToInt32(dgwTakip.CurrentRow.Cells[5].Value) == 1 || Convert.ToInt32(dgwTakip.CurrentRow.Cells[5].Value) == 0)
                {
                    try
                    {
                        _urunService.Delete(new Urun()
                        {
                            UrunId = Convert.ToInt32(dgwTakip.CurrentRow.Cells[1].Value)
                        });

                        MessageBox.Show("Ürün siliniyor");



                    }
                    catch
                    {
                        MessageBox.Show("Kullanılan Ürünü silemezsin");
                    }

                    try
                    {
                        _markaService.Delete(new Marka()
                        {
                            MarkaId = Convert.ToInt32(dgwTakip.CurrentRow.Cells[1].Value)
                        });
                        MessageBox.Show("Ürün silindi");
                    }
                    catch
                    {
                        MessageBox.Show("Kullanılan markayı silemezsin");
                    }
                }

                if (Convert.ToInt32(dgwTakip.CurrentRow.Cells[2].Value) == 1 ||
                    Convert.ToInt32(dgwTakip.CurrentRow.Cells[2].Value) == 0)
                {
                    try
                    {
                        _zimmetService.Delete(new Zimmet()
                        {
                            ZimmetId = Convert.ToInt32(dgwTakip.CurrentRow.Cells[0].Value)
                        });
                        MessageBox.Show("Zimmet Silindi");
                    }
                    catch
                    {
                        MessageBox.Show("TestZimmet");
                    }
                }
            }
            catch 
            {
               
            }
            



        }

        private void barButtonYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Convert.ToInt32(dgwTakip.CurrentRow.Cells[4].Value)==1)
            {
                dgwTakip.DataSource = _personalService.GetAll();
            }
        }

        private void navBarUrunEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UrunEkleForm urunEkleForm=new UrunEkleForm();
            urunEkleForm.Show();
        }

        private void navBarStokDurumu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            barButtonItemAtik.Visibility = BarItemVisibility.Always;
            barButtonItemSil.Visibility = BarItemVisibility.Never;
            var sorgu = from u in context.Urun
                join m in context.Marka on u.MarkaId equals m.MarkaId

                where(u.StokDurum==1) select new 
                {
                    m.MarkaId,
                    u.UrunId,
                    m.MarkaAdi,
                    u.UrunAdi,
                    u.UrunAded,
                    u.StokDurum,


                };
            dgwTakip.DataSource = sorgu.ToList();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ZimmetEkleForm zimmetEkleForm=new ZimmetEkleForm();
            zimmetEkleForm.Show();
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void barButtonItemAtik_ItemClick(object sender, ItemClickEventArgs e)
        {
            AtikEkleModel model = new AtikEkleModel();
            model.Urun = _urunService.GetUrunAdedByUrunId(Convert.ToInt32(dgwTakip.CurrentRow.Cells[0].Value));
            model.Marka = _markaService.GetByMarkaId(Convert.ToInt32(dgwTakip.CurrentRow.Cells[1].Value));
            model.Atik=new Atik();
            
            if (Convert.ToInt32(dgwTakip.CurrentRow.Cells[5].Value)==0)
            {
                try
                {
                   _urunService.Delete(model.Urun);
                }
                catch 
                {
                    MessageBox.Show("1");
                }

            }
            else
            {
                try
                {
                    model.Atik.AtikId = _atikService.AtikIdUret();
                    model.Atik.MarkaId = model.Marka.MarkaId;
                    model.Atik.UrunId = model.Urun.UrunId;
                    model.Atik.Aciklama = "Çöp";
                   _atikService.Add(model.Atik);
                    MessageBox.Show("Atık işlemi tamamlandı");

                    model.Urun.StokDurum = 0;
                   _urunService.Update(model.Urun);
                    MessageBox.Show("Ürün Güncellendi");
                    


                }
                catch 
                {
                    MessageBox.Show("Bişeyler Ters Gitti");
              
                }
            


            }

            
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var sorgu = from a in context.Atik
                join m in context.Marka on a.MarkaId equals m.MarkaId
                join u in  context.Urun on a.UrunId equals u.UrunId 
              
                select new
                {
                    m.MarkaId,
                    u.UrunId,
                    m.MarkaAdi,
                    u.UrunAdi,
                    u.UrunAded,
                    a.AtikId
                  


                };
            dgwTakip.DataSource = sorgu.ToList();
           
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            LoginForm loginForm=new LoginForm();
            loginForm.Show();
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            RaporForm raporForm=new RaporForm();
            raporForm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            barButtonItemAtik.Visibility = BarItemVisibility.Never;
            barButtonItemSil.Visibility = BarItemVisibility.Always;
            var sorgu = from z in context.Zimmet
                join u in context.Urun on z.UrunId equals u.UrunId
                join m in context.Marka on z.MarkaId equals m.MarkaId
                join p in context.Personal on z.PersonalId equals p.PersonalId
               select new ZimmetGoruntuleModel() 
                {
                    Adi = p.Adi,
                    Soyadi = p.Soyadi,
                    MarkaAdi = m.MarkaAdi,
                    UrunAdi = u.UrunAdi,
                    ZimmetAded = z.ZimmetAded,
                    ZimmetDurumu = z.ZimmetDurumu
                   
                   
                    
                };
            ZimmetGoruntuleListModel model=new ZimmetGoruntuleListModel()
            {
                ZimmetGoruntuleModels = sorgu.ToList(),
            };
            dgwTakip.DataSource = model.ZimmetGoruntuleModels;

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}