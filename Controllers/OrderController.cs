﻿using Microsoft.AspNetCore.Mvc;

namespace ECommercePlatform.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
