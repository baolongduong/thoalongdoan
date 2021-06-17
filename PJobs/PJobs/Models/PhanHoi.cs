using System;
using System.Collections.Generic;

#nullable disable

namespace PJobs.Models
{
    public partial class PhanHoi
    {
        public long MaPhanHoi { get; set; }
        public string NoiDungPhanHoi { get; set; }
        public long TinhTrang { get; set; }
        public DateTime? NgayPhanHoi { get; set; }
        public string TieuDe { get; set; }
        public string Email { get; set; }
        public string HoTen { get; set; }
    }
}
