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

        [HttpGet("message")]
        public IActionResult Message()
        {
            ViewBag.Title = "Message";
            return View();
        }

        [HttpGet("add-message")]
        public IActionResult AddMessage()
        {
            ViewBag.Title = "AddMessage";
            return View();
        }

        [HttpPost("add-message")]
        public IActionResult AddMessage(AnnouncementViewModel model)
        {
            return View();
        }

        [HttpGet("photos")]
        public IActionResult Photos()
        {
            ViewBag.Title = "Photos";
            return View();
        }

        [HttpGet("parents-data")]
        public IActionResult ParentsData()
        {
            ViewBag.Title = "ParentsData";
            return View();
        }

        [HttpGet("add-notice")]
        public IActionResult AddNotice()
        {
            ViewBag.Title = "AddNotice";
            return View();
        }

        [HttpPost("add-notice")]
        public IActionResult AddNotice(AnnouncementViewModel model)
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
