using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class TinTuyenDung
    {
        public TinTuyenDung()
        {
            UngVienDangKies = new HashSet<UngVienDangKy>();
        }

        public long MaTinTuyenDung { get; set; }
        public long MaCongTy { get; set; }
        public string ViTriTuyenDung { get; set; }
        public string HoSoYeuCau { get; set; }
        public string MoTaCongViec { get; set; }
        public string QuyenLoi { get; set; }
        public long SoLuongTuyen { get; set; }
        public decimal MucLuong { get; set; }
        public byte[] NgayDang { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public long? MaNganhNghe { get; set; }
        public string Hinhanh { get; set; }
        public string Tieude { get; set; }

        public virtual NhaTuyenDung MaCongTyNavigation { get; set; }
        public virtual ThongTinNganhNghe MaNganhNgheNavigation { get; set; }
        public virtual ICollection<UngVienDangKy> UngVienDangKies { get; set; }
    }
}
