using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMVCApplication.Models;

namespace SampleMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            SampleData sample = new SampleData {
                id = 1,
                name = "Zach",
                location = "Ann Arbor"
            };
            ViewBag.SampleText = "ViewBag sample text";
            return View(sample);
        }

    }
}
