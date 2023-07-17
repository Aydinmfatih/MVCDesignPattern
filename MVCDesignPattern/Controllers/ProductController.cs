using Microsoft.AspNetCore.Mvc;
using MVCDesignPattern.Models;
using System.Collections.Generic;

namespace MVCDesignPattern.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product> {
             new Product { Id = 1 , ProductName="A Product", Quantity=19},
             new Product { Id = 2, ProductName = "A Product", Quantity = 98 },
             new Product { Id = 3, ProductName = "A Product", Quantity = 16 }
                };
            return View(products);
        }
       
    }
}
