using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MT.Models;
namespace MT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var message = new Message();
            message.name = "Tam";
            ViewBag.welcome = "do minh tam";
            return View(message);
        }
    }
}