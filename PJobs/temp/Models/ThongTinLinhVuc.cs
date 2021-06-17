using System;
using System.Collections.Generic;

#nullable disable

namespace PJobs.Models
{
    public partial class ThongTinLinhVuc
    {
        public ThongTinLinhVuc()
        {
            NhaTuyenDungs = new HashSet<NhaTuyenDung>();
            ThongTinNganhNghes = new HashSet<ThongTinNganhNghe>();
        }

        public long MaLinhVuc { get; set; }
        public string TenLinhVuc { get; set; }

        public virtual ICollection<NhaTuyenDung> NhaTuyenDungs { get; set; }
        public virtual ICollection<ThongTinNganhNghe> ThongTinNganhNghes { get; set; }
    }
}
