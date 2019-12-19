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
    public partial class ThongTinHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinHangHoa(tbl_HangHoa obj)
        {
            InitializeComponent();
            tblHangHoaBindingSource.DataSource = obj;


        }
        public tbl_HangHoa VDInfor { get { return tblHangHoaBindingSource.Current as tbl_HangHoa; } }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                tblHangHoaBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }
    }
}