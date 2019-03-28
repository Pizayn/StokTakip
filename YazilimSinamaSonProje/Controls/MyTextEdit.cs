using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.ComponentModel;
namespace YazilimSinamaSonProje.Controls
{
    [ToolboxItem(true)]
    public class MyTextEdit : TextEdit
    {
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Blue;
            Properties.MaxLength = 50;


        }

        public override bool EnterMoveNextControl { get; set; } = true;

       

    }
    //entera basıldığında bir sonraki kontrole geçmesini sağlar
    //eğer button içeriyorsa IStatusbar dan implemente olucak
    //Button içermiyorsa IStatusBarAciklamadan implemente olucak
}

