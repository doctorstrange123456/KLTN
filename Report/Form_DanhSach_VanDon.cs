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
    public partial class Form_DanhSach_VanDon : DevExpress.XtraEditors.XtraForm
    {
        public Form_DanhSach_VanDon()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();

        private void Form_DanhSach_VanDon_Load(object sender, EventArgs e)
        {
            ReportVanDon rpt = new ReportVanDon();
            rpt.DataSource = ds.tbl_DMVanDon.ToList();

            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }
    }
}