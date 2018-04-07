using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubWayTest.Controllers
{
    public class SubwayController : Controller
    {
        // GET: Subway
        public ActionResult Index()
        {
            return View();
        }
    }
}