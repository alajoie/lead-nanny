using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeadNanny.Controllers
{
    public class SCManagementController : Controller
    {
        //
        // GET: /SCManagement/

        public ActionResult Index()
        {
            ViewBag.Message = "SC Quota Management Dashboard";
            return View();
        }

    }
}
