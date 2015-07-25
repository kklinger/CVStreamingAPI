using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVStreamingAPI.Models;

namespace CVStreamingAPI.Controllers
{
    public class CVStreamChartController : Controller
    {
        //
        // GET: /Test1/

        public ActionResult Index(string id)
        {
            var myModel = new CVStreamChart();
            myModel.name = "KlingerDev " + id;
            myModel.now = DateTime.Now;
            return View(myModel);
        }

    }
}
