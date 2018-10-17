using Catfish.Areas.Manager.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Catfish.Survey.Areas.Manager.Controllers
{
    public class FormIngestionController : CatfishController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
