using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Models;

namespace PJobs.Repository
{
    public class TinTuyenDungRepository
    {
        VIECLAMContext ctx = new VIECLAMContext();

        public List<TinTuyenDung> getAllTinTuyenDung() {
           return  ctx.TinTuyenDungs.ToList();

        }
        public List<TinTuyenDung> xoatintuyendung(int ttd)
        {

           TinTuyenDung ttd_db = ctx.TinTuyenDungs.Where(x => x.MaTinTuyenDung == ttd).SingleOrDefault();
            ctx.TinTuyenDungs.Remove(ttd_db);
            ctx.SaveChanges();
            return ctx.TinTuyenDungs.ToList();
        }

        public TinTuyenDung suatintuyendung(TinTuyenDung ttd)
        {

            TinTuyenDung ttd_db = ctx.TinTuyenDungs.Where(x => x.MaTinTuyenDung == ttd.MaTinTuyenDung).SingleOrDefault();
            //MaCongTy, ViTriTuyenDung, HoSoYeuCau, MoTaCongViec, QuyenLoi, SoLuongTuyen, MucLuong, NgayHetHan, hinhanh, tieude, NgayDang, LuotXem
            ttd_db.MaCongTy = ttd.MaCongTy;
            ttd_db.ViTriTuyenDung = ttd.ViTriTuyenDung;
            ttd_db.HoSoYeuCau = ttd.HoSoYeuCau;
            ttd_db.MucLuong = ttd.MucLuong;
            ttd_db.MoTaCongViec = ttd.MoTaCongViec;
            ttd_db.QuyenLoi = ttd.QuyenLoi;
            ttd_db.SoLuongTuyen= ttd.SoLuongTuyen;
            ttd_db.NgayHetHan = ttd.NgayHetHan;
            ttd_db.Hinhanh = ttd.Hinhanh;
            ttd_db.Tieude= ttd.Tieude;
            ttd_db.NgayDang = ttd.NgayDang;
            ttd_db.LuotXem= ttd.LuotXem;
            ctx.SaveChanges();
            return ttd;
        }
        public List<TinTuyenDung> timkiemTinTuyenDung_theongay(DateTime ngay)
        {
            return ctx.TinTuyenDungs.Where(ttd => ttd.NgayDang == ngay).ToList();
        }
        public TinTuyenDung themtintuyendung(TinTuyenDung ttd)
        {
            ctx.TinTuyenDungs.Add(ttd);
            ctx.SaveChanges();
            return ttd;
        }
        public List<TinTuyenDung> dsTinTuyenDung()
        {
            return ctx.TinTuyenDungs.ToList();
        }
    }
}
