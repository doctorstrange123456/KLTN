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
    public partial class VanChuyenNoiBo : DevExpress.XtraEditors.XtraForm
    {
        public VanChuyenNoiBo()
        {
            InitializeComponent();
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private void VanChuyenNoiBo_Load(object sender, EventArgs e)
        {
            ds.Configuration.ProxyCreationEnabled = false;
            ds.Configuration.LazyLoadingEnabled = false;
            tblKhachHangaBindingSource.DataSource = ds.tbl_KhachHanga.Include("tbl_DichVuVCNB").ToList();
            ShowAddress();
        }
        private void ShowAddress()
        {
            tbl_KhachHanga obj = tblKhachHangaBindingSource.Current as tbl_KhachHanga;
            if (obj != null)
            {
                if (obj.tbl_DichVuVCNB != null)
                {
                    tblDichVuVCNBBindingSource.DataSource = obj.tbl_DichVuVCNB.ToList();
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
            //textBox1.Text = "";
            //textBox1.ForeColor = Color.Black;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13)
            //{
            //    if (string.IsNullOrEmpty(textBox1.Text))
            //    {
            //        tblKhachHangaBindingSource.DataSource = ds.tbl_KhachHanga.Include("tbl_DichVuVCNB").ToList();
            //        ShowAddress();
            //    }
            //    else
            //    {
            //        var query = from o in ds.tbl_KhachHanga.Include("tbl_DichVuVCNB")
            //                    where o.HoVaTen.Contains(textBox1.Text)
            //                    select o;
            //        tblKhachHangaBindingSource.DataSource = query.ToList();
            //        ShowAddress();

            //    }
            //}
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
                //if (string.IsNullOrEmpty(textBox1.Text))
                //{
                //    tblKhachHangaBindingSource.DataSource = ds.tbl_KhachHanga.Include("tbl_DichVuVCNB").ToList();
                //    ShowAddress();
                //}
                //else
                //{
                //    var query = from o in ds.tbl_KhachHanga.Include("tbl_DichVuVCNB")
                //                where o.HoVaTen.Contains(textBox1.Text)
                //                select o;
                //    tblKhachHangaBindingSource.DataSource = query.ToList();
                //    ShowAddress();

                //}
            
        }

        private void barEditItem1_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (string.IsNullOrEmpty(textBox1.Text))
            //{
            //    tblKhachHangaBindingSource.DataSource = ds.tbl_KhachHanga.Include("tbl_DichVuVCNB").ToList();
            //    ShowAddress();
            //}
            //else
            //{
            //    var query = from o in ds.tbl_KhachHanga.Include("tbl_DichVuVCNB")
            //                where o.HoVaTen.Contains(textBox1.Text)
            //                select o;
            //    tblKhachHangaBindingSource.DataSource = query.ToList();
            //    ShowAddress();

            //}
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    tblKhachHangaBindingSource.DataSource = ds.tbl_KhachHanga.Include("tbl_DichVuVCNB").ToList();
                    ShowAddress();
                }
                else
                {
                    var query = from o in ds.tbl_KhachHanga.Include("tbl_DichVuVCNB")
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

        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (CapNhat.AddVanChuyenNoiBo frm = new CapNhat.AddVanChuyenNoiBo(new tbl_KhachHanga()))
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
                using (CapNhat.AddVanChuyenNoiBo frm = new CapNhat.AddVanChuyenNoiBo(obj))
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
    }
}