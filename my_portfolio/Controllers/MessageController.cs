using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult MessageUs()
        {
            return View();
        }
    }
}
