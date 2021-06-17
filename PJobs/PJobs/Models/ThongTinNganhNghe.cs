using System;
using System.Collections.Generic;

#nullable disable

namespace PJobs.Models
{
    public partial class ThongTinNganhNghe
    {
        public ThongTinNganhNghe()
        {
            Blogs = new HashSet<Blog>();
            TinTuyenDungs = new HashSet<TinTuyenDung>();
        }

        public long MaNghe { get; set; }
        public string TenNghe { get; set; }
        public long MaLinhVuc { get; set; }
        public long? LuotXem { get; set; }

        public virtual ThongTinLinhVuc MaLinhVucNavigation { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<TinTuyenDung> TinTuyenDungs { get; set; }
    }
}
