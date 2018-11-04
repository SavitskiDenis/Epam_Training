using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_14.Controllers
{
    public class AboutController : Controller
    {
        [Route("Information")]
        public ActionResult Info()
        {
            return View();
        }
    }
}