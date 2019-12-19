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
    public partial class frmHopDong : DevExpress.XtraEditors.XtraForm
    {
        public frmHopDong()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private List<tbl_DMVanDon> ListVanDon { get; set; }
        private DateTime StartDate
        {
            get => DateTime.Parse(DateFrom.EditValue.ToString());
            set => DateFrom.EditValue = value;
        }
        private DateTime EndDate
        {
            get => DateTime.Parse(DateTo.EditValue.ToString());
            set => DateTo.EditValue = value;
        }
        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (CapNhat.AddHopDong frm = new CapNhat.AddHopDong(new tbl_HopDong()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        tblHopDongBindingSource.Add(frm.VDInfor);
                        ds.tbl_HopDong.Add(frm.VDInfor);
                        await ds.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Message");
                    }
                }

            }
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            tblHopDongBindingSource.DataSource = ds.tbl_HopDong.ToList();
            StartDate = DateTime.Now.Date.AddDays(-7);
            EndDate = DateTime.Now.Date;
        }

        private async void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbl_HopDong obj = tblHopDongBindingSource.Current as tbl_HopDong;
            if (obj != null)
            {
                using (CapNhat.AddHopDong frm = new CapNhat.AddHopDong(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            tblHopDongBindingSource.EndEdit();
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

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ds.tbl_HopDong.Remove(tblHopDongBindingSource.Current as tbl_HopDong);
            tblHopDongBindingSource.RemoveCurrent();
            ds.SaveChanges();
        }

        private async void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                await ds.SaveChangesAsync();

                XtraMessageBox.Show("Lưu dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Refresh_Data(DateTime dt1, DateTime dt2)
        {
            tblHopDongBindingSource.DataSource = ds.tbl_HopDong.Where(x => x.NgayKy >= dt1.Date && x.NgayKy <= dt2.Date).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh_Data(StartDate, EndDate);
        }

        private void btnVanDonThang_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Date.Year;
            int month = DateTime.Now.Date.Month;

            StartDate = new DateTime(year, month, 1);

            EndDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            Refresh_Data(StartDate, EndDate);
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Report.FormHopDong frm = new Report.FormHopDong())
            {
                frm.ShowDialog();
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            this.hesapla(e.RowHandle);
            this.gridControl1.RefreshDataSource();
        }
        private void hesapla(int handle)
        {
            var ds = tblHopDongBindingSource.List as IList<tbl_HopDong>;
            var tinhtoan = ds[gridView1.GetDataSourceRowIndex(handle)];
            tinhtoan.ChiPhiConLai = tinhtoan.ChiPhi - tinhtoan.ChiPhiNop;

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Report.MauHopDong frm = new Report.MauHopDong())
            {
                frm.ShowDialog();
            }
        }
    }
}