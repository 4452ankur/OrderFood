using OrderFood.Data.Models;
using OrderFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderToFood.web.Controllers
{
    public class RestruantsController : Controller
    {
        private readonly IRestruant db;

        // GET: Restruants
        public RestruantsController(IRestruant db1)
        {
            this.db = db1;
        }

      

        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if(model==null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]     
        public ActionResult Create(Restruant restruant)
        {
            if(ModelState.IsValid)
            {
                db.Add(restruant);
                return RedirectToAction("Details",new { id=restruant.Id});
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restruant restruant)
        {
            
            if (ModelState.IsValid)
            {
                db.Update(restruant);
                TempData["Message"] = "You have save data sucessfuly";
                return RedirectToAction("Details",new {id=restruant.Id});
            }
            return View(restruant);
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var model = db.Get(Id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,FormCollection formCollection)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
        
    }
}