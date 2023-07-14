using Microsoft.AspNetCore.Mvc;
using MVCDesignPattern.Models;

namespace MVCDesignPattern.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            var product = new Product();
            return View();
        }
        [NonAction]
        public void X()
        {

        }
    }
}
