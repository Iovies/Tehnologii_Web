using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class SMCSUserController : SMCSController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
