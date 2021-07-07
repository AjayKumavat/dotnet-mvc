using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopManagement.Models;
using PagedList;

namespace ShopManagement.Controllers
{
    public class ProductDetailsController : Controller
    {
        // GET: ProductDetails
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Product> productdetails = db.Product.ToList();
            List<Category> categorydetails = db.Category.ToList();

            var combinedetails = from c in categorydetails
                                 join p in productdetails on c.CategoryId equals p.CategoryId into table1
                                 from p in table1.DefaultIfEmpty()
                                 select new ProductDetails { categoryDetails = c, productDetails = p };


            return View(combinedetails);
            //return Json(new { data = combinedetails }, JsonRequestBehavior.AllowGet);
        }

    }
}