Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraScheduler.Reporting

Namespace HorizontalResourceHeaderCaption
	Partial Public Class WeeklyReport
		Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport
		Public Sub New()
			InitializeComponent()
			Me.horizontalWeek1.VisibleWeekDays = DevExpress.XtraScheduler.WeekDays.WorkDays
			Me.reportWeekView1.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		End Sub

		Private Sub resourceInfo1_CustomizeText(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.Reporting.TextCustomizingEventArgs) Handles resourceInfo5.CustomizeText, resourceInfo4.CustomizeText, resourceInfo3.CustomizeText, resourceInfo2.CustomizeText, resourceInfo1.CustomizeText
			Dim args As ResourceTextCustomizingEventArgs = CType(e, ResourceTextCustomizingEventArgs)
			Dim index As Integer = Convert.ToInt32((CType(sender, ResourceInfo)).Tag)

			If index >= 0 AndAlso index < args.Resources.Count Then
				e.Text = args.Resources(index).Caption
			Else
				e.Text = String.Empty
			End If
		End Sub

		Private Sub timeIntervalInfo1_CustomizeText(ByVal sender As Object, ByVal e As TextCustomizingEventArgs) Handles timeIntervalInfo1.CustomizeText
			Dim args As TimeIntervalTextCustomizingEventArgs = CType(e, TimeIntervalTextCustomizingEventArgs)
			args.Text += args.SecondLineText
			args.SecondLineText = String.Empty

		End Sub
	End Class
End Namespace
