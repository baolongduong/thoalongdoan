using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Models;
using Microsoft.EntityFrameworkCore;

namespace PJobs.Repository
{
    public class UngVienRepository
    {
        VIECLAMContext ctx = new VIECLAMContext();

        public List<UngVien> getAllUngVien()
        {


            List<UngVien> lst = ctx.UngViens.Include(x => x.UngVienKiNangs).ToList();

            foreach (UngVien u in lst) {
                List<UngVienKiNang> ls = u.UngVienKiNangs.ToList();
               


                foreach (UngVienKiNang uv in ls) {
       

                    uv.MaKiNangNavigation = ctx.KiNangs.Where(x => x.MaKiNang == uv.MaKiNang).Single(); ;
                   
                }
                
                
            }
          
            return lst;
        }
        public UngVien themungvien(UngVien uv)
        {
            ctx.UngViens.Add(uv);
            ctx.SaveChanges();
            return uv;
        }
        public List<PhanHoi> dsPhanHoi()
        {
            return ctx.PhanHois.ToList();
        }
    }
}
