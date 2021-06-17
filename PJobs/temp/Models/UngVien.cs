using System;
using System.Collections.Generic;

#nullable disable

namespace PJobs.Models
{
    public partial class UngVien
    {
        public UngVien()
        {
            UngVienDangKies = new HashSet<UngVienDangKy>();
            UngVienKiNangs = new HashSet<UngVienKiNang>();
        }

        public long MaUngVien { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string Cmnd { get; set; }
        public string HoTen { get; set; }
        public string Sdt { get; set; }
        public long ThanhPhoSinhSong { get; set; }
        public long QuanHuyenSinhSong { get; set; }
        public string DiaChiChiTiet { get; set; }
        public string FileCv { get; set; }
        public string AnhDaiDien { get; set; }
        public long? LuotXem { get; set; }
        public DateTime? NgayTaoTk { get; set; }

        public virtual ICollection<UngVienDangKy> UngVienDangKies { get; set; }
        public virtual ICollection<UngVienKiNang> UngVienKiNangs { get; set; }
    }
}
