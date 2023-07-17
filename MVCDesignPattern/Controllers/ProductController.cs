using Microsoft.AspNetCore.Mvc;
using MVCDesignPattern.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace MVCDesignPattern.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product> {
             new Product { Id = 1 , ProductName="A Product", Quantity=19},
             new Product { Id = 2, ProductName = "b Product", Quantity = 98 },
             new Product { Id = 3, ProductName = "c Product", Quantity = 16 }
                };
            var data = JsonSerializer.Serialize(products);

            //ViewBag.x = "5";
            //ViewData["x"] = 5;
           TempData["products"] =data;


            return RedirectToAction("Index2","Product");
        }

        public IActionResult Index2()
        {
            var v1 = ViewBag.products;
            var v2 = ViewData["x"];
            var v3 = TempData["x"];
            var data = TempData["products"].ToString();
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(data);
            return View();
        }

    }
}
