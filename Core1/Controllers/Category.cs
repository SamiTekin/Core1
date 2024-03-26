using Microsoft.AspNetCore.Mvc;

namespace Core1.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
