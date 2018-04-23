Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication10
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint

		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			For i As Int64 = 0 To Int64.MaxValue - 1

				BackColor = Color.FromArgb(BackColor.R, BackColor.R, Convert.ToByte(i Mod 255))
				Refresh()
				Application.DoEvents()

			Next i
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			popupContainerEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			AddHandler popupContainerEdit1.Properties.Popup, AddressOf Properties_Popup
			AddHandler popupContainerEdit1.Properties.CloseUp, AddressOf Properties_CloseUp
		End Sub

		Private Sub Properties_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)
			TryCast(sender, TextEdit).SelectionStart = 0
			TryCast(sender, TextEdit).SelectionLength = (TryCast(sender, TextEdit)).Text.Length
		End Sub

		Private Sub Properties_Popup(ByVal sender As Object, ByVal e As EventArgs)
			memoEdit1.SelectAll()
		End Sub

		Private Sub popupContainerEdit1_Properties_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs) Handles popupContainerEdit1.Properties.QueryPopUp
			memoEdit1.Text = (TryCast(sender, TextEdit)).Text
		End Sub

		Private Sub popupContainerEdit1_Properties_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles popupContainerEdit1.Properties.QueryResultValue
			e.Value = memoEdit1.Text
		End Sub
	End Class
End Namespace
