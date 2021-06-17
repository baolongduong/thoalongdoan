using System;
using System.Collections.Generic;

#nullable disable

namespace PJobs.Models
{
    public partial class UngVienDangKy
    {
        public long MaDangKy { get; set; }
        public long MaUngVien { get; set; }
        public long TinhTrangUngVien { get; set; }
        public long? MaTinTuyenDung { get; set; }
        public DateTime? NgayDangky { get; set; }

        public virtual TinTuyenDung MaTinTuyenDungNavigation { get; set; }
        public virtual UngVien MaUngVienNavigation { get; set; }
    }
}
