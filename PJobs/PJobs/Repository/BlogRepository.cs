using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PJobs.Models;

namespace PJobs.Repository
{
    public class BlogRepository
    {
        VIECLAMContext ctx = new VIECLAMContext();

        public List<Blog> getAllBlog() {
            return ctx.Blogs.ToList();

        }


        public Blog themblog(Blog blg)
        {
            ctx.Blogs.Add(blg);
            ctx.SaveChanges();
            return blg;
        }
      
        public List<Blog> xoablog(int blg)
        {

            Blog blg_db  = ctx.Blogs.Where(x => x.MaBlog == blg).SingleOrDefault();
            ctx.Blogs.Remove(blg_db);
            ctx.SaveChanges();
            return ctx.Blogs.ToList();
        }

        public Blog suablog(Blog blg)
        {

            Blog blg_db = ctx.Blogs.Where(x => x.MaBlog == blg.MaBlog).SingleOrDefault();
            //MaPhanHoi, NoiDungPhanHoi, TinhTrang, NgayPhanHoi, TieuDe, Email, HoTen
            blg_db.MaNghe = blg.MaNghe;
            blg_db.TenBlog = blg.TenBlog;
            blg_db.NoiDungBlog = blg.NoiDungBlog;
            blg_db.NgayDangBlog = blg.NgayDangBlog;
            blg_db.Thumbnail = blg.Thumbnail;
            blg_db.AnhBlog = blg.AnhBlog;
            blg_db.LuotXem = blg.LuotXem;
            ctx.SaveChanges();
            return blg;
        }
        public Blog timkiemBlog_theoid(int id)
        {
            return ctx.Blogs.Where(blg => blg.MaBlog == id).SingleOrDefault();
        }


    }
}
