Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyRadioListBox
		Inherits CheckedListBoxControl
		Public Sub New()
			CheckOnClick = True
			SelectionMode = System.Windows.Forms.SelectionMode.None
		End Sub

		Protected Overrides Function CreatePainter() As BaseControlPainter
			Return New MyPainter()
		End Function

		Protected Overrides Sub SetItemCheckStateCore(ByVal index As Integer, ByVal value As System.Windows.Forms.CheckState)
			If value = System.Windows.Forms.CheckState.Checked Then
				UnCheckAll()
			End If
			MyBase.SetItemCheckStateCore(index, value)
		End Sub
	End Class
End Namespace
