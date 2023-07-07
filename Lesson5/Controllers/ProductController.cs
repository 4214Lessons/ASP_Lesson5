using Lesson5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson5.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> products = new();


        [HttpGet] // default olaraq HttpGet
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            products.Add(product);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(products);
        }

        //public IActionResult Get(string a, string d)
        //{
        //    return RedirectToAction("Index");
        //}

        public IActionResult Get()
        {
            var a = Request.Query["a"];
            var d = Request.Query["d"];
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public IActionResult AddProduct(IFormCollection keyValues)
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AddProduct(string name, string description, string price, string count)
        //{
        //    return View();
        //}
    }
}
