using System;
using DevExpress.XtraEditors.Drawing;

namespace WindowsApplication1
{
    public class MyPainter : PainterCheckedListBox
    {
        public MyPainter()
        {
            
        }

        protected override void DrawItemCore(ControlGraphicsInfoArgs info, DevExpress.XtraEditors.ViewInfo.BaseListBoxViewInfo.ItemInfo itemInfo, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e)
        {
            itemInfo.State = System.Windows.Forms.DrawItemState.None;
            ((DevExpress.XtraEditors.ViewInfo.CheckedListBoxViewInfo.CheckedItemInfo)(itemInfo)).CheckArgs.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            base.DrawItemCore(info, itemInfo, e);
        }
    }
}
