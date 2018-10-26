using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catfish.Survey.Areas.Manager.Controllers
{
    public class FormIngestionController : Controller
    {
        public FormIngestionController() : base()
        {
        }

        // GET: Manager/FormIngestion
        public ActionResult Index()
        {
            return View("Index", "Testing Views...");
        }
    }
}