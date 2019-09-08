using OrderToFood.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace OrderToFood.web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            // Query String
            //  var Name = HttpContext.Request.QueryString["name"];
            model.Name = name??"No Name";
            model.Message = ConfigurationManager.AppSettings["message"];   
            return View(model);
        }
    }
}