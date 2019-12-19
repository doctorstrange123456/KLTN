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
    public partial class AddKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public AddKhachHang(tbl_KhachHanga obj)
        {
            InitializeComponent();
            tblKhachHangaBindingSource.DataSource = obj;
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        public tbl_KhachHanga KHInfor { get { return tblKhachHangaBindingSource.Current as tbl_KhachHanga; } }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void AddKhachHang_Load(object sender, EventArgs e)
        {
            ds.tbl_HangHoa.ToList();
            tblHangHoaBindingSource.DataSource = ds.tbl_HangHoa.Local;
            tblThanhToanBindingSource.DataSource = ds.tbl_ThanhToan.ToList();
            tblQuocTichBindingSource.DataSource = ds.tbl_QuocTich.ToList();
            //ds.tbl_HTVanCHuyen.ToList();
            //tblHTVanCHuyenBindingSource.DataSource = ds.tbl_HTVanCHuyen.Local;

            //ds.tbl_TinhTrangVanDon.ToList();
            //tblTinhTrangVanDonBindingSource.DataSource = ds.tbl_TinhTrangVanDon.Local;
        }

        private void ImagePictureEdit_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                tblKhachHangaBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }

        

        private void ImagePictureEdit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImagePictureEdit.Image = Image.FromFile(openFileDialog.FileName);

                }
                ds.SaveChanges();
            }
        }
    }
}