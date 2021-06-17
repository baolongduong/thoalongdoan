using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class ThongTinDiaDiem
    {
        public ThongTinDiaDiem()
        {
            ThongTinNganhNghes = new HashSet<ThongTinNganhNghe>();
        }

        public long MaThanhPho { get; set; }
        public long MaQuanHuyen { get; set; }

        public virtual ICollection<ThongTinNganhNghe> ThongTinNganhNghes { get; set; }
    }
}
