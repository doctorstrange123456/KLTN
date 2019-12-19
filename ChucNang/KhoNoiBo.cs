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
    public partial class KhoNoiBo : DevExpress.XtraEditors.XtraForm
    {
        public KhoNoiBo()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        public DateTime Ngay { get; set; }
        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (CapNhat.AddKhoNoiBo frm = new CapNhat.AddKhoNoiBo(new tbl_KhachHanga()))
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
                using (CapNhat.AddKhoNoiBo frm = new CapNhat.AddKhoNoiBo(obj))
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
            try
            {
                await ds.SaveChangesAsync();
                //groupBox2.Enabled = false;

                XtraMessageBox.Show("Lưu dữ liệu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa thông tin khách hàng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ds.tbl_KhachHanga.Remove(tblKhachHangaBindingSource.Current as tbl_KhachHanga);
                tblKhachHangaBindingSource.RemoveCurrent();

            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    tblKhachHangaBindingSource.DataSource = ds.tbl_KhachHanga.Include("tbl_KhoNoiBo").ToList();
                    ShowAddress();
                }
                else
                {
                    var query = from o in ds.tbl_KhachHanga.Include("tbl_KhoNoiBo")
                                where o.HoVaTen.Contains(textBox1.Text)
                                select o;
                    tblKhachHangaBindingSource.DataSource = query.ToList();
                    ShowAddress();

                }
            }
        }

        private void KhoNoiBo_Load(object sender, EventArgs e)
        {

            ds.Configuration.ProxyCreationEnabled = false;
            ds.Configuration.LazyLoadingEnabled = false;
            tblKhachHangaBindingSource.DataSource = ds.tbl_KhachHanga.Include("tbl_KhoNoiBo").ToList();
            ShowAddress();
        }
        private void ShowAddress()
        {
            tbl_KhachHanga obj = tblKhachHangaBindingSource.Current as tbl_KhachHanga;
            if (obj != null)
            {
                if (obj.tbl_KhoNoiBo != null)
                {
                    tblKhoNoiBoBindingSource.DataSource = obj.tbl_KhoNoiBo.ToList();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowAddress();
            }
        }
        private void hesapla(int handle)
        {
            //var ds = bindingSource1.List as IList<tbl_KhoNoiBo>;
            //var hesaplanacak = ds[gridView1.GetDataSourceRowIndex(handle)];

            //hesaplanacak.ThanhTien = hesaplanacak.DonGia * hesaplanacak.SoLuong * hesaplanacak.SoNgay * hesaplanacak.TrongLuong;
            ////hesaplanacak.STT = ;

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //this.hesapla(e.RowHandle);
            //this.gridControl1.RefreshDataSource();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}