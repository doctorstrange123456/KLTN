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

namespace KhoaLuanTotNghiep.Report
{
    public partial class Form_VanDon_SEA : DevExpress.XtraEditors.XtraForm
    {
        public Form_VanDon_SEA()
        {
            InitializeComponent();
            Report_VanDon_Sea report = new Report_VanDon_Sea();
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}