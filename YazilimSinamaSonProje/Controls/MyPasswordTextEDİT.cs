﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace YazilimSinamaSonProje.Controls
{
    public class MyPasswordTextEDİT:MyTextEdit
    {
        public MyPasswordTextEDİT()
        {
            Properties.PasswordChar = '*';
        }
    }
}
