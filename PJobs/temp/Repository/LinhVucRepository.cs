using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PJobs.Models;

namespace PJobs.Repository
{
    public class LinhVucRepository
    {
        VIECLAMContext ctx = new VIECLAMContext();

        public List<ThongTinLinhVuc> getAllLinhVuc() {
            return ctx.ThongTinLinhVucs.ToList();

        }


        public ThongTinLinhVuc themlinhvuc(ThongTinLinhVuc lv)
        {
            ctx.ThongTinLinhVucs.Add(lv);
            ctx.SaveChanges();
            return lv;
        }
      
        public List<ThongTinLinhVuc> xoalinhvuc(int lv)
        {

            ThongTinLinhVuc lv_db  = ctx.ThongTinLinhVucs.Where(x => x.MaLinhVuc == lv).SingleOrDefault();
            ctx.ThongTinLinhVucs.Remove(lv_db);
            ctx.SaveChanges();
            return ctx.ThongTinLinhVucs.ToList();
        }

        public ThongTinLinhVuc sualinhvuc(ThongTinLinhVuc lv)
        {

            ThongTinLinhVuc lv_db = ctx.ThongTinLinhVucs.Where(x => x.MaLinhVuc == lv.MaLinhVuc).SingleOrDefault();
            //MaPhanHoi, NoiDungPhanHoi, TinhTrang, NgayPhanHoi, TieuDe, Email, HoTen
            lv_db.TenLinhVuc = lv.TenLinhVuc;
        ctx.SaveChanges();
            return lv;
        }
        /*public List<PhanHoi> timkiemPhanHoi_theongay(DateTime ngay)
        {
            return ctx.PhanHois.Where(ph => ph.NgayPhanHoi == ngay).ToList();
        }*/

    }
}
