using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioWebApp.Controllers
{
    public class Projects : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
