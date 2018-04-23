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
			Me.resourceInfo5 = New DevExpress.XtraScheduler.Reporting.ResourceInfo()
			Me.horizontalWeek1 = New DevExpress.XtraScheduler.Reporting.HorizontalWeek()
			Me.reportWeekView1 = New DevExpress.XtraScheduler.Reporting.ReportWeekView()
			Me.resourceInfo4 = New DevExpress.XtraScheduler.Reporting.ResourceInfo()
			Me.resourceInfo3 = New DevExpress.XtraScheduler.Reporting.ResourceInfo()
			Me.resourceInfo2 = New DevExpress.XtraScheduler.Reporting.ResourceInfo()
			Me.resourceInfo1 = New DevExpress.XtraScheduler.Reporting.ResourceInfo()
			Me.dayOfWeekHeaders1 = New DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders()
			Me.verticalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders()
			Me.schedulerControlPrintAdapter1 = New DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter()
			Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
			CType(Me.reportWeekView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerControlPrintAdapter1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.timeIntervalInfo1, Me.resourceInfo5, Me.resourceInfo4, Me.resourceInfo3, Me.resourceInfo2, Me.resourceInfo1, Me.dayOfWeekHeaders1, Me.verticalResourceHeaders1, Me.horizontalWeek1})
			Me.Detail.Height = 451
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' resourceInfo5
			' 
			Me.resourceInfo5.AutoScaleFont = False
			Me.resourceInfo5.BorderColor = System.Drawing.SystemColors.AppWorkspace
			Me.resourceInfo5.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.resourceInfo5.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.resourceInfo5.Location = New System.Drawing.Point(0, 364)
			Me.resourceInfo5.Name = "resourceInfo5"
			Me.resourceInfo5.Size = New System.Drawing.Size(158, 70)
			Me.resourceInfo5.Tag = "4"
			Me.resourceInfo5.TimeCells = Me.horizontalWeek1
'			Me.resourceInfo5.CustomizeText += New DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(Me.resourceInfo1_CustomizeText);
			' 
			' horizontalWeek1
			' 
			Me.horizontalWeek1.Location = New System.Drawing.Point(158, 83)
			Me.horizontalWeek1.Name = "horizontalWeek1"
			Me.horizontalWeek1.Size = New System.Drawing.Size(433, 350)
			Me.horizontalWeek1.View = Me.reportWeekView1
			' 
			' reportWeekView1
			' 
			Me.reportWeekView1.Appearance.ResourceHeaderCaption.Options.UseTextOptions = True
			Me.reportWeekView1.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.reportWeekView1.VisibleResourceCount = 5
			' 
			' resourceInfo4
			' 
			Me.resourceInfo4.AutoScaleFont = False
			Me.resourceInfo4.BorderColor = System.Drawing.SystemColors.AppWorkspace
			Me.resourceInfo4.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.resourceInfo4.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.resourceInfo4.Location = New System.Drawing.Point(0, 294)
			Me.resourceInfo4.Name = "resourceInfo4"
			Me.resourceInfo4.Size = New System.Drawing.Size(158, 70)
			Me.resourceInfo4.Tag = "3"
			Me.resourceInfo4.TimeCells = Me.horizontalWeek1
'			Me.resourceInfo4.CustomizeText += New DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(Me.resourceInfo1_CustomizeText);
			' 
			' resourceInfo3
			' 
			Me.resourceInfo3.AutoScaleFont = False
			Me.resourceInfo3.BorderColor = System.Drawing.SystemColors.AppWorkspace
			Me.resourceInfo3.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.resourceInfo3.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.resourceInfo3.Location = New System.Drawing.Point(0, 224)
			Me.resourceInfo3.Name = "resourceInfo3"
			Me.resourceInfo3.Size = New System.Drawing.Size(158, 70)
			Me.resourceInfo3.Tag = "2"
			Me.resourceInfo3.TimeCells = Me.horizontalWeek1
'			Me.resourceInfo3.CustomizeText += New DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(Me.resourceInfo1_CustomizeText);
			' 
			' resourceInfo2
			' 
			Me.resourceInfo2.AutoScaleFont = False
			Me.resourceInfo2.BorderColor = System.Drawing.SystemColors.AppWorkspace
			Me.resourceInfo2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.resourceInfo2.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.resourceInfo2.Location = New System.Drawing.Point(0, 154)
			Me.resourceInfo2.Name = "resourceInfo2"
			Me.resourceInfo2.Size = New System.Drawing.Size(158, 70)
			Me.resourceInfo2.Tag = "1"
			Me.resourceInfo2.TimeCells = Me.horizontalWeek1
'			Me.resourceInfo2.CustomizeText += New DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(Me.resourceInfo1_CustomizeText);
			' 
			' resourceInfo1
			' 
			Me.resourceInfo1.AutoScaleFont = False
			Me.resourceInfo1.BorderColor = System.Drawing.SystemColors.AppWorkspace
			Me.resourceInfo1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.resourceInfo1.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.resourceInfo1.Location = New System.Drawing.Point(0, 84)
			Me.resourceInfo1.Name = "resourceInfo1"
			Me.resourceInfo1.Size = New System.Drawing.Size(158, 70)
			Me.resourceInfo1.Tag = "0"
			Me.resourceInfo1.TimeCells = Me.horizontalWeek1
'			Me.resourceInfo1.CustomizeText += New DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(Me.resourceInfo1_CustomizeText);
			' 
			' dayOfWeekHeaders1
			' 
			Me.dayOfWeekHeaders1.Location = New System.Drawing.Point(158, 58)
			Me.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1"
			Me.dayOfWeekHeaders1.Size = New System.Drawing.Size(433, 25)
			Me.dayOfWeekHeaders1.TimeCells = Me.horizontalWeek1
			Me.dayOfWeekHeaders1.View = Me.reportWeekView1
			' 
			' verticalResourceHeaders1
			' 
			Me.verticalResourceHeaders1.Corners.Top = 24
			Me.verticalResourceHeaders1.Location = New System.Drawing.Point(591, 58)
			Me.verticalResourceHeaders1.Name = "verticalResourceHeaders1"
			Me.verticalResourceHeaders1.Size = New System.Drawing.Size(50, 375)
			Me.verticalResourceHeaders1.TimeCells = Me.horizontalWeek1
			Me.verticalResourceHeaders1.View = Me.reportWeekView1
			' 
			' schedulerControlPrintAdapter1
			' 
			Me.schedulerControlPrintAdapter1.TimeInterval.Duration = System.TimeSpan.Parse("31.00:00:00")
			Me.schedulerControlPrintAdapter1.TimeInterval.Start = New System.DateTime(2009, 7, 1, 0, 0, 0, 0)
			' 
			' timeIntervalInfo1
			' 
			Me.timeIntervalInfo1.Location = New System.Drawing.Point(158, 8)
			Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
			Me.timeIntervalInfo1.Size = New System.Drawing.Size(475, 42)
			Me.timeIntervalInfo1.TimeCells = Me.horizontalWeek1
'			Me.timeIntervalInfo1.CustomizeText += New DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(Me.timeIntervalInfo1_CustomizeText);
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
		Private WithEvents resourceInfo1 As DevExpress.XtraScheduler.Reporting.ResourceInfo
		Private dayOfWeekHeaders1 As DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders
		Private verticalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders
		Private schedulerControlPrintAdapter1 As DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter
		Private WithEvents resourceInfo5 As DevExpress.XtraScheduler.Reporting.ResourceInfo
		Private WithEvents resourceInfo4 As DevExpress.XtraScheduler.Reporting.ResourceInfo
		Private WithEvents resourceInfo3 As DevExpress.XtraScheduler.Reporting.ResourceInfo
		Private WithEvents resourceInfo2 As DevExpress.XtraScheduler.Reporting.ResourceInfo
		Private WithEvents timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
	End Class
End Namespace
