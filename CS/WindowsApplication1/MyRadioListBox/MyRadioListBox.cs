using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]
    public class MyRadioListBox : CheckedListBoxControl
    {
        public MyRadioListBox()
        {
            CheckOnClick = true;
            SelectionMode = System.Windows.Forms.SelectionMode.None;
        }

        protected override BaseControlPainter CreatePainter()
        {
            return new MyPainter();
        }

        protected override void SetItemCheckStateCore(int index, System.Windows.Forms.CheckState value)
        {
            if (value == System.Windows.Forms.CheckState.Checked)
                UnCheckAll();
            base.SetItemCheckStateCore(index, value);
        }
    }
}
