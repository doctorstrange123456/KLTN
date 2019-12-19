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
    public partial class AddaiLy : DevExpress.XtraEditors.XtraForm
    {
        public AddaiLy(tbl_DaiLi obj)
        {
            InitializeComponent();
            tblDaiLiBindingSource.DataSource = obj;
        }
        public tbl_DaiLi VDInfor { get { return tblDaiLiBindingSource.Current as tbl_DaiLi; } }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                tblDaiLiBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddaiLy_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}