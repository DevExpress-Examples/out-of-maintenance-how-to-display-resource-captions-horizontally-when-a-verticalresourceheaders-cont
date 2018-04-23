Imports Microsoft.VisualBasic
Imports System
Namespace HorizontalResourceHeaderCaption
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
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(12, 8)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(130, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Show Preview"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(148, 8)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(130, 23)
			Me.button2.TabIndex = 2
			Me.button2.Text = "Show User Designer"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Date
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 37)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.OptionsView.ResourceHeaders.Height = 200
			Me.schedulerControl1.OptionsView.ResourceHeaders.RotateCaption = False
			Me.schedulerControl1.Size = New System.Drawing.Size(748, 446)
			Me.schedulerControl1.Start = New System.DateTime(2009, 6, 29, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 3
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.MonthView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never
			Me.schedulerControl1.Views.MonthView.ShowWeekend = False
			Me.schedulerControl1.Views.MonthView.WeekCount = 1
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(748, 483)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "How to display resource captions horizontally when a VerticalResourceHeaders cont" & "rol is used"
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
	End Class
End Namespace

