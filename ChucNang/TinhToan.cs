using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep
{
    public partial class tbl_KhoNoiBo
    {
        public double? ThanhTienCal
        {
            get
            {
                this.ThanhTien = this.SoLuong * this.SoNgay * this.TrongLuong * this.DonGia;
                return this.ThanhTien;
            }
            set
            {
                this.ThanhTien = value;
            }
        }
    }
    public partial class tbl_DichVuVCNB
    {
        public double? ThanhTiencal
        {
            get
            {
                this.ThanhTien = this.TrongLuong * this.DonGia * this.QuangDuong * this.SoLuong;
                return this.ThanhTien;
            }
            set
            {
                this.ThanhTien = value;
            }
        }
    }
    public partial class tbl_HopDong
    {
        public double? Thanhtiencal
        {
            get
            {
                this.ChiPhiConLai = this.ChiPhi - this.ChiPhiNop;
                return this.ChiPhiConLai;
            }
            set
            {
                this.ChiPhiConLai = value;
            }
        }
    }
    public partial class tbl_HangHoa
    {
        public double? ThanhTiencal
        {
            get
            {
                if (this.IDXNKhau == 2 && this.IDHTVC == 1 && (this.IDDongGoi == 1 || this.IDDongGoi == 2) && (this.IDPLHH == 2 || this.IDPLHH == 4 || this.IDPLHH == 5))
                
                    this.ThanhTien = this.SoLuong * this.DonGia * this.TrongLuong * 2000 * 3000 * 20000 * 1000;
                
                //if(this.IDXNKhau == 1 && this.IDHTVC == 3 && (this.IDDongGoi == 1 || this.IDDongGoi == 2) && (this.IDPLHH == 1 || this.IDPLHH == 3))
                
                //    this.ThanhTien = this.SoLuong * this.DonGia * this.TrongLuong * 3000 * 3000 * 40000 * 2000-(this.ThanhTien*10)/100;
                

                return this.ThanhTien;
                
                
            }
            set
            {
                this.ThanhTien = value;
            }
        }
    }
}
