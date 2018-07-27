using Microsoft.AspNetCore.Mvc;
using PrzyjaznePrzedszkole.ViewModels;
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

        [HttpGet("add-message")]
        public IActionResult AddMessage()
        {
            ViewBag.Title = "AddMessage";
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

        [HttpGet("add-notice")]
        public IActionResult AddNotice()
        {
            ViewBag.Title = "AddNotice";
            return View();
        }

        [HttpPost("add-notice")]
        public IActionResult AddNotice(NoticeViewModel model)
        {
            return View();
        }

        [HttpGet("notice")]
        public IActionResult Notice()
        {
            ViewBag.Title = "Notice";
            return View();
        }
    }
}
