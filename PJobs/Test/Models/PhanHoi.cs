using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class PhanHoi
    {
        public long MaPhanHoi { get; set; }
        public string NoiDungPhanHoi { get; set; }
        public long TinhTrang { get; set; }
        public long MaUngVien { get; set; }
        public long MaCongTy { get; set; }
        public DateTime? NgayPhanHoi { get; set; }

        public virtual NhaTuyenDung MaCongTyNavigation { get; set; }
        public virtual UngVien MaUngVienNavigation { get; set; }
    }
}
