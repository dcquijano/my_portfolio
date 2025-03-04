using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.Controllers
{
    public class AboutController : Controller
    {

        public IActionResult AboutMe()
        {
            return View();
        }

       
    }
}
