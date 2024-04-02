using System;
using System.Collections.Generic;

#nullable disable

namespace NHNT_G08.Models
{
    public partial class TblPhong
    {
        public TblPhong()
        {
            TblDanhGiaPhongs = new HashSet<TblDanhGiaPhong>();
            TblHinhAnhs = new HashSet<TblHinhAnh>();
        }

        public int MaPhong { get; set; }
        public int MaTaiKhoan { get; set; }
        public string TenPhong { get; set; }
        public string DiaChi { get; set; }
        public int? GiaPhong { get; set; }
        public int? GiaDien { get; set; }
        public int? GiaNuoc { get; set; }
        public string ChiTietPhong { get; set; }
        public string TrangThaiBaiDang { get; set; }
        public string TrangThaiPhong { get; set; }
        public double? DienTich { get; set; }
        public string SoDienThoai { get; set; }

        public virtual TblTaiKhoan MaTaiKhoanNavigation { get; set; }
        public virtual ICollection<TblDanhGiaPhong> TblDanhGiaPhongs { get; set; }
        public virtual ICollection<TblHinhAnh> TblHinhAnhs { get; set; }
    }
}
