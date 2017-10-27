using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTraining.Controllers
{
    public class TrainingController : Controller
    {
        // GET: Training
        public ActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}