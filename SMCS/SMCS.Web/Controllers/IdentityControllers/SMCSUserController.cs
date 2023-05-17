using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class SMCSUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
