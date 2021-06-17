using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PJobs.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Repository;

namespace PJobs.Controllers
{
    public class LoginController : Controller
    {
        private VIECLAMContext ctx = new VIECLAMContext();

        public LoginController()
        {

        }

        public IActionResult Index()
        {
           
            //passing model/data to  view
            return View();
        }


    }
}