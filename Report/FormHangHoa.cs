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
    public partial class FormHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();

        private void Form_DanhSach_VanDon_Load(object sender, EventArgs e)
        {
            ReportHangHoa rpt = new ReportHangHoa();
            rpt.DataSource = ds.tbl_HangHoa.ToList();

            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            ReportHangHoa rpt = new ReportHangHoa();
            rpt.DataSource = ds.tbl_HangHoa.ToList();

            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }
    }
}