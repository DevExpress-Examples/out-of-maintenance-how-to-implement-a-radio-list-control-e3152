Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Drawing

Namespace WindowsApplication1
	Public Class MyPainter
		Inherits PainterCheckedListBox
		Public Sub New()

		End Sub

		Protected Overrides Sub DrawItemCore(ByVal info As ControlGraphicsInfoArgs, ByVal itemInfo As DevExpress.XtraEditors.ViewInfo.BaseListBoxViewInfo.ItemInfo, ByVal e As DevExpress.XtraEditors.ListBoxDrawItemEventArgs)
			itemInfo.State = System.Windows.Forms.DrawItemState.None
			CType(itemInfo, DevExpress.XtraEditors.ViewInfo.CheckedListBoxViewInfo.CheckedItemInfo).CheckArgs.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			MyBase.DrawItemCore(info, itemInfo, e)
		End Sub
	End Class
End Namespace
