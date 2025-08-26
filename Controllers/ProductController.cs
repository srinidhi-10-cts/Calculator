using Microsoft.AspNetCore.Mvc;

namespace ECommercePlatform.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
