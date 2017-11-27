using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using FLP.Models;

namespace FLP.Controllers
{
    public class MaterialsController : Controller
    {

        public ActionResult WiFiMaterial()
        {
            return View();
        }
        public ActionResult Uslugi()
        {
            return View();
        }
        public ActionResult Qestions()
        {
            return View();
        }
        public ActionResult NetworksMaterial()
        {
            return View();
        }
        public ActionResult BildingMaterial()
        {
            return View();
        }
        public ActionResult SignalMaterial()
        {
            return View();
        }

    }
}