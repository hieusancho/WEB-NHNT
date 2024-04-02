using System;
using System.Collections.Generic;

#nullable disable

namespace NHNT_G08.Models
{
    public partial class TblHinhAnh
    {
        public int MaAnh { get; set; }
        public string DuongDan { get; set; }
        public int MaPhong { get; set; }

        public virtual TblPhong MaPhongNavigation { get; set; }
    }
}
