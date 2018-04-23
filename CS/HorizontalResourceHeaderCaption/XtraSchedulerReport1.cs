using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler.Reporting;

namespace HorizontalResourceHeaderCaption {
    public partial class WeeklyReport : DevExpress.XtraScheduler.Reporting.XtraSchedulerReport {
        public WeeklyReport() {
            InitializeComponent();
            this.horizontalWeek1.VisibleWeekDays = DevExpress.XtraScheduler.WeekDays.WorkDays;
            this.reportWeekView1.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
        }

        private void resourceInfo1_CustomizeText(object sender, DevExpress.XtraScheduler.Reporting.TextCustomizingEventArgs e) {
            ResourceTextCustomizingEventArgs args = (ResourceTextCustomizingEventArgs)e;
            int index = Convert.ToInt32(((ResourceInfo)sender).Tag);

            if (index >= 0 && index < args.Resources.Count)
                e.Text = args.Resources[index].Caption;
            else
                e.Text = string.Empty;
        }

        private void timeIntervalInfo1_CustomizeText(object sender, TextCustomizingEventArgs e) {
            TimeIntervalTextCustomizingEventArgs args = (TimeIntervalTextCustomizingEventArgs)e;
            args.Text += args.SecondLineText;
            args.SecondLineText = string.Empty;
            
        }
    }
}
