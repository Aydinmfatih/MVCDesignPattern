﻿using Microsoft.AspNetCore.Mvc;

namespace MVCDesignPattern.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
         
            return View();
        }
    }
}
