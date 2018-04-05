using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tillidPortal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cloud()
        {
            return View();
        }
        public IActionResult BusinessIntelligence()
        {
            return View();
        }
        public IActionResult MicrosoftDynamics()
        {
            return View();
        }
        public IActionResult ProductDevelopment()
        {
            return View();
        }
        public IActionResult Sharepoint()
        {
            return View();
        }
        public IActionResult UserExperience()
        {
            return View();
        }
    }
}