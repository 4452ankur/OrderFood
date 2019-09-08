using OrderFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderToFood.web.Controllers
{
    public class HomeController : Controller
    {
        IRestruant db;
        public HomeController(IRestruant db1)
        {
            //  db = new RestruantsData();
            this.db = db1;
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
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