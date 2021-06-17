using System;
using System.Collections.Generic;

#nullable disable

namespace PJobs.Models
{
    public partial class TinTuyenDung
    {
        public TinTuyenDung()
        {
            UngVienDangKies = new HashSet<UngVienDangKy>();
        }

        public long MaTinTuyenDung { get; set; }
        public long MaCongTy { get; set; }
        public long ViTriTuyenDung { get; set; }
        public string HoSoYeuCau { get; set; }
        public string MoTaCongViec { get; set; }
        public string QuyenLoi { get; set; }
        public long SoLuongTuyen { get; set; }
        public decimal MucLuong { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string Hinhanh { get; set; }
        public string Tieude { get; set; }
        public DateTime? NgayDang { get; set; }
        public long? LuotXem { get; set; }

        public virtual NhaTuyenDung MaCongTyNavigation { get; set; }
        public virtual ThongTinNganhNghe ViTriTuyenDungNavigation { get; set; }
        public virtual ICollection<UngVienDangKy> UngVienDangKies { get; set; }
    }
}
