namespace HorizontalResourceHeaderCaption {
    partial class WeeklyReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.resourceInfo5 = new DevExpress.XtraScheduler.Reporting.ResourceInfo();
            this.horizontalWeek1 = new DevExpress.XtraScheduler.Reporting.HorizontalWeek();
            this.reportWeekView1 = new DevExpress.XtraScheduler.Reporting.ReportWeekView();
            this.resourceInfo4 = new DevExpress.XtraScheduler.Reporting.ResourceInfo();
            this.resourceInfo3 = new DevExpress.XtraScheduler.Reporting.ResourceInfo();
            this.resourceInfo2 = new DevExpress.XtraScheduler.Reporting.ResourceInfo();
            this.resourceInfo1 = new DevExpress.XtraScheduler.Reporting.ResourceInfo();
            this.dayOfWeekHeaders1 = new DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders();
            this.verticalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders();
            this.schedulerControlPrintAdapter1 = new DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter();
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControlPrintAdapter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.timeIntervalInfo1,
            this.resourceInfo5,
            this.resourceInfo4,
            this.resourceInfo3,
            this.resourceInfo2,
            this.resourceInfo1,
            this.dayOfWeekHeaders1,
            this.verticalResourceHeaders1,
            this.horizontalWeek1});
            this.Detail.Height = 451;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // resourceInfo5
            // 
            this.resourceInfo5.AutoScaleFont = false;
            this.resourceInfo5.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.resourceInfo5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.resourceInfo5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.resourceInfo5.Location = new System.Drawing.Point(0, 364);
            this.resourceInfo5.Name = "resourceInfo5";
            this.resourceInfo5.Size = new System.Drawing.Size(158, 70);
            this.resourceInfo5.Tag = "4";
            this.resourceInfo5.TimeCells = this.horizontalWeek1;
            this.resourceInfo5.CustomizeText += new DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(this.resourceInfo1_CustomizeText);
            // 
            // horizontalWeek1
            // 
            this.horizontalWeek1.Location = new System.Drawing.Point(158, 83);
            this.horizontalWeek1.Name = "horizontalWeek1";
            this.horizontalWeek1.Size = new System.Drawing.Size(433, 350);
            this.horizontalWeek1.View = this.reportWeekView1;
            // 
            // reportWeekView1
            // 
            this.reportWeekView1.Appearance.ResourceHeaderCaption.Options.UseTextOptions = true;
            this.reportWeekView1.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.reportWeekView1.VisibleResourceCount = 5;
            // 
            // resourceInfo4
            // 
            this.resourceInfo4.AutoScaleFont = false;
            this.resourceInfo4.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.resourceInfo4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.resourceInfo4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.resourceInfo4.Location = new System.Drawing.Point(0, 294);
            this.resourceInfo4.Name = "resourceInfo4";
            this.resourceInfo4.Size = new System.Drawing.Size(158, 70);
            this.resourceInfo4.Tag = "3";
            this.resourceInfo4.TimeCells = this.horizontalWeek1;
            this.resourceInfo4.CustomizeText += new DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(this.resourceInfo1_CustomizeText);
            // 
            // resourceInfo3
            // 
            this.resourceInfo3.AutoScaleFont = false;
            this.resourceInfo3.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.resourceInfo3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.resourceInfo3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.resourceInfo3.Location = new System.Drawing.Point(0, 224);
            this.resourceInfo3.Name = "resourceInfo3";
            this.resourceInfo3.Size = new System.Drawing.Size(158, 70);
            this.resourceInfo3.Tag = "2";
            this.resourceInfo3.TimeCells = this.horizontalWeek1;
            this.resourceInfo3.CustomizeText += new DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(this.resourceInfo1_CustomizeText);
            // 
            // resourceInfo2
            // 
            this.resourceInfo2.AutoScaleFont = false;
            this.resourceInfo2.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.resourceInfo2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.resourceInfo2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.resourceInfo2.Location = new System.Drawing.Point(0, 154);
            this.resourceInfo2.Name = "resourceInfo2";
            this.resourceInfo2.Size = new System.Drawing.Size(158, 70);
            this.resourceInfo2.Tag = "1";
            this.resourceInfo2.TimeCells = this.horizontalWeek1;
            this.resourceInfo2.CustomizeText += new DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(this.resourceInfo1_CustomizeText);
            // 
            // resourceInfo1
            // 
            this.resourceInfo1.AutoScaleFont = false;
            this.resourceInfo1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.resourceInfo1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.resourceInfo1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.resourceInfo1.Location = new System.Drawing.Point(0, 84);
            this.resourceInfo1.Name = "resourceInfo1";
            this.resourceInfo1.Size = new System.Drawing.Size(158, 70);
            this.resourceInfo1.Tag = "0";
            this.resourceInfo1.TimeCells = this.horizontalWeek1;
            this.resourceInfo1.CustomizeText += new DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(this.resourceInfo1_CustomizeText);
            // 
            // dayOfWeekHeaders1
            // 
            this.dayOfWeekHeaders1.Location = new System.Drawing.Point(158, 58);
            this.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1";
            this.dayOfWeekHeaders1.Size = new System.Drawing.Size(433, 25);
            this.dayOfWeekHeaders1.TimeCells = this.horizontalWeek1;
            this.dayOfWeekHeaders1.View = this.reportWeekView1;
            // 
            // verticalResourceHeaders1
            // 
            this.verticalResourceHeaders1.Corners.Top = 24;
            this.verticalResourceHeaders1.Location = new System.Drawing.Point(591, 58);
            this.verticalResourceHeaders1.Name = "verticalResourceHeaders1";
            this.verticalResourceHeaders1.Size = new System.Drawing.Size(50, 375);
            this.verticalResourceHeaders1.TimeCells = this.horizontalWeek1;
            this.verticalResourceHeaders1.View = this.reportWeekView1;
            // 
            // schedulerControlPrintAdapter1
            // 
            this.schedulerControlPrintAdapter1.TimeInterval.Duration = System.TimeSpan.Parse("31.00:00:00");
            this.schedulerControlPrintAdapter1.TimeInterval.Start = new System.DateTime(2009, 7, 1, 0, 0, 0, 0);
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.Location = new System.Drawing.Point(158, 8);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.Size = new System.Drawing.Size(475, 42);
            this.timeIntervalInfo1.TimeCells = this.horizontalWeek1;
            this.timeIntervalInfo1.CustomizeText += new DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(this.timeIntervalInfo1_CustomizeText);
            // 
            // WeeklyReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.SchedulerAdapter = this.schedulerControlPrintAdapter1;
            this.Version = "9.1";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportWeekView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControlPrintAdapter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraScheduler.Reporting.HorizontalWeek horizontalWeek1;
        private DevExpress.XtraScheduler.Reporting.ReportWeekView reportWeekView1;
        private DevExpress.XtraScheduler.Reporting.ResourceInfo resourceInfo1;
        private DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders dayOfWeekHeaders1;
        private DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders verticalResourceHeaders1;
        private DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter schedulerControlPrintAdapter1;
        private DevExpress.XtraScheduler.Reporting.ResourceInfo resourceInfo5;
        private DevExpress.XtraScheduler.Reporting.ResourceInfo resourceInfo4;
        private DevExpress.XtraScheduler.Reporting.ResourceInfo resourceInfo3;
        private DevExpress.XtraScheduler.Reporting.ResourceInfo resourceInfo2;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;
    }
}
