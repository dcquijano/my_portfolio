using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult MyProject()
        {
            return View();
        }
    }
}
