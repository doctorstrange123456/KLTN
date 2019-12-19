using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KhoaLuanTotNghiep.Report
{
    public partial class MauHopDong : DevExpress.XtraEditors.XtraForm
    {
        public MauHopDong()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private void MauHopDong_Load(object sender, EventArgs e)
        {
            Report_MauHopDong rpt = new Report_MauHopDong();
            rpt.DataSource = ds.tbl_HopDong.ToList();

            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }
    }
}