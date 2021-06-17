using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace PJobs.Repository
{
    public class NgangNgheRepository
    {
        VIECLAMContext ctx = new VIECLAMContext();

        public List<ThongTinNganhNghe> DanhSachThongTinNganhNghe()
        {
            return ctx.ThongTinNganhNghes.Include(tb => tb.MaLinhVucNavigation).ToList();
        }

        public ThongTinNganhNghe  suaThongTinNganhNghe(ThongTinNganhNghe ng)
        {
            ThongTinNganhNghe ng_db = ctx.ThongTinNganhNghes.Where(x => x.MaNghe == ng.MaNghe).SingleOrDefault();
            //MaNghe, TenNghe, MaLinhVuc, LuotXem
            ng_db.TenNghe = ng.TenNghe;
            ctx.SaveChanges();
            return ng;
        }
        public List<ThongTinNganhNghe> XoaThongTinNganhNghe(int id)
        {

            ThongTinNganhNghe tt= ctx.ThongTinNganhNghes.Where(x => x.MaNghe == id).SingleOrDefault();
            ctx.ThongTinNganhNghes.Remove(tt);
            ctx.SaveChanges();

            return ctx.ThongTinNganhNghes.Include(tb => tb.MaLinhVucNavigation).ToList();
        }
        public ThongTinNganhNghe themThongTinNganhNghe(ThongTinNganhNghe ng)
        {
            ctx.ThongTinNganhNghes.Add(ng);
            ctx.SaveChanges();
            return ng;
        }
        public ThongTinNganhNghe timkiemNganhNghe_theoid(int id)
        {
            return ctx.ThongTinNganhNghes.Where(ng => ng.MaNghe == id).SingleOrDefault();
        }
    }
}
