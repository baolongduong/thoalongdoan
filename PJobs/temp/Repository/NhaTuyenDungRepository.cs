using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Models;
using Microsoft.EntityFrameworkCore;

namespace PJobs.Repository
{
    public class NhaTuyenDungRepository 
    {
        VIECLAMContext ctx = new VIECLAMContext();

        public List<NhaTuyenDung> timkiemNhatuyendung_theoten(string ten)
        {
             return ctx.NhaTuyenDungs.Where(x => x.TenCongTy.Contains(ten)).ToList();
        }
        public List<NhaTuyenDung> dsNhatuyendung()
        {
             return ctx.NhaTuyenDungs.ToList();
        }
        public NhaTuyenDung themnhatuyendung (NhaTuyenDung ntd)
        {
            ctx.NhaTuyenDungs.Add(ntd);
            ctx.SaveChanges();
            return ntd;
        }

        public List<NhaTuyenDung> xoanhatuyendung(int  ntd)
        {

            NhaTuyenDung ntd_db = ctx.NhaTuyenDungs.Where(x => x.MaNhaTuyenDung == ntd).SingleOrDefault();
            ctx.NhaTuyenDungs.Remove(ntd_db);
            ctx.SaveChanges();
            return ctx.NhaTuyenDungs.ToList();
        }

        public NhaTuyenDung suanhatuyendung(NhaTuyenDung ntd)
        {
            NhaTuyenDung ntd_db= ctx.NhaTuyenDungs.Where(x => x.MaNhaTuyenDung == ntd.MaNhaTuyenDung).SingleOrDefault();
            ntd_db.MoTaCongTy = ntd.MoTaCongTy;
            ntd_db.ThanhPhoHoatDong = ntd.ThanhPhoHoatDong;

            ctx.SaveChanges();
            return ntd;
        }
    }
}
