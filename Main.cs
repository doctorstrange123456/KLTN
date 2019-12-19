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
using System.Threading;

namespace KhoaLuanTotNghiep
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            Thread t = new Thread(new ThreadStart(StarForm));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
        }
        public void StarForm()
        {
            Application.Run(new SplashScreenLogistic());
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
           // navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            //navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmLogin frm = new frmLogin())
            {
                frm.ShowDialog();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                //Neu form Search dang mo =>Active
                if (form.GetType() == typeof(KhoaLuanTotNghiep.DanhSachTable.DanhSachUser))//? dây frmLogin chính là form chính(hay form ban d?u m?i t?o Solution)
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                KhoaLuanTotNghiep.DanhSachTable.DanhSachUser PreTest = new KhoaLuanTotNghiep.DanhSachTable.DanhSachUser();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn thoát chương trình không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmLogin frm = new frmLogin())
            {
                if (XtraMessageBox.Show("Bạn có muốn đăng xuất không ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Hide();
                    frm.ShowDialog();
                }
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                //Neu form Search dang mo =>Active
                if (form.GetType() == typeof(KhoaLuanTotNghiep.ChucNang.DanhSachKhachHang))//? dây frmLogin chính là form chính(hay form ban d?u m?i t?o Solution)
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                KhoaLuanTotNghiep.ChucNang.DanhSachKhachHang PreTest = new KhoaLuanTotNghiep.ChucNang.DanhSachKhachHang();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                //Neu form Search dang mo =>Active
                if (form.GetType() == typeof(KhoaLuanTotNghiep.ChucNang.DanhSachHangHoa))//? dây frmLogin chính là form chính(hay form ban d?u m?i t?o Solution)
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                KhoaLuanTotNghiep.ChucNang.DanhSachHangHoa PreTest = new KhoaLuanTotNghiep.ChucNang.DanhSachHangHoa();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                //Neu form Search dang mo =>Active
                if (form.GetType() == typeof(KhoaLuanTotNghiep.ChucNang.frmHopDong))//? dây frmLogin chính là form chính(hay form ban d?u m?i t?o Solution)
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                KhoaLuanTotNghiep.ChucNang.frmHopDong PreTest = new KhoaLuanTotNghiep.ChucNang.frmHopDong();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                //Neu form Search dang mo =>Active
                if (form.GetType() == typeof(KhoaLuanTotNghiep.ChucNang.frmDaiLy))//? dây frmLogin chính là form chính(hay form ban d?u m?i t?o Solution)
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                KhoaLuanTotNghiep.ChucNang.frmDaiLy PreTest = new KhoaLuanTotNghiep.ChucNang.frmDaiLy();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                //Neu form Search dang mo =>Active
                if (form.GetType() == typeof(KhoaLuanTotNghiep.ChucNang.DichVuVanChuyen))//? dây frmLogin chính là form chính(hay form ban d?u m?i t?o Solution)
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                KhoaLuanTotNghiep.ChucNang.DichVuVanChuyen PreTest = new KhoaLuanTotNghiep.ChucNang.DichVuVanChuyen();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                //Neu form Search dang mo =>Active
                if (form.GetType() == typeof(KhoaLuanTotNghiep.ChucNang.DichVuKho))//? dây frmLogin chính là form chính(hay form ban d?u m?i t?o Solution)
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                KhoaLuanTotNghiep.ChucNang.DichVuKho PreTest = new KhoaLuanTotNghiep.ChucNang.DichVuKho();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                //Neu form Search dang mo =>Active
                if (form.GetType() == typeof(KhoaLuanTotNghiep.ChucNang.VanChuyenNoiBo))//? dây frmLogin chính là form chính(hay form ban d?u m?i t?o Solution)
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                KhoaLuanTotNghiep.ChucNang.VanChuyenNoiBo PreTest = new KhoaLuanTotNghiep.ChucNang.VanChuyenNoiBo();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                //Neu form Search dang mo =>Active
                if (form.GetType() == typeof(KhoaLuanTotNghiep.ChucNang.KhoNoiBo))//? dây frmLogin chính là form chính(hay form ban d?u m?i t?o Solution)
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                KhoaLuanTotNghiep.ChucNang.KhoNoiBo PreTest = new KhoaLuanTotNghiep.ChucNang.KhoNoiBo();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                //Neu form Search dang mo =>Active
                if (form.GetType() == typeof(KhoaLuanTotNghiep.ChucNang.DanhSachVanDon))//? dây frmLogin chính là form chính(hay form ban d?u m?i t?o Solution)
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                KhoaLuanTotNghiep.ChucNang.DanhSachVanDon PreTest = new KhoaLuanTotNghiep.ChucNang.DanhSachVanDon();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UserControl.InformationCompany frm = new UserControl.InformationCompany())
            {
                frm.ShowDialog();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DashBord.TinhTrangVanDon frm = new DashBord.TinhTrangVanDon())
            {
                frm.ShowDialog();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DashBord.DashBordTinhTrangVanDon frm = new DashBord.DashBordTinhTrangVanDon())
            {
                frm.ShowDialog();
            }
        }
    }
}