﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhoaLuanTotNghiep
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KhoaLuanTotNghiepEntities1 : DbContext
    {
        public KhoaLuanTotNghiepEntities1()
            : base("name=KhoaLuanTotNghiepEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_ContainerNoiDia> tbl_ContainerNoiDia { get; set; }
        public virtual DbSet<tbl_ContainerXNkhau> tbl_ContainerXNkhau { get; set; }
        public virtual DbSet<tbl_DaiLi> tbl_DaiLi { get; set; }
        public virtual DbSet<tbl_DichVuVCNB> tbl_DichVuVCNB { get; set; }
        public virtual DbSet<tbl_DMVanDon> tbl_DMVanDon { get; set; }
        public virtual DbSet<tbl_DongGoiHH> tbl_DongGoiHH { get; set; }
        public virtual DbSet<tbl_DVKho> tbl_DVKho { get; set; }
        public virtual DbSet<tbl_DVVC> tbl_DVVC { get; set; }
        public virtual DbSet<tbl_HangHoa> tbl_HangHoa { get; set; }
        public virtual DbSet<tbl_HHXuat_NhapKhau> tbl_HHXuat_NhapKhau { get; set; }
        public virtual DbSet<tbl_HopDong> tbl_HopDong { get; set; }
        public virtual DbSet<tbl_HTVanCHuyen> tbl_HTVanCHuyen { get; set; }
        public virtual DbSet<tbl_KhachHanga> tbl_KhachHanga { get; set; }
        public virtual DbSet<tbl_KhoNoiBo> tbl_KhoNoiBo { get; set; }
        public virtual DbSet<tbl_Login> tbl_Login { get; set; }
        public virtual DbSet<tbl_PhanLoaiHH> tbl_PhanLoaiHH { get; set; }
        public virtual DbSet<tbl_QuocTich> tbl_QuocTich { get; set; }
        public virtual DbSet<tbl_ThanhToan> tbl_ThanhToan { get; set; }
        public virtual DbSet<tbl_TinhTrangVanDon> tbl_TinhTrangVanDon { get; set; }
        public virtual DbSet<tbl_VanDon> tbl_VanDon { get; set; }
        public virtual DbSet<tblDMBaoGia> tblDMBaoGias { get; set; }
        public virtual DbSet<tblDMDoor> tblDMDoors { get; set; }
        public virtual DbSet<tblDMPort> tblDMPorts { get; set; }
        public virtual DbSet<tblNhanSu> tblNhanSus { get; set; }
    }
}
