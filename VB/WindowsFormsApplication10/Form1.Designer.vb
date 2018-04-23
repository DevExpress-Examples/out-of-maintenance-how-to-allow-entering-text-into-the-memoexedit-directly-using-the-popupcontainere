Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication10
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.popupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
			Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupContainerControl1.SuspendLayout()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' popupContainerEdit1
			' 
			Me.popupContainerEdit1.Location = New System.Drawing.Point(53, 65)
			Me.popupContainerEdit1.Name = "popupContainerEdit1"
			Me.popupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.popupContainerEdit1.Properties.PopupControl = Me.popupContainerControl1
'			Me.popupContainerEdit1.Properties.QueryResultValue += New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(Me.popupContainerEdit1_Properties_QueryResultValue);
'			Me.popupContainerEdit1.Properties.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.popupContainerEdit1_Properties_QueryPopUp);
			Me.popupContainerEdit1.Size = New System.Drawing.Size(249, 20)
			Me.popupContainerEdit1.TabIndex = 0
			' 
			' popupContainerControl1
			' 
			Me.popupContainerControl1.Controls.Add(Me.memoEdit1)
			Me.popupContainerControl1.Location = New System.Drawing.Point(53, 101)
			Me.popupContainerControl1.Name = "popupContainerControl1"
			Me.popupContainerControl1.Size = New System.Drawing.Size(338, 191)
			Me.popupContainerControl1.TabIndex = 1
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.memoEdit1.Location = New System.Drawing.Point(0, 0)
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(338, 191)
			Me.memoEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(632, 434)
			Me.Controls.Add(Me.popupContainerControl1)
			Me.Controls.Add(Me.popupContainerEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
'			Me.Paint += New System.Windows.Forms.PaintEventHandler(Me.Form1_Paint);
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupContainerControl1.ResumeLayout(False)
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents popupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
		Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

	End Class
End Namespace

