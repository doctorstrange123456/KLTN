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
    public partial class DashBordTinhTrangVanDon : DevExpress.XtraEditors.XtraForm
    {
        public DashBordTinhTrangVanDon()
        {
            InitializeComponent();
            lstNhanSu = ds.tbl_DMVanDon.ToList();

            dashboardViewer1.Dashboard = new TinhTraangVanDon();

            dashboardViewer1.ReloadData();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        List<tbl_DMVanDon> lstNhanSu { get; set; }
    }
}