using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers.IdentityControllers
{
    public class ProfileController : SMCSController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
