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
    public partial class AddHopDong : DevExpress.XtraEditors.XtraForm
    {
        public AddHopDong(tbl_HopDong obj)
        {
            InitializeComponent();
            tblHopDongBindingSource.DataSource = obj;
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        public tbl_HopDong VDInfor { get { return tblHopDongBindingSource.Current as tbl_HopDong; } }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tblHopDongBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void AddHopDong_Load(object sender, EventArgs e)
        {
            ds.tbl_KhachHanga.ToList();
            tblKhachHangaBindingSource.DataSource = ds.tbl_KhachHanga.Local;

            ds.tbl_HangHoa.ToList();
            tblHangHoaBindingSource.DataSource = ds.tbl_HangHoa.Local;

          
        }
    }
}