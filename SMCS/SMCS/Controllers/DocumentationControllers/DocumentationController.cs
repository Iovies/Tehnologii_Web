using Microsoft.AspNetCore.Mvc;

namespace SMCS.Controllers
{
    public class DocumentationController : Controller
    {
        [HttpGet]
        [Route("docs")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
