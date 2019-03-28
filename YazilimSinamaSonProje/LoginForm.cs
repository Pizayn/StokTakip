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

namespace YazilimSinamaSonProje
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            PersonalLogin personalLogin=new PersonalLogin();
            personalLogin.Show();
            this.Hide();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            YoneticiLoginForm yoneticiLoginForm=new YoneticiLoginForm();
            yoneticiLoginForm.Show();
            this.Hide();
        }
    }
}