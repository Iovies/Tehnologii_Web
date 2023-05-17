using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
