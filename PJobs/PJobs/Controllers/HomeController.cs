using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PJobs.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Repository;
using Microsoft.AspNetCore.Authorization;

namespace PJobs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private TinTuyenDungRepository tinTuyenDungRepository = new TinTuyenDungRepository();
        private UngVienRepository ungVienRepository = new UngVienRepository();
        private PhanhoiRepository phanhoiRepository = new PhanhoiRepository();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<TinTuyenDung> lst= tinTuyenDungRepository.getAllTinTuyenDung();

            //passing model/data to  view
            return View(lst);
        }
       
       
        public IActionResult Contact()
        {
            PhanHoi model = new PhanHoi();
            return View(model);
        }
        [HttpPost]
        public IActionResult Contact(PhanHoi model)
        {
            model.TinhTrang = 0;//
            DateTime currentDate =  DateTime.Now;
            
            model.NgayPhanHoi = currentDate;
            phanhoiRepository.themphanhoi(model);
            //ViewBag.mess = "thong tin đã được gửi";
            return View(model);
        }

        public IActionResult Text()
        {
            return View();
        }
 
        public IActionResult Privacy()
        {
            return View();
        }
        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
