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
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            this.horizontalWeek1 = new DevExpress.XtraScheduler.Reporting.HorizontalWeek();
            this.reportWeekView1 = new DevExpress.XtraScheduler.Reporting.ReportWeekView();
            this.dayOfWeekHeaders1 = new DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders();
            this.verticalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders();
            this.schedulerControlPrintAdapter1 = new DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControlPrintAdapter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.timeIntervalInfo1,
            this.dayOfWeekHeaders1,
            this.verticalResourceHeaders1,
            this.horizontalWeek1});
            this.Detail.Height = 458;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.Location = new System.Drawing.Point(17, 8);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.Size = new System.Drawing.Size(475, 42);
            this.timeIntervalInfo1.TimeCells = this.horizontalWeek1;
            this.timeIntervalInfo1.CustomizeText += new DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(this.timeIntervalInfo1_CustomizeText);
            // 
            // horizontalWeek1
            // 
            this.horizontalWeek1.Location = new System.Drawing.Point(100, 75);
            this.horizontalWeek1.Name = "horizontalWeek1";
            this.horizontalWeek1.Size = new System.Drawing.Size(433, 350);
            this.horizontalWeek1.View = this.reportWeekView1;
            // 
            // reportWeekView1
            // 
            this.reportWeekView1.Appearance.ResourceHeaderCaption.Options.UseTextOptions = true;
            this.reportWeekView1.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.reportWeekView1.VisibleResourceCount = 3;
            this.reportWeekView1.VisibleWeekCount = 3;
            // 
            // dayOfWeekHeaders1
            // 
            this.dayOfWeekHeaders1.Location = new System.Drawing.Point(100, 50);
            this.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1";
            this.dayOfWeekHeaders1.Size = new System.Drawing.Size(433, 25);
            this.dayOfWeekHeaders1.TimeCells = this.horizontalWeek1;
            this.dayOfWeekHeaders1.View = this.reportWeekView1;
            // 
            // verticalResourceHeaders1
            // 
            this.verticalResourceHeaders1.Corners.Top = 24;
            this.verticalResourceHeaders1.Location = new System.Drawing.Point(17, 50);
            this.verticalResourceHeaders1.Name = "verticalResourceHeaders1";
            this.verticalResourceHeaders1.Size = new System.Drawing.Size(83, 375);
            this.verticalResourceHeaders1.TimeCells = this.horizontalWeek1;
            this.verticalResourceHeaders1.View = this.reportWeekView1;
            this.verticalResourceHeaders1.CustomDrawResourceHeader += new DevExpress.XtraScheduler.CustomDrawObjectEventHandler(this.verticalResourceHeaders1_CustomDrawResourceHeader);
            // 
            // schedulerControlPrintAdapter1
            // 
            this.schedulerControlPrintAdapter1.TimeInterval.Duration = System.TimeSpan.Parse("31.00:00:00");
            this.schedulerControlPrintAdapter1.TimeInterval.Start = new System.DateTime(2009, 7, 1, 0, 0, 0, 0);
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
        private DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders dayOfWeekHeaders1;
        private DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders verticalResourceHeaders1;
        private DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter schedulerControlPrintAdapter1;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;
    }
}
