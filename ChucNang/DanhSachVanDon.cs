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
using System.Data.SqlClient;
using System.Configuration;
namespace KhoaLuanTotNghiep.ChucNang
{
    public partial class DanhSachVanDon : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachVanDon()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private void DanhSachVanDon_Load(object sender, EventArgs e)
        {
            tblDMVanDonBindingSource.DataSource = ds.tbl_DMVanDon.ToList();
            StartDate = DateTime.Now.Date.AddDays(-7);
            EndDate = DateTime.Now.Date;
        }
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
        private async void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (CapNhat.AddVanDon frm = new CapNhat.AddVanDon(new tbl_DMVanDon()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        tblDMVanDonBindingSource.Add(frm.VDInfor);
                        ds.tbl_DMVanDon.Add(frm.VDInfor);
                        await ds.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Message");
                    }
                }

            }
        }

        private async void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbl_DMVanDon obj = tblDMVanDonBindingSource.Current as tbl_DMVanDon;
            if (obj != null)
            {
                using (CapNhat.AddVanDon frm = new CapNhat.AddVanDon(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            tblDMVanDonBindingSource.EndEdit();
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

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            ds.tbl_DMVanDon.Remove(tblDMVanDonBindingSource.Current as tbl_DMVanDon);
            tblDMVanDonBindingSource.RemoveCurrent();
            ds.SaveChanges();
        }

        private void T_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh_Data(StartDate, EndDate);
        }
        private void Refresh_Data(DateTime dt1, DateTime dt2)
        {
            tblDMVanDonBindingSource.DataSource = ds.tbl_DMVanDon.Where(x => x.NgayKhoiHanh >= dt1.Date && x.NgayKhoiHanh <= dt2.Date).ToList();
        }

        private void btnVanDonThang_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Date.Year;
            int month = DateTime.Now.Date.Month;

            StartDate = new DateTime(year, month, 1);

            EndDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            Refresh_Data(StartDate, EndDate);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Excel File | *.xls";
                dlg.Title = "Save Excel";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    gridControl1.ExportToXls(dlg.FileName);
                }
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Report.Form_DanhSach_VanDon frm = new Report.Form_DanhSach_VanDon())
            {
                frm.ShowDialog();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Report.Form_VanDon_SEA frm = new Report.Form_VanDon_SEA())
            {
                frm.ShowDialog();
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Report.Form_VanDon_AIR frm = new Report.Form_VanDon_AIR())
            {
                frm.ShowDialog();
            }
        }

        private async void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbl_DMVanDon obj = tblDMVanDonBindingSource.Current as tbl_DMVanDon;
            if (obj != null)
            {
                using (CapNhat.AddVanDon frm = new CapNhat.AddVanDon(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            tblDMVanDonBindingSource.EndEdit();
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

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            StartDate = DateTime.Now.Date;
            EndDate = DateTime.Now.Date;

            Refresh_Data(StartDate, EndDate);
        }
    }
}