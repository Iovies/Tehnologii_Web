using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
