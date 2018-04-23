using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraScheduler.Drawing;

namespace HorizontalResourceHeaderCaption {
    public partial class WeeklyReport : DevExpress.XtraScheduler.Reporting.XtraSchedulerReport {
        public WeeklyReport() {
            InitializeComponent();
            this.horizontalWeek1.VisibleWeekDays = DevExpress.XtraScheduler.WeekDays.WorkDays;
            this.reportWeekView1.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
        }

        private void timeIntervalInfo1_CustomizeText(object sender, TextCustomizingEventArgs e) {
            TimeIntervalTextCustomizingEventArgs args = (TimeIntervalTextCustomizingEventArgs)e;
            args.Text += args.SecondLineText;
            args.SecondLineText = string.Empty;
            
        }

        private void verticalResourceHeaders1_CustomDrawResourceHeader(object sender, DevExpress.XtraScheduler.CustomDrawObjectEventArgs e) {
            VerticalResourceHeader header = e.ObjectInfo as VerticalResourceHeader;
            if(header != null) {
                Rectangle r = e.Bounds;
                r.Inflate(- 2, - 2);
                string s = header.Caption;
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                e.DrawDefault();
                e.Cache.FillRectangle(header.Appearance.HeaderCaption.BackColor, r);
                e.Cache.DrawString(s, header.Appearance.HeaderCaption.Font, new SolidBrush(Color.Black), r, sf);
                e.Handled = true;
            }
        }
    }
}
