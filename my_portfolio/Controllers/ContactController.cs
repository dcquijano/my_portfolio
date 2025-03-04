using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.Controllers
{
    public class ContactController : Controller
    {

        public IActionResult MyContact()
        {
            return View();
        }
    }
}
 