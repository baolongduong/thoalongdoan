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
   
    public class InfoController : Controller
    {


        private VIECLAMContext ctx = new VIECLAMContext();
        private NhaTuyenDungRepository _nhaTuyenDungRepository = null;


        public InfoController(NhaTuyenDungRepository nhaTuyenDungRepository)
        {

            _nhaTuyenDungRepository = nhaTuyenDungRepository;

        }
        public IActionResult Index()
        {
            return View();
        }


        [Authorize(Roles = "Candidate")]
        public IActionResult ProfileCandidate()
        {
            return View();
        }
     


        [Authorize(Roles = "Employer")]
        public IActionResult ProfileEmployer(int id)
        {
            ViewBag.DSNTD = _nhaTuyenDungRepository.timkiemNTD_theoid(id);
            NhaTuyenDung ntd = _nhaTuyenDungRepository.timkiemNTD_theoid(id);
            return View(ntd);
        }
    }
}
