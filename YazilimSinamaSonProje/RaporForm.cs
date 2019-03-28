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
using StokTakip.DataAccess.EfModel;
using Exception = System.Exception;

namespace YazilimSinamaSonProje
{
    public partial class RaporForm : DevExpress.XtraEditors.XtraForm
    {
        public RaporForm()
        {
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            try
            {
                using (StokTakipContext context = new StokTakipContext())
                {
                    PersonalBindingSource.DataSource = context.Personal.ToList();
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}