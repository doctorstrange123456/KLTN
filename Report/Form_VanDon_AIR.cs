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
    public partial class Form_VanDon_AIR : DevExpress.XtraEditors.XtraForm
    {
        public Form_VanDon_AIR()
        {
            InitializeComponent();
            
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();

        private void Form_VanDon_AIR_Load(object sender, EventArgs e)
        {
            Report_VanDon_Air rpt = new Report_VanDon_Air();
            rpt.DataSource = ds.tbl_DMVanDon.ToList();

            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }
    }
}