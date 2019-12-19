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
    public partial class AddKhoNoiBo : DevExpress.XtraEditors.XtraForm
    {
        public AddKhoNoiBo( tbl_KhachHanga obj)
        {
            InitializeComponent();
            tblKhachHangaBindingSource.DataSource = obj;
        }
        public tbl_KhachHanga KHInfor { get { return tblKhachHangaBindingSource.Current as tbl_KhachHanga; } }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tblKhachHangaBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void AddKhoNoiBo_Load(object sender, EventArgs e)
        {
            ds.tbl_QuocTich.ToList();
            tblQuocTichBindingSource.DataSource = ds.tbl_QuocTich.Local;

            ds.tbl_HangHoa.ToList();
            tblHangHoaBindingSource.DataSource = ds.tbl_HangHoa.Local;

            ds.tbl_ThanhToan.ToList();
            tblThanhToanBindingSource.DataSource = ds.tbl_ThanhToan.Local;
        }
    }
}