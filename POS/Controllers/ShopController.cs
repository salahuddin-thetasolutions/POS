using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace POS.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}