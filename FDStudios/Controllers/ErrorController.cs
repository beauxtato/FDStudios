using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FDStudios.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult Index()
        {
            return View();
        }
        
        //
        // GET: /NotFound/ (404 Error)
        public ActionResult NotFound()
        {
            return View();
        }

        //
        // GET: /NotFound/ (Unknown Error)
        public ActionResult Unkonwn()
        {
            return View();
        }
    }
}
