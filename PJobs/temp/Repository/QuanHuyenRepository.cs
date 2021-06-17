using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PJobs.Models;

namespace PJobs.Repository
{
    public class QuanHuyenRepository
    {
        VIECLAMContext ctx = new VIECLAMContext();

        public List<QuanHuyen> getAllQuanHuyen() {
            return ctx.QuanHuyens.ToList();

        }


        public QuanHuyen themQuanHuyen(QuanHuyen qh)
        {
            ctx.QuanHuyens.Add(qh);
            ctx.SaveChanges();
            return qh;
        }
      
        public List<QuanHuyen> xoaQuanHuyen(int qh)
        {

            QuanHuyen qh_db  = ctx.QuanHuyens.Where(x => x.MaQuan == qh).SingleOrDefault();
            ctx.QuanHuyens.Remove(qh_db);
            ctx.SaveChanges();
            return ctx.QuanHuyens.ToList();
        }

        public QuanHuyen suaQuanHuyen(QuanHuyen qh)
        {

            QuanHuyen qh_db = ctx.QuanHuyens.Where(x => x.MaQuan == qh.MaQuan).SingleOrDefault();
            qh_db.TenQuan = qh.TenQuan;
            
            ctx.SaveChanges();
            return qh;
        }


        public QuanHuyen timkiemQH_theoid(int id)
        {
            return ctx.QuanHuyens.Where(qh => qh.MaQuan == id).SingleOrDefault();
        }

    }
}
