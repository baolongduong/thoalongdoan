using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PJobs.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Repository;

namespace PJobs.Controllers
{
    public class BlogController : Controller
    {
        VIECLAMContext ctx = new VIECLAMContext();

        public IActionResult Index()
        {

            var q = (from blg in ctx.Blogs
                     join nn in ctx.ThongTinNganhNghes on blg.MaNghe equals nn.MaNghe
                     orderby blg.NgayDangBlog descending
                     select new BlogJoinJob
                     {
                         MaBlog = blg.MaBlog,
                         MaNghe = blg.MaNghe,
                         TenNghe = nn.TenNghe,
                         TenBlog = blg.TenBlog,
                         NoiDungBlog = blg.NoiDungBlog,
                         AnhNgoai = blg.Thumbnail,
                         AnhTrong = blg.AnhBlog,
                         NgayDangBlog = blg.NgayDangBlog
                     }
                     );
            //passing model/data to  view
            return View(q);
        }


        public IActionResult BlogDetails(int id)
        {

            var q = (from blg in ctx.Blogs
                     join nn in ctx.ThongTinNganhNghes on blg.MaNghe equals nn.MaNghe
                     where blg.MaBlog == id
                     select new BlogJoinJob
                     {
                         MaBlog = blg.MaBlog,
                         MaNghe = blg.MaNghe,
                         TenNghe = nn.TenNghe,
                         TenBlog = blg.TenBlog,
                         NoiDungBlog = blg.NoiDungBlog,
                         AnhNgoai = blg.Thumbnail,
                         AnhTrong = blg.AnhBlog,
                         NgayDangBlog = blg.NgayDangBlog
                     }
                   );
            //passing model/data to  view
            return View(q);
        }

    }
}