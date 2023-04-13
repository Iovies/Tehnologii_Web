using Microsoft.AspNetCore.Mvc;

namespace SMCS.Web.Controllers
{
    public class SMCSController : Controller
    {
        private readonly ISession _session;

        public IActionResult Index()
        {
            return View();
        }
    }
}
