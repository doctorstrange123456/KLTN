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

namespace KhoaLuanTotNghiep.DanhSachTable
{
    public partial class DanhSachUser : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachUser()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void DanhSachUser_Load(object sender, EventArgs e)
        {
            tblLoginBindingSource.DataSource = ds.tbl_Login.ToList();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ds.SaveChanges();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tblLoginBindingSource.EndEdit();
            ds.SaveChanges();
        }
    }
}