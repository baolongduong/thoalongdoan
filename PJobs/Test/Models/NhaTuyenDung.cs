using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class NhaTuyenDung
    {
        public NhaTuyenDung()
        {
            PhanHois = new HashSet<PhanHoi>();
            TinTuyenDungs = new HashSet<TinTuyenDung>();
        }

        public long MaNhaTuyenDung { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string TenCongTy { get; set; }
        public string Sdt { get; set; }
        public string MaSoThue { get; set; }
        public long ThanhPhoHoatDong { get; set; }
        public long QuanHuyenHoatDong { get; set; }
        public string DiaChiHoatDong { get; set; }
        public byte[] AnhDaiDien { get; set; }
        public long MaNghe { get; set; }
        public string MoTaCongTy { get; set; }

        public virtual ICollection<PhanHoi> PhanHois { get; set; }
        public virtual ICollection<TinTuyenDung> TinTuyenDungs { get; set; }
    }
}
