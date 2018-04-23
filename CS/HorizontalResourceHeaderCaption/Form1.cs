using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Reporting;

namespace HorizontalResourceHeaderCaption {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            Resource res1 = schedulerStorage1.CreateResource(1);
            res1.Caption = "Peter Dolan";
            Resource res2 = schedulerStorage1.CreateResource(2);
            res2.Caption = "Ryan Fischer";
            Resource res3 = schedulerStorage1.CreateResource(3);
            res3.Caption = "Andrew Miller";
            Resource res4 = schedulerStorage1.CreateResource(4);
            res4.Caption = "Tom Hamlett";
            Resource res5 = schedulerStorage1.CreateResource(5);
            res5.Caption = "Jerry Campbell";

            schedulerStorage1.Resources.AddRange(new Resource[] { res1, res2, res3, res4, res5 } );
        }
        private void button1_Click(object sender, EventArgs e) {
            CreateReport().ShowPreview();
        }

        private void button2_Click(object sender, EventArgs e) {
            CreateReport().ShowDesignerDialog();
        }
        WeeklyReport CreateReport() {
            WeeklyReport rpt = new WeeklyReport();
            rpt.SchedulerAdapter.SetSourceObject(this.schedulerControl1);
            return rpt;
        }
    }
}