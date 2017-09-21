using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        StorageContext db = new StorageContext();
        public ActionResult Index()
        {
            ViewBag.Products = db.Products;
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            SelectList services = new SelectList(db.Services, "Id", "Service1");
            ViewBag.Services = services;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product prod)
        {
            if(prod != null)
            {
                db.Products.Add(prod);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Product prod = db.Products.Find(id);
            if(prod == null)
            {
                return HttpNotFound();
            }
            db.Products.Remove(prod);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}