using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class RoleController : SMCSController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
