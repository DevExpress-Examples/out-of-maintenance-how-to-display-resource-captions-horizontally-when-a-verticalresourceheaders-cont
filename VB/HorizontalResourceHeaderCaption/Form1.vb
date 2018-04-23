Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Reporting

Namespace HorizontalResourceHeaderCaption
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			Dim res1 As Resource = schedulerStorage1.CreateResource(1)
			res1.Caption = "Peter Dolan"
			Dim res2 As Resource = schedulerStorage1.CreateResource(2)
			res2.Caption = "Ryan Fischer"
			Dim res3 As Resource = schedulerStorage1.CreateResource(3)
			res3.Caption = "Andrew Miller"
			Dim res4 As Resource = schedulerStorage1.CreateResource(4)
			res4.Caption = "Tom Hamlett"
			Dim res5 As Resource = schedulerStorage1.CreateResource(5)
			res5.Caption = "Jerry Campbell"

			schedulerStorage1.Resources.AddRange(New Resource() { res1, res2, res3, res4, res5 })
		End Sub
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			CreateReport().ShowPreview()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			CreateReport().ShowDesignerDialog()
		End Sub
		Private Function CreateReport() As WeeklyReport
			Dim rpt As New WeeklyReport()
			rpt.SchedulerAdapter.SetSourceObject(Me.schedulerControl1)
			Return rpt
		End Function
	End Class
End Namespace