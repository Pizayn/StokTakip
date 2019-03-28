using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraEditors.Mask;

namespace YazilimSinamaSonProje.Controls
{
    [ToolboxItem(true)]
    public class MyEmailTextEdit : TextEdit
    {
        public MyEmailTextEdit()
        {
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask = @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;
            //strong seçtik çünkü ok tuşu ile @ den sonra gelen kısma geçebiliyoruz.
            //diğer seçeneklerde bu özellik yok
           


        }
    }
}
