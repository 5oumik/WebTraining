using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebTraining.Controllers
{
    public class TrainingController : Controller
    {
        // GET: Training
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        public string Welcome()
        {
            return "This is Welcome action method...";
        }
    }
}