using DevExpress.XtraDataLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraToolbox;

namespace YazilimSinamaSonProje.Controls
{
  
        [ToolboxItem(true)]
        public class MyDataLayoutControl : DataLayoutControl
        {
            public MyDataLayoutControl()
            {
                OptionsFocus.EnableAutoTabOrder = false;
                //normalde datalayout kendi düzenine göre bileşenleri sıralar
                //burda bunu değiştirerek kontrolü kendimiz belirliyebiliriz

            }

            protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
            {
                return new MyLayoutControlImplementor(this);
            }
        }

        internal class MyLayoutControlImplementor : LayoutControlImplementor
        {
            public MyLayoutControlImplementor(ILayoutControlOwner owner) : base(owner)
            {
            }

            public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
            {
                var item = base.CreateLayoutItem(parent);
                item.AppearanceItemCaption.ForeColor = Color.Maroon;
                return item;
                //caption renklerini değiştirdik}
            }
            public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
            {
                var grp = base.CreateLayoutGroup(parent);
                grp.LayoutMode = LayoutMode.Table;
                //tableLayout olarak değiştirdik(2 sütun 2 satır kare şeklinde)
                grp.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;
                //absolute sabit demek
                grp.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 300;
                grp.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
                //kolonu yüzde olarak ayarladık
                grp.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 200;
                grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 99 });
                //yeni kolon ekledik

                grp.OptionsTableLayoutGroup.RowDefinitions.Clear();
                for (int i = 0; i < 7; i++)
                {
                    grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                    {
                        SizeType = SizeType.Absolute,
                        Height = 50,

                    });
                   


                }


                return grp;
            }
        }
    
}
