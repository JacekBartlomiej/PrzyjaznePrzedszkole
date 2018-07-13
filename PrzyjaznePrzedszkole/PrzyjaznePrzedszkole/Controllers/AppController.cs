using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzyjaznePrzedszkole.Controllers
{
    public class AppController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("notice-board")]
        public IActionResult NoticeBoard()
        {
            ViewBag.Title = "Notice Board";
            return View();
        }

        [HttpGet("messages")]
        public IActionResult Messages()
        {
            ViewBag.Title = "Messages";
            return View();
        }

        [HttpGet("photos")]
        public IActionResult Photos()
        {
            ViewBag.Title = "Photos";
            return View();
        }

        [HttpGet("for-parents")]
        public IActionResult ForParents()
        {
            ViewBag.Title = "ForParents";
            return View();
        }
    }
}
