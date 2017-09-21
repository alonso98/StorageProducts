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
            foreach (var item in db.Products)
            {
                
            }
            ViewBag.Products = db.Products;
            return View();
        }
    }
}