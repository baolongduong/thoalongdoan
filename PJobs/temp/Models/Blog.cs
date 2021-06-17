using System;
using System.Collections.Generic;

#nullable disable

namespace PJobs.Models
{
    public partial class Blog
    {
        public long MaBlog { get; set; }
        public long MaNghe { get; set; }
        public string TenBlog { get; set; }
        public string NoiDungBlog { get; set; }
        public DateTime NgayDangBlog { get; set; }
        public string Thumbnail { get; set; }
        public string AnhBlog { get; set; }
        public long? LuotXem { get; set; }

        public virtual ThongTinNganhNghe MaNgheNavigation { get; set; }
    }
}
