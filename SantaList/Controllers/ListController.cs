using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SantaList.Controllers
{
    public class ListController : Controller
    {
        // GET: LIst
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gift_Wish()
        {
            return View();
        }
    }
}