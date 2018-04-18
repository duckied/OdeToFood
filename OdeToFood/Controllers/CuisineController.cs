using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    [Log]
    public class CuisineController : Controller
    {

       // [Authorize(Roles ="Admin")] Note you have have the user name instead of Admin in here or no parameters.
       //[Authorize]  //Note you can also place action contorllers on the controller and then you will have to be authorized 
                    //or loged in to Be abale to use the controller iteslf not just an action in the controller. If you have
                    // a log on page you will be redirected to it but this application doesn't have one/
        public ActionResult Search(string name = "French")
        {
            throw new Exception("Something went South!");
            var message = Server.HtmlEncode(name);
            return Content(message);
        }
        //// how to have an action with the same name but respond only to what you want it to do like a get or post request.
        //[HttpPost]
        //public ActionResult Search(string name = "french")
        //{
        //    var message = Server.HtmlEncode(name);

        //    return Content(message);
            
        //}
        //[HttpGet]
        //public ActionResult Search()
        //{
        //    return Content("Search!");
        //}

        //public ActionResult Search2(string name = "french")
        //{
        //    var message = Server.HtmlEncode(name);

        //    return Json(new { Message = message, Name = "Scott" }, JsonRequestBehavior.AllowGet);
        //    // return Content(message);
        //    //return RedirectPermanent("https://google.com");     // Permanent redirect never come back.
        //    //return RedirectToAction("Index", "Home", new { name = name });    // Temporaty redirect, anomusly typed obj.
        //    //  return RedirectToRoute("Default", new { controller = "Home", action = "About" });   
        //    // Redirect to a certain route by name. Values passed in new are not parameters but and
        //    //anomously typed object and will match up with how the routes are configured.
        //    //string iFile = @"C:\IADS4_Workspace\data\tm1-1520-237-23p_30january2017.iads";
        //    //return File(iFile, "text/iads");
        //  //  return FileResult(@"C:\IADS4_Workspace\data\tm1-1520-237-23p_30january2017.iads");
        //}
    }
}