using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;


namespace YazilimSinamaSonProje.Controls
{
    [ToolboxItem(true)]
    public class MyComboBoxEdit : ComboBoxEdit
    {
        public MyComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            //üzerine yazı yazılmasını engeller


        }

        public override bool EnterMoveNextControl { get; set; } = true;


        public string StatusBarAciklama { get; set; }
        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
    }
}
