using Microsoft.AspNetCore.Mvc;

namespace Controllers.HomeControllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
