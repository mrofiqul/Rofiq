using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewPassingModel.Models;

namespace PartialViewPassingModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //Product aProduct = new Product();
            //aProduct.Name = "Ice cream";
            //aProduct.Price = 400;

            Product p1 = new Product() { Name = "Ice Cream", Price = 30 };
            Product p2 = new Product() { Name = "Burger", Price = 100 };
            Product p3 = new Product() { Name = "Buscuit", Price = 30 };
            Product p4 = new Product() { Name = "Potato", Price = 30 };

            List<Product> aproduList = new List<Product>();
            aproduList.Add(p1);
            aproduList.Add(p2);
            aproduList.Add(p3);
            aproduList.Add(p4);
    
            
            return View(aproduList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
