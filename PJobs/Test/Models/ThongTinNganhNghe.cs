using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
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
        public long? LinhVuc { get; set; }
        public long MaThanhPho { get; set; }
        public long MaQuanHuyen { get; set; }

        public virtual ThongTinDiaDiem Ma { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<TinTuyenDung> TinTuyenDungs { get; set; }
    }
}
