using PJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJobs.Repository
{
    public class PhanhoiRepository
    {

        VIECLAMContext ctx = new VIECLAMContext();

        public PhanHoi themphanhoi (PhanHoi ph)
        {
            ctx.PhanHois.Add(ph);
            ctx.SaveChanges();
            return ph;
        }
        public List<PhanHoi> dsPhanHoi()
        {
            return ctx.PhanHois.ToList();
        }
        public List<PhanHoi> xoaphanhoi(int ph)
        {

          PhanHoi ph_db = ctx.PhanHois.Where(x => x.MaPhanHoi == ph).SingleOrDefault();
            ctx.PhanHois.Remove(ph_db);
            ctx.SaveChanges();
            return ctx.PhanHois.ToList();
        }

        public PhanHoi suaphanhoi(PhanHoi ph)
        {

            PhanHoi ph_db = ctx.PhanHois.Where(x => x.MaPhanHoi == ph.MaPhanHoi).SingleOrDefault();
            //MaPhanHoi, NoiDungPhanHoi, TinhTrang, NgayPhanHoi, TieuDe, Email, HoTen
            ph_db.NoiDungPhanHoi = ph.NoiDungPhanHoi;
            ph_db.TinhTrang = ph.TinhTrang;
            ph_db.NgayPhanHoi = ph.NgayPhanHoi;
            ph_db.TieuDe = ph.TieuDe;
           
            ctx.SaveChanges();
            return ph;
        }
        public List<PhanHoi> timkiemPhanHoi_theongay(DateTime ngay)
        {
            return ctx.PhanHois.Where(ph => ph.NgayPhanHoi == ngay).ToList();
        }

    }
}
