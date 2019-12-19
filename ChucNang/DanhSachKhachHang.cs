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
    public partial class DanhSachKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachKhachHang()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (CapNhat.AddKhachHang frm = new CapNhat.AddKhachHang(new tbl_KhachHanga()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        tblKhachHangaBindingSource.Add(frm.KHInfor);
                        ds.tbl_KhachHanga.Add(frm.KHInfor);
                        await ds.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message");
                    }
                }

            }
        }

        private async void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbl_KhachHanga obj = tblKhachHangaBindingSource.Current as tbl_KhachHanga;
            if (obj != null)
            {
                using (CapNhat.AddKhachHang frm = new CapNhat.AddKhachHang(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            tblKhachHangaBindingSource.EndEdit();
                            await ds.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("errorr");
                        }
                    }
                }
            }
        }

        private async void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ds.tbl_KhachHanga.Remove(tblKhachHangaBindingSource.Current as tbl_KhachHanga);
                tblKhachHangaBindingSource.RemoveCurrent();
                ds.SaveChanges();
        }

        private async void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    ShowAddress();
            //}
        }
        private void ShowAddress()
        {
            tbl_KhachHanga obj = tblKhachHangaBindingSource.Current as tbl_KhachHanga;
            if (obj != null)
            {
                if (obj.tbl_HangHoa != null)
                {
                    tblHangHoaBindingSource.DataSource = obj.tbl_HangHoa.ToList();
                }
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
           
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            hyperlinkLabelControl1.Visible = false;
            ds.Configuration.ProxyCreationEnabled = false;
            ds.Configuration.LazyLoadingEnabled = false;
            tblKhachHangaBindingSource.DataSource = ds.tbl_KhachHanga.Include("tbl_HangHoa").ToList();
            ShowAddress();
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

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbl_KhachHanga c = tblKhachHangaBindingSource.Current as tbl_KhachHanga;
            {
                if (c != null)
                {
                    if (tblHangHoaBindingSource.DataSource == null)
                        tblHangHoaBindingSource.DataSource = c.tbl_HangHoa.ToList();
                    tbl_HangHoa a = new tbl_HangHoa() { tbl_KhachHanga = c };
                    tblHangHoaBindingSource.Add(a);
                    ds.tbl_HangHoa.Add(a);
                }
            }
        }

        private async void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            hyperlinkLabelControl1.Visible = true;
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ds.tbl_HangHoa.Remove(tblHangHoaBindingSource.Current as tbl_HangHoa);
            tblHangHoaBindingSource.RemoveCurrent();
            ds.SaveChanges();
        }

        private async void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            tbl_KhachHanga obj = tblKhachHangaBindingSource.Current as tbl_KhachHanga;
            if (obj != null)
            {
                using (CapNhat.AddKhachHang frm = new CapNhat.AddKhachHang(obj))
                {
                    ribbonControl1.Visible = false;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            tblKhachHangaBindingSource.EndEdit();
                            await ds.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("errorr");
                        }
                    }
                }
            }
        }
        private void hesapla(int handle)
        {
            var ds = tblHangHoaBindingSource.List as IList<tbl_HangHoa>;
            var tinhtoan = ds[gridView1.GetDataSourceRowIndex(handle)];
            tinhtoan.ThanhTien = (tinhtoan.DonGia * tinhtoan.SoLuong*tinhtoan.TrongLuong) - (tinhtoan.DonGia * tinhtoan.SoLuong * tinhtoan.TrongLuong)*0.1;
           
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            this.hesapla(e.RowHandle);
            this.gridControl1.RefreshDataSource();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    tblKhachHangaBindingSource.DataSource = ds.tbl_KhachHanga.Include("tbl_HangHoa").ToList();
                    ShowAddress();
                }
                else
                {
                    var query = from o in ds.tbl_KhachHanga.Include("tbl_HangHoa")
                                where o.HoVaTen.Contains(textBox1.Text)
                                select o;
                    tblKhachHangaBindingSource.DataSource = query.ToList();
                    ShowAddress();

                }
            }
        }

        private void textBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowAddress();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}