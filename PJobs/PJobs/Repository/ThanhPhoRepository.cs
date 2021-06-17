using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PJobs.Models;

namespace PJobs.Repository
{
    public class ThanhPhoRepository
    {
        VIECLAMContext ctx = new VIECLAMContext();

        public List<ThanhPho> getAllThanhPho()
        {
            return ctx.ThanhPhos.ToList();
        }


        public ThanhPho themThanhPho(ThanhPho tp)
        {
            ctx.ThanhPhos.Add(tp);
            ctx.SaveChanges();
            return tp;
        }

        public List<ThanhPho> xoaThanhPho(int tp)
        {

            ThanhPho tp_db = ctx.ThanhPhos.Where(x => x.MaThanhPho == tp).SingleOrDefault();
            ctx.ThanhPhos.Remove(tp_db);
            ctx.SaveChanges();
            return ctx.ThanhPhos.ToList();
        }

        public ThanhPho suaThanhPho(ThanhPho tp)
        {

            ThanhPho tp_db = ctx.ThanhPhos.Where(x => x.MaThanhPho == tp.MaThanhPho).SingleOrDefault();
            //MaPhanHoi, NoiDungPhanHoi, TinhTrang, NgayPhanHoi, TieuDe, Email, HoTen
            tp_db.TenThanhPho = tp.TenThanhPho;

            ctx.SaveChanges();
            return tp;
        }
        public ThanhPho timkiemTP_theoid(int id)
        {
            return ctx.ThanhPhos.Where(qh => qh.MaThanhPho == id).SingleOrDefault();
        }

    }
}
