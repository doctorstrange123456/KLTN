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
using System.Diagnostics;

namespace KhoaLuanTotNghiep.UserControl
{
    public partial class InformationCompany : DevExpress.XtraEditors.XtraForm
    {
        public InformationCompany()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(nhanVien1);
            bunifuTransition3.HideSync(lienHe1);
            bunifuTransition1.ShowSync(gioiThiue1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(gioiThiue1);
            bunifuTransition3.HideSync(lienHe1);
            bunifuTransition2.ShowSync(nhanVien1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(nhanVien1);
            bunifuTransition1.HideSync(gioiThiue1);
            bunifuTransition3.ShowSync(lienHe1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("www.google.com");
        }
    }
}