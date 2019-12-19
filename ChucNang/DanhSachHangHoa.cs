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

namespace KhoaLuanTotNghiep.ChucNang
{
    public partial class DanhSachHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachHangHoa()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbl_HangHoa ob = tblHangHoaBindingSource.Current as tbl_HangHoa;
            if (ob != null)
            {
                using (CapNhat.ThongTinHangHoa frm = new CapNhat.ThongTinHangHoa(ob))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            tblHangHoaBindingSource.EndEdit();
                            await ds.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.Message, "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void DanhSachHangHoa_Load(object sender, EventArgs e)
        {
            tblHangHoaBindingSource.DataSource = ds.tbl_HangHoa.ToList();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Report.FormHangHoa frm = new Report.FormHangHoa())
            {
                frm.ShowDialog();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}