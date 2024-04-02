using System;
using System.Collections.Generic;

#nullable disable

namespace NHNT_G08.Models
{
    public partial class TblDmTaiKhoan
    {
        public TblDmTaiKhoan()
        {
            TblTaiKhoans = new HashSet<TblTaiKhoan>();
        }

        public int MaDmTaiKhoan { get; set; }
        public string TenLoaiTk { get; set; }

        public virtual ICollection<TblTaiKhoan> TblTaiKhoans { get; set; }
    }
}
