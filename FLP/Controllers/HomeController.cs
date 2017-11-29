using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FLP.Models.MainDataModel;

namespace FLP.Controllers
{
    public class HomeController : Controller
    {
        public static AllData AllData;

        public ActionResult Index()
        {
            if(AllData == null)
            {
                var LoadStartData = new LoadStartData();
                AllData = LoadStartData.LoadMainDataCategories();
            }
            return View(AllData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
    }
}