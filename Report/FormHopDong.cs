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
    public partial class FormHopDong : DevExpress.XtraEditors.XtraForm
    {
        public FormHopDong()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private void FormHopDong_Load(object sender, EventArgs e)
        {
            Report_HopDong rpt = new Report_HopDong();
            rpt.DataSource = ds.tbl_HopDong.ToList();

            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }
    }
}