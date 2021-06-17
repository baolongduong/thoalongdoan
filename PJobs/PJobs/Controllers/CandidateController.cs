using Microsoft.AspNetCore.Mvc;
using PJobs.Models;
using PJobs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJobs.Controllers
{
    public class CandidateController : Controller
    {
        private TinTuyenDungRepository tinTuyenDungRepository = new TinTuyenDungRepository();
        private UngVienRepository UngVienRepository = new UngVienRepository();
        public IActionResult Index()
        {
            List<UngVien> lst = UngVienRepository.getAllUngVien();

            //passing model/data to  view
            return View(lst);
        }

        
    }
}
