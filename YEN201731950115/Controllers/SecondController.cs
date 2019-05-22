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
            ViewBag.b = "以下是我的信息表！";
            return View();
        }
    }
}