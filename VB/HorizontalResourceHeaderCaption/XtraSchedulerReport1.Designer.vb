Imports Microsoft.VisualBasic
Imports System
Namespace HorizontalResourceHeaderCaption
	Partial Public Class WeeklyReport
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
			Me.horizontalWeek1 = New DevExpress.XtraScheduler.Reporting.HorizontalWeek()
			Me.reportWeekView1 = New DevExpress.XtraScheduler.Reporting.ReportWeekView()
			Me.dayOfWeekHeaders1 = New DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders()
			Me.verticalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders()
			Me.schedulerControlPrintAdapter1 = New DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter()
			CType(Me.reportWeekView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerControlPrintAdapter1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.timeIntervalInfo1, Me.dayOfWeekHeaders1, Me.verticalResourceHeaders1, Me.horizontalWeek1})
			Me.Detail.Height = 458
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' timeIntervalInfo1
			' 
			Me.timeIntervalInfo1.Location = New System.Drawing.Point(17, 8)
			Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
			Me.timeIntervalInfo1.Size = New System.Drawing.Size(475, 42)
			Me.timeIntervalInfo1.TimeCells = Me.horizontalWeek1
'			Me.timeIntervalInfo1.CustomizeText += New DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(Me.timeIntervalInfo1_CustomizeText);
			' 
			' horizontalWeek1
			' 
			Me.horizontalWeek1.Location = New System.Drawing.Point(100, 75)
			Me.horizontalWeek1.Name = "horizontalWeek1"
			Me.horizontalWeek1.Size = New System.Drawing.Size(433, 350)
			Me.horizontalWeek1.View = Me.reportWeekView1
			' 
			' reportWeekView1
			' 
			Me.reportWeekView1.Appearance.ResourceHeaderCaption.Options.UseTextOptions = True
			Me.reportWeekView1.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.reportWeekView1.VisibleResourceCount = 3
			Me.reportWeekView1.VisibleWeekCount = 3
			' 
			' dayOfWeekHeaders1
			' 
			Me.dayOfWeekHeaders1.Location = New System.Drawing.Point(100, 50)
			Me.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1"
			Me.dayOfWeekHeaders1.Size = New System.Drawing.Size(433, 25)
			Me.dayOfWeekHeaders1.TimeCells = Me.horizontalWeek1
			Me.dayOfWeekHeaders1.View = Me.reportWeekView1
			' 
			' verticalResourceHeaders1
			' 
			Me.verticalResourceHeaders1.Corners.Top = 24
			Me.verticalResourceHeaders1.Location = New System.Drawing.Point(17, 50)
			Me.verticalResourceHeaders1.Name = "verticalResourceHeaders1"
			Me.verticalResourceHeaders1.Size = New System.Drawing.Size(83, 375)
			Me.verticalResourceHeaders1.TimeCells = Me.horizontalWeek1
			Me.verticalResourceHeaders1.View = Me.reportWeekView1
'			Me.verticalResourceHeaders1.CustomDrawResourceHeader += New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(Me.verticalResourceHeaders1_CustomDrawResourceHeader);
			' 
			' schedulerControlPrintAdapter1
			' 
			Me.schedulerControlPrintAdapter1.TimeInterval.Duration = System.TimeSpan.Parse("31.00:00:00")
			Me.schedulerControlPrintAdapter1.TimeInterval.Start = New System.DateTime(2009, 7, 1, 0, 0, 0, 0)
			' 
			' WeeklyReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
			Me.SchedulerAdapter = Me.schedulerControlPrintAdapter1
			Me.Version = "9.1"
			Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() { Me.reportWeekView1})
			CType(Me.reportWeekView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerControlPrintAdapter1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private horizontalWeek1 As DevExpress.XtraScheduler.Reporting.HorizontalWeek
		Private reportWeekView1 As DevExpress.XtraScheduler.Reporting.ReportWeekView
		Private dayOfWeekHeaders1 As DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders
		Private WithEvents verticalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders
		Private schedulerControlPrintAdapter1 As DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter
		Private WithEvents timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
	End Class
End Namespace
