using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace KhoaLuanTotNghiep.Report
{
    public partial class ReportHangHoa : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHangHoa()
        {
            InitializeComponent();
            xrLabel3.Text = DateTime.Now.ToString("dddd,d MMMM,yyyy");
        }

        private void xrPictureBox2_PreviewDoubleClick(object sender, PreviewMouseEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    xrPictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                    CreateDocument();
                }
            }
        }
    }
}
