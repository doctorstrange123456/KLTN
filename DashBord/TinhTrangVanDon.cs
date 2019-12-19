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

namespace KhoaLuanTotNghiep.DashBord
{
    public partial class TinhTrangVanDon : DevExpress.XtraEditors.XtraForm
    {
        public TinhTrangVanDon()
        {
            InitializeComponent();
            lstNhanSu = ds.tbl_HopDong.ToList();

            dashboardViewer1.Dashboard = new VanDon();

            dashboardViewer1.ReloadData();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        List<tbl_HopDong> lstNhanSu { get; set; }
        private void TinhTrangVanDon_Load(object sender, EventArgs e)
        {
            //VanDon rpt = new VanDon();
            
            //dashboardViewer1.DashboardSource = rpt;
            //dashboardViewer1.ReloadData() ;
            

        }
    }
}