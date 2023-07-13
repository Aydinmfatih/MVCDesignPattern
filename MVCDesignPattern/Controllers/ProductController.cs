using Microsoft.AspNetCore.Mvc;

namespace MVCDesignPattern.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {

            return View();
        }
    }
}
