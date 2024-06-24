using Microsoft.AspNetCore.Mvc;

namespace Core1.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
