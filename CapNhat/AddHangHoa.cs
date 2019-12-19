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
    public partial class AddHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public AddHangHoa(tbl_KhachHanga obj)
        {
            InitializeComponent();
            tblHangHoaBindingSource.DataSource = obj;
        }

        public AddHangHoa(tbl_HangHoa ob)
        {
            this.ob = ob;
        }

        public tbl_HangHoa VDInfor { get { return tblHangHoaBindingSource.Current as tbl_HangHoa; } }
        private void IDHHTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private tbl_HangHoa ob;

        private void AddHangHoa_Load(object sender, EventArgs e)
        {
            
            tblHTVanCHuyenBindingSource.DataSource = ds.tbl_HTVanCHuyen.ToList();
            tblKhachHangaBindingSource.DataSource = ds.tbl_KhachHanga.ToList();
            tblPhanLoaiHHBindingSource.DataSource = ds.tbl_PhanLoaiHH.ToList();
            tblDongGoiHHBindingSource.DataSource = ds.tbl_DongGoiHH.ToList();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                tblHangHoaBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }
    }
}