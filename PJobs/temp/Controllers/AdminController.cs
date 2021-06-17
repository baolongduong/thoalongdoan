using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PJobs.Models;
using PJobs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJobs.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {

        private VIECLAMContext ctx = new VIECLAMContext();
        private BlogRepository _blogRepository = null;
        private NgangNgheRepository _ngangNgheRepository = null;
        private TinTuyenDungRepository _tinTuyenDungRepository = null;
        private QuanHuyenRepository _quanhuyenRepository = null;
        private ThanhPhoRepository _thanhphoRepository = null;
        private LinhVucRepository _linhVucRepository = null;

 

        public AdminController(NgangNgheRepository ngangNgheRepository, TinTuyenDungRepository tinTuyenDungRepository, BlogRepository blogRepository, QuanHuyenRepository quanHuyenRepository, ThanhPhoRepository thanhPhoRepository,LinhVucRepository linhVucRepository) {
            _ngangNgheRepository = ngangNgheRepository;
            _tinTuyenDungRepository = tinTuyenDungRepository;
            _blogRepository = blogRepository;
            _quanhuyenRepository = quanHuyenRepository;
            _thanhphoRepository = thanhPhoRepository;
            _linhVucRepository = linhVucRepository;
          
        }

        public IActionResult Index()
        {
            return View();
        }

        //Blog
        public IActionResult BlogInformation()
        {
            ViewBag.DSNganhNghe = ctx.ThongTinNganhNghes.ToList();
            ViewBag.DSBlog = _blogRepository.getAllBlog();
            return View();
        }

        public IActionResult XoaBlog(int id)
        {

            List<Blog> ds = _blogRepository.xoablog(id);
            return RedirectToAction("bloginformation");
        }

        public IActionResult SuaBlog(Blog blg)
        {
            _blogRepository.suablog(blg);
           return RedirectToAction("bloginformation");
        }


        [HttpPost]
        public IActionResult themblog(Blog blog)
        {
            blog.LuotXem = 0;
            DateTime currentDate = DateTime.Now;
            blog.MaNghe = 147;
            blog.NgayDangBlog = currentDate;
            //ViewBag.mess = "thong tin đã được gửi";
            _blogRepository.themblog(blog);
            return RedirectToAction("bloginformation");
        }
        //QuanHuyen
        public IActionResult QuanHuyenInformation()
        {
            ViewBag.DSQHuyen = _quanhuyenRepository.getAllQuanHuyen();
            return View();
        }

        public IActionResult XoaQuanHuyen(int id)
        {

            List<QuanHuyen> ds = _quanhuyenRepository.xoaQuanHuyen(id);
            return RedirectToAction("QuanHuyenInformation");
        }

        public IActionResult SuaQuanHuyen(int id)
        {
            QuanHuyen qh = _quanhuyenRepository.timkiemQH_theoid(id);
            return View("QuanHuyenEdited",qh);
        }
        [HttpPost]
        public IActionResult SuaQuanHuyen(QuanHuyen qh)
        {
            _quanhuyenRepository.suaQuanHuyen(qh);
            return RedirectToAction("QuanHuyenInformation");
        }


        [HttpPost]
        public IActionResult themQuanHuyen(QuanHuyen qh)
        {
            _quanhuyenRepository.themQuanHuyen(qh);
            return RedirectToAction("QuanHuyenInformation");
        }
        //Thanhpho
        public IActionResult ThanhPhoInformation()
        {
            ViewBag.DSTPho = _thanhphoRepository.getAllThanhPho();
            return View();
        }

        public IActionResult XoaThanhPho(int id)
        {

            List<ThanhPho> ds = _thanhphoRepository.xoaThanhPho(id);
            return RedirectToAction("ThanhPhoInformation");
        }

        public IActionResult SuaThanhPho(ThanhPho tp)
        {
            _thanhphoRepository.suaThanhPho(tp);
            return RedirectToAction("ThanhPhoInformation");
        }


        [HttpPost]
        public IActionResult themThanhPho(ThanhPho tp)
        {
            _thanhphoRepository.themThanhPho(tp);
            return RedirectToAction("ThanhPhoInformation");
        }


        //LinhVuc
        public IActionResult LinhVucInformation()
        {
            ViewBag.DSLVuc = _linhVucRepository.getAllLinhVuc();
            return View();
        }

        public IActionResult XoaLinhVuc(int id)
        {

            List<ThongTinLinhVuc> ds = _linhVucRepository.xoalinhvuc(id);
            return RedirectToAction("LinhVucInformation");
        }

        public IActionResult SuaLinhVuc(ThongTinLinhVuc lv)
        {
            _linhVucRepository.sualinhvuc(lv);
            return RedirectToAction("LinhVucInformation");
        }


        [HttpPost]
        public IActionResult themLinhVuc(ThongTinLinhVuc lv)
        {
            _linhVucRepository.themlinhvuc(lv);
            return RedirectToAction("LinhVucInformation");
        }
        //Job
        public IActionResult Danhsachnganhnghe()
        {
            
            List<ThongTinNganhNghe> ds= _ngangNgheRepository.DanhSachThongTinNganhNghe();
            return View(ds);
        }
        public IActionResult DanhsachTinTuyenDungTheoNganhNghe(int id)
        {

            List<TinTuyenDung> ds = _tinTuyenDungRepository.dsTinTuyenDung();
            return View(ds);
        }

        public IActionResult XoaNganhNghe(int id)
        {

            List<ThongTinNganhNghe> ds = _ngangNgheRepository.XoaThongTinNganhNghe(id);
            return RedirectToAction("Danhsachnganhnghe");
        }
        public IActionResult SuaNganhNghe(int id)
        {
            ThongTinNganhNghe ng = _ngangNgheRepository.timkiemNganhNghe_theoid(id);
            return View("DanhsachngannhngheEdited", ng);
        }
        [HttpPost]
        public IActionResult SuaNganhNghe(ThongTinNganhNghe ng)
        {
            _ngangNgheRepository.suaThongTinNganhNghe(ng);
            return RedirectToAction("Danhsachnganhnghe");
        }
        [HttpPost]
        public IActionResult themNganhNghe(ThongTinNganhNghe ng)
        {
            _ngangNgheRepository.themThongTinNganhNghe(ng);
            return RedirectToAction("Danhsachnganhnghe");
        }


        //Account
        public IActionResult Account()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

    }
}

