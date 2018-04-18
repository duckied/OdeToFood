using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var imodel = new IndexModel();
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            var message = ($"{controller}, {action}, {id}: controller, action , id");

          //  ViewBag.Message = message;
            imodel.contrl = message;
            imodel.pge = "This";
            return View(imodel);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Break";
            model.Location = "HSV, US";
            //ViewBag.Message = "Your application description page.";
            //ViewBag.Location = "MaryLand, USA";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}