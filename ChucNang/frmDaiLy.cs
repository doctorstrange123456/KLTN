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
    public partial class frmDaiLy : DevExpress.XtraEditors.XtraForm
    {
        public frmDaiLy()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private async void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (CapNhat.AddaiLy frm = new CapNhat.AddaiLy(new tbl_DaiLi()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {


                        tblDaiLiBindingSource.Add(frm.VDInfor);
                        ds.tbl_DaiLi.Add(frm.VDInfor);
                        await ds.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Message");
                    }
                }

            }
        }

        private async void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbl_DaiLi obj = tblDaiLiBindingSource.Current as tbl_DaiLi;
            if (obj != null)
            {
                using (CapNhat.AddaiLy frm = new CapNhat.AddaiLy(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            tblDaiLiBindingSource.EndEdit();
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

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                ds.tbl_DaiLi.Remove(tblDaiLiBindingSource.Current as tbl_DaiLi);
                tblDaiLiBindingSource.RemoveCurrent();
                ds.SaveChanges();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Excel File | *.xls";
                dlg.Title = "Save Excel";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    gridControl1.ExportToXls(dlg.FileName);
                }
            }
        }

        private void frmDaiLy_Load(object sender, EventArgs e)
        {
            tblDaiLiBindingSource.DataSource = ds.tbl_DaiLi.ToList();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}