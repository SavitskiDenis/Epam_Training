using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_14.Controllers
{
    public class CompanyController : Controller
    {
        [Route("Ubisoft")]
        public ActionResult AboutCompany()
        {
            return View();
        }

        [Route("Nintendo")]
        public ActionResult AboutSecondCompany()
        {
            return View();
        }

        [Route("Valve")]
        public ActionResult AboutThirdCompany()
        {
            return View();
        }

    }
}