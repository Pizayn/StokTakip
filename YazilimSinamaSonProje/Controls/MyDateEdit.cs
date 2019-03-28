using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;
namespace YazilimSinamaSonProje.Controls
{
    [ToolboxItem(true)]
    public class MyDateEdit : DateEdit
    {

        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            //tarih alanı null olarak geçilmesini engeller
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            //tarih textlerin ortaya yazılmasını sağlar
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            //tarih bölümüne yazdıkça sırayla gün kısmından ay kısmına aydan yıla atlar
        }

        
    }
}
