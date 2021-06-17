using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Models;
using System.Globalization;

namespace PJobs.Repository
{
    public class BlogJoinJob
    {
        public long MaBlog { get; set; }
        public long MaNghe { get; set; }
        public string TenNghe { get; set; }
        public string TenBlog { get; set; }
        public string NoiDungBlog { get; set; }

        public string AnhTrong { get; set; }
        public string AnhNgoai { get; set; }

        public DateTime? NgayDangBlog { get; set; }
     

    }
}


