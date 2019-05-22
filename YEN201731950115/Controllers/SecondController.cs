using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YEN201731950115.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult twice()
        {
            ViewBag.a = "欢迎来到我的世界！";
            return View();
        }
    }
}