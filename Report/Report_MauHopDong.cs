using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace KhoaLuanTotNghiep.Report
{
    public partial class Report_MauHopDong : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_MauHopDong()
        {
            InitializeComponent();
            xrLabel45.Text = DateTime.Now.ToString("dddd, d MMMM,yyyy");
        }

    }
}
