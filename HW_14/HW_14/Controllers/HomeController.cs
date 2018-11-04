using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_14.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult ToFirstCompany()
        {
            return RedirectToAction("AboutCompany", "Company");
        }

        public ActionResult ToSecondCompany()
        {
            return RedirectToAction("AboutSecondCompany", "Company");
        }

        public ActionResult ToThirdCompany()
        {
            return RedirectToAction("AboutThirdCompany", "Company");
        }
    }
}