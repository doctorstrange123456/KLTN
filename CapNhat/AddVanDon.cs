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

namespace KhoaLuanTotNghiep.CapNhat
{
    public partial class AddVanDon : DevExpress.XtraEditors.XtraForm
    {
        public AddVanDon(tbl_DMVanDon obj)
        {
            InitializeComponent();
            tblDMVanDonBindingSource.DataSource = obj;
        }
        public tbl_DMVanDon VDInfor { get { return tblDMVanDonBindingSource.Current as tbl_DMVanDon; } }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void AddVanDon_Load(object sender, EventArgs e)
        {
            TinhTrangVanDonTextEdit.Properties.DataSource = ds.tbl_TinhTrangVanDon.ToList();
            //tblTinhTrangVanDonBindingSource.DataSource = ds.tbl_TinhTrangVanDon.ToList();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                tblDMVanDonBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }
    }
}