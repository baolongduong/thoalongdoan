using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class Blog
    {
        public long MaBlog { get; set; }
        public long? LinhVucBlog { get; set; }
        public long MaNghe { get; set; }
        public string TenBlog { get; set; }
        public string NoiDungBlog { get; set; }

        public virtual ThongTinNganhNghe MaNgheNavigation { get; set; }
    }
}
