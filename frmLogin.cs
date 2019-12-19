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
using DevExpress.LookAndFeel.Design;

namespace KhoaLuanTotNghiep
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            Init_Data();
            
        }
        KhoaLuanTotNghiepEntities1 ds = new KhoaLuanTotNghiepEntities1();
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void Save_Data()
        {
            if (chkGhiNho.Checked)
            {
                Properties.Settings.Default.UserName = txtUser.Text;
                Properties.Settings.Default.PassWord = txtPass.Text;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = txtUser.Text;
                Properties.Settings.Default.PassWord = "";
                Properties.Settings.Default.Remme = "no";
                Properties.Settings.Default.Save();
            }
        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remme == "yes")
                {
                    txtUser.Text = Properties.Settings.Default.UserName;
                    txtPass.Text = Properties.Settings.Default.PassWord;
                    chkGhiNho.Checked = true;
                }
                else
                {
                    txtUser.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        private void chkGhiNho_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkHienThi.Checked )
            //{
            //    txtPass.UseSystemPasswordChar = true;
            //}
            //else
            //{
            //    txtPass.UseSystemPasswordChar = false;
            //}
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (UserName.Trim().Length == 0 || PassWord.Trim().Length == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập UserName hoặc PassWord!\n\n Mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (UserName.Trim().Length != 0 && PassWord.Trim().Length != 0)
            {

                try
                {

                    var user = ds.tbl_Login.FirstOrDefault(x => x.UserName == UserName);
                    if (user == null)
                    {
                        XtraMessageBox.Show("UserName hoặc PassWord không chính xác!\n\n Mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        if (user.PassWord == PassWord)
                        {
                            DialogResult traloi;
                            traloi = XtraMessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            Save_Data();
                            this.Hide();
                            if (traloi == DialogResult.OK)
                            {
                                Main main = new Main();
                                main.Show();
                                

                            }

                        }
                        else
                        {
                            XtraMessageBox.Show("UserName hoặc PassWord không chính xác!\n\n Mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                }
                catch
                {
                    XtraMessageBox.Show("Lỗi hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private string UserName
        {
            get => (txtUser.Text != null) ? (string)(txtUser.Text) : "";
            set => txtUser.Text = value;
        }
        private string PassWord
        {
            get => (txtPass.Text != null) ? (string)(txtPass.Text) : "";
            set => txtPass.Text = value;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = XtraMessageBox.Show("Bạn có đồng ý thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void pnDangNhap_Paint(object sender, PaintEventArgs e)
        {
            pnDangNhap.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}