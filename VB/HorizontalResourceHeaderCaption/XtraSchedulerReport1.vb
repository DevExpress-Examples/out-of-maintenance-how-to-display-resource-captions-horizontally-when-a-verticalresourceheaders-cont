Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler.Drawing

Namespace HorizontalResourceHeaderCaption
	Partial Public Class WeeklyReport
		Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport
		Public Sub New()
			InitializeComponent()
			Me.horizontalWeek1.VisibleWeekDays = DevExpress.XtraScheduler.WeekDays.WorkDays
			Me.reportWeekView1.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		End Sub

		Private Sub timeIntervalInfo1_CustomizeText(ByVal sender As Object, ByVal e As TextCustomizingEventArgs) Handles timeIntervalInfo1.CustomizeText
			Dim args As TimeIntervalTextCustomizingEventArgs = CType(e, TimeIntervalTextCustomizingEventArgs)
			args.Text += args.SecondLineText
			args.SecondLineText = String.Empty

		End Sub

		Private Sub verticalResourceHeaders1_CustomDrawResourceHeader(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs) Handles verticalResourceHeaders1.CustomDrawResourceHeader
			Dim header As VerticalResourceHeader = TryCast(e.ObjectInfo, VerticalResourceHeader)
			If header IsNot Nothing Then
				Dim r As Rectangle = e.Bounds
				r.Inflate(- 2, - 2)
				Dim s As String = header.Caption
				Dim sf As New StringFormat()
				sf.LineAlignment = StringAlignment.Center
				sf.Alignment = StringAlignment.Center
				e.DrawDefault()
				e.Cache.FillRectangle(header.Appearance.HeaderCaption.BackColor, r)
				e.Cache.DrawString(s, header.Appearance.HeaderCaption.Font, New SolidBrush(Color.Black), r, sf)
				e.Handled = True
			End If
		End Sub
	End Class
End Namespace
